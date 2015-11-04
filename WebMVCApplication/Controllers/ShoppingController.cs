using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCApplication.Models;
using WebMVCApplication.ServiceReferenceShopBanGiayPro;

namespace WebMVCApplication.Controllers
{
    public class ShoppingController : Controller
    {
        ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();
        private List<ShopBanGiayProEntity> CartList = new List<ShopBanGiayProEntity>();

        public ActionResult Index()
        {
            return View();
        }
        //Add một sản phẩm mới
        #region[Add To Cart]
        public ActionResult ShowCart()
        {
            return View();
        }
        public ActionResult AddToCart(string id, float gia)
        {
            if (Session["Cart"] != null)
            {
                CartList = (List<ShopBanGiayProEntity>)Session["Cart"];
                var OldCart = CartList.Find(m => m.MaGiay == id);
                if (OldCart != null)
                {
                    var NewCart = new ShopBanGiayProEntity { MaGiay = id, SoLuong = OldCart.SoLuong + 1, DonGia = gia };
                    CartList.Remove(OldCart);
                    CartList.Add(NewCart);
                }
                else
                {
                    CartList.Add(new ShopBanGiayProEntity { MaGiay = id, SoLuong = 1, DonGia = gia });
                }
            }
            else
            {
                CartList.Add(new ShopBanGiayProEntity { MaGiay = id, SoLuong = 1, DonGia = gia });
            }
            Session["Cart"] = CartList;
            return RedirectToAction("ShowCart");
        }
        #endregion
        //Xóa sản phẩm trong giỏ hàng
        #region[Remove Cart]
        public ActionResult RemoveCart(string id)
        {
            var CartList = (List<ShopBanGiayProEntity>)Session["Cart"];
            var _Cart = CartList.SingleOrDefault(m => m.MaGiay == id);
            CartList.Remove(_Cart);
            Session["Cart"] = CartList;
            //return new EmptyResult();
            return RedirectToAction("ShowCart");
        }
        #endregion
        //tạo đơn hàng
        #region[Create Cart]

        private string layMaHDTT()
        {
            string MaHD = db.LayMaHDTT();
            if (MaHD == "")
            {
                return "HD000001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "ML"; //Lấy ký tự mặc định trong mã đã có
                k = Convert.ToInt32(MaHD.ToString().Substring(2, 6));
                k = k + 1;
                if (k < 10)
                    s += "00000";
                else if (k < 100)
                    s += "0000";
                else if (k < 1000)
                    s += "000";
                else if (k < 10000)
                    s += "00";
                else if (k < 100000)
                    s += "0";
                s += k.ToString();
                return s;
            }
        }
        public ActionResult Create()
        {
            if (Session["LogedUserFullname"] != null)
            {
                string smahd = layMaHDTT();
                string suser = Session["LogedUserID"].ToString();
                DateTime dngaymua = DateTime.Now.Date;
                float ftongtien = 0;

                string smasp = "";
                int isoluong = 0;
                float fthanhtien = 0;

                CartList = (List<ShopBanGiayProEntity>)Session["Cart"];
                foreach (var item in CartList)
                {

                    ftongtien = ftongtien + (item.SoLuong * item.DonGia);
                }
                db.insertHoaDon(smahd, suser, dngaymua);

                foreach (var item in CartList)
                {
                    smasp = item.MaGiay;
                    isoluong = item.SoLuong;
                    fthanhtien = item.DonGia * item.SoLuong;

                    db.insertCTHoaDon(smahd, smasp, isoluong, fthanhtien);
                }
                Session["Cart"] = null;
                return View();
            }
            else
            {
                return RedirectToAction("LoginCart", "Account");
            }
        }
        #endregion
        //Hiện thị số sản phẩm trong giỏ hàng bên phải
        #region[Cart]
        public ActionResult Cart()
        {
            int soluong = 0;
            CartList = (List<ShopBanGiayProEntity>)Session["Cart"];
            if (CartList != null)
            {
                foreach (var item in CartList)
                {
                    soluong += item.SoLuong;
                }
            }
            return View(soluong);
        }
        #endregion
        //cập nhật số lượng trong giỏ hàng
        #region[Cap Nhat So Luong]
        public ActionResult CapNhatSoLuong(string id, string soluong)
        {
            try
            {
                int a = int.Parse(soluong.ToString());
                try
                {
                    if (a < 0)
                    {
                        ViewBag.loisl = "Số lượng không được nhỏ hơn 0!";
                        return PartialView("ShowCart");
                    }
                }
                catch
                {
                    ViewBag.loisl = "Số lượng nhập không đúng!";
                    return PartialView("ShowCart");
                }
                if (a > db.LaySoLuongSP(id))
                {
                    ViewBag.loi = "Số lượng Mã SP: " + id + " không đủ, chỉ còn: " + db.LaySoLuongSP(id);
                }
                else if (a == 0)
                {
                    CartList = (List<ShopBanGiayProEntity>)Session["Cart"];

                    foreach (var item in CartList)
                    {
                        if (item.MaGiay == id)
                        {
                            RemoveCart(id);
                            return PartialView("ShowCart");
                        }
                    }
                }
                else
                {
                    if (Session["Cart"] != null)
                    {
                        CartList = (List<ShopBanGiayProEntity>)Session["Cart"];

                        foreach (var item in CartList)
                        {
                            if (item.MaGiay == id)
                                item.SoLuong = a;
                        }
                    }
                }
                return PartialView("ShowCart");
                //return RedirectToAction("ShowCart");
            }
            catch
            {
                ViewBag.loisl = "Số lượng không được nhập ký tự chữ cái!";
                return PartialView("ShowCart");
            }
        }
        #endregion
    }
}
