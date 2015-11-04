using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCApplication.ServiceReferenceShopBanGiayPro;

namespace WebMVCApplication.Controllers
{
    public class ProductController : Controller
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();
        int pagesize = 16;
        //Trang chủ sản phẩm
        #region[Index]
        public ActionResult Index()
        {
            return View(db.findAllSanPhamMoiNhat());
        }
        #endregion
        //Tìm kiếm nâng cao
        #region[Tim Kiem Nang Cao]
        public ActionResult TimKiemNangCao()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TimKiemNangCao(FormCollection f)
        {
            string mansx = f["nhasanxuat"];
            float giatu = float.Parse(f["giatu"]);
            float giaden = float.Parse(f["giaden"]);

            var pro = db.SearchSanPhamNangCao(mansx, giatu, giaden).OrderByDescending(x => x.gia);

            return View(pro.Take(12));
        }

        public ActionResult DSLoaiTimKiem()
        {
            return View(db.findAllNhaSX());
        }
        #endregion
        //Chi tiết sản phẩm
        #region[Detail]
        public ActionResult Detail(string id)
        {
            return View(db.findCTSanPham(id));
        }
        #endregion
        //Menu
        #region[Menu]
        public ActionResult Menu()
        {
            return View(db.findAllLoai().Take(5));
        }
        #endregion
        //Hiện sản phẩm theo loại
        #region[Category]
        public ActionResult Category(string id, int page = 1)
        {
            var sanpham = db.findMaLoaiSanPham(id).ToList();
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / pagesize);
            ViewBag.MaLoai = id;
            return View(sanpham.Skip((page - 1) * pagesize).Take(pagesize));
            //return View(db.findMaLoaiSanPham(id));
        }
        #endregion
        //Tìm kiếm
        #region[Search]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchComplete(sanpham sp)
        {
            string ten = sp.tensp;
            if (ten != null)
            {
                using (db)
                {
                    if (db.findTenSanPham(ten) != null)
                    {
                        ViewBag.KhongTimThay = ten;
                        return View(db.findTenSanPham(ten).Take(16));
                    }
                    else
                        return RedirectToAction("SearchComplete", "Product");
                }
            }
            return RedirectToAction("SearchComplete", "Product");
        }
        #endregion
        //Xem đơn hàng đã mua
        #region[Don Hang Da Mua]
        public ActionResult DonHangDaMua(string user)
        {
            if (Session["LogedUserID"] != null)
            {
                return View(db.findAllHoaDonDaMua(user));
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }

        public ActionResult ChiTietDonHang(string mhd)
        {

            if (Session["LogedUserID"] != null)
            {
                Session["mhd"] = mhd;
                if (db.checkHoDonHoanThanhChua(mhd))
                    Session["kthoanthanh"] = "true";
                else
                    Session["kthoanthanh"] = "false";
                return View(db.findListCTHoaDon(mhd));
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }

        public ActionResult XoaDonHang(string mhd)
        {
            if (Session["LogedUserID"] != null)
            {
                db.deleteActiveHoaDon(mhd);
                return RedirectToAction("DonHangDaMua", "Product", new { user = Session["LogedUserID"].ToString() });
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }

        public ActionResult SuaChiTietDonHang(int id)
        {
            if (Session["LogedUserID"] != null)
            {
                return View(db.findCTHoaDonID(id));
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaChiTietDonHang(FormCollection conllection)
        {
            if (Session["LogedUserID"] != null)
            {
                int iid = int.Parse(conllection["txtid"]);
                string smahd = conllection["txtmahd"];
                string smasp = conllection["txtmasp"];
                int isoluong = int.Parse(conllection["txtsoluong"]);
                float fgia = (float)db.LayGiaSP(smasp);
                float fthanhtien = isoluong * fgia;

                db.updateCTHoaDon(iid, smahd, smasp, isoluong, fthanhtien);
                return RedirectToAction("ChiTietDonHang", "Product", new { mhd = Session["mhd"].ToString() });
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }

        public ActionResult XoaChiTietDonHang(int id)
        {
            if (Session["LogedUserID"] != null)
            {
                db.deleteCTHoaDon(id);
                return RedirectToAction("ChiTietDonHang", "Product", new { mhd = Session["mhd"].ToString() });
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }
        #endregion
    }
}
