using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCApplication.ServiceReferenceShopBanGiayPro;
using System.Web.Security;

namespace WebMVCApplication.Controllers
{
    public class AccountController : Controller
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();
        //Index user
        #region[Index User]
        public ActionResult IndexUser()
        {
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginUser");
            }
        }
        #endregion
        //Đăng nhập
        #region[Login User]
        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLoginUser(user u)
        {
            string user = u.username;
            string pass = u.password;

            if (user != null && pass != null)
            {
                using (db)
                {
                    if (db.checkLoginUser(user, pass))
                    {
                        var v = db.findLoginUser(user, pass);
                        if (v != null)
                        {
                            Session["LogedUserID"] = v.username.ToString();
                            Session["LogedUserFullname"] = v.hoten.ToString();
                            Session["LogedUserImages"] = v.hinh.ToString();
                            return RedirectToAction("Index", "Product");
                        }
                    }
                    return RedirectToAction("Index", "Product");
                }
            }
            return RedirectToAction("Index", "Product");
        }
        #endregion
        //Đăng nhập để mua hàng
        #region[Login Cart]
        public ActionResult LoginCart()
        {
            if (Session["LogedUserFullname"] != null)
                return RedirectToAction("Index", "Product");
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginCart(user u)
        {
            string user = u.username;
            string pass = u.password;

            if (user != null && pass != null)
            {
                using (db)
                {
                    if (db.checkLoginUser(user, pass))
                    {
                        var v = db.findLoginUser(user, pass);
                        if (v != null)
                        {
                            Session["LogedUserID"] = v.username.ToString();
                            Session["LogedUserFullname"] = v.hoten.ToString();
                            Session["LogedUserImages"] = v.hinh.ToString();
                            return RedirectToAction("Create", "Shopping");
                        }
                    }
                    return RedirectToAction("LoginCart", "Account");
                }
            }
            return RedirectToAction("LoginCart", "Account");
        }
        #endregion
        //Kết quả sau khi đang nhập
        #region[After Login]
        public ActionResult AfterLoginUser()
        {
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginUser");
            }
        }

        public ActionResult ProfileUser(string id)
        {
            return View(db.findUser(id));
        }
        #endregion
        //Đăng xuất
        #region[Logout User]
        public ActionResult LogoutUser()
        {
            System.Web.HttpContext.Current.Response.Cookies.Clear();
            FormsAuthentication.SignOut();
            Session["LogedUserID"] = null;
            Session["LogedUserFullname"] = null;
            Session["LogedUserImages"] = null;
            return RedirectToAction("Index", "Product");
        }
        #endregion
        //Đăng ký thành viên
        #region[regidter User]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult RegisterUser(FormCollection conllection)
        {
            try
            {
                string suser = conllection["txtusername"];
                string spass = conllection["txtpassword"];
                string shoten = conllection["txthoten"];
                bool sgioitinhnam;
                if (conllection["txtgioitinh"] == "nam")
                    sgioitinhnam = true;
                else
                    sgioitinhnam = false;
                DateTime ingaysinh = DateTime.Parse(conllection["txtngaysinh"]);
                string sdiachi = conllection["txtdiachi"];
                string ssdt = conllection["txtsdt"];
                string shinh = conllection["hinh"];
                string semail = conllection["txtemail"];
                string squyenhang = "user";

                if (db.insertUser(suser, spass, shoten, sgioitinhnam, ingaysinh, sdiachi, ssdt, shinh, semail, squyenhang))
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    return RedirectToAction("RegisterUser", "Account");
                }
            }
            catch
            {
                return RedirectToAction("RegisterUser", "Account");
            }
        }
        #endregion
        //Sửa thông tin tài khoản
        #region[Edit User]
        public ActionResult EditUser(string id, string goitinh, string quyenhang)
        {
            ViewBag.gioitinh = goitinh;
            ViewBag.quyenhang = quyenhang;
            return View(db.findUser(id));
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditUser(FormCollection conllection)
        {
            string suser = conllection["txtusername"];
            string spass = conllection["txtpassword"];
            string shoten = conllection["txthoten"];
            bool sgioitinhnam;
            if (conllection["txtgioitinh"] == "nam")
                sgioitinhnam = true;
            else
                sgioitinhnam = false;
            DateTime ingaysinh = DateTime.Parse(conllection["txtngaysinh"]);
            string sdiachi = conllection["txtdiachi"];
            string ssdt = conllection["txtsdt"];
            string shinh = conllection["hinh"];
            string semail = conllection["txtemail"];
            string squyenhang = conllection["txtquyenhang"];

            db.updateUser(suser, spass, shoten, sgioitinhnam, ingaysinh, sdiachi, ssdt, shinh, semail, squyenhang);
            return RedirectToAction("Index", "Product");
        }
        #endregion
    }
}
