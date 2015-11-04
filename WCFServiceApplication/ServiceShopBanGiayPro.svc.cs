using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceShopBanGiayPro" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceShopBanGiayPro.svc or ServiceShopBanGiayPro.svc.cs at the Solution Explorer and start debugging.
    public class ServiceShopBanGiayPro : IServiceShopBanGiayPro
    {
        private DataClassesShopBanGiayProDataContext db = new DataClassesShopBanGiayProDataContext();

        //Service tài khoản
        #region[user]
        public List<user> finAllUser()
        {
            return this.db.users.Where(m => m.Active == true).ToList();
        }

        public List<user> findTenUser(string ten)
        {
            var u = (from p in db.users select p).ToList();
            if (!String.IsNullOrEmpty(ten))
            {
                u = u.Where(a => a.username.ToLower().Contains(ten)).ToList();
            }
            return u.ToList();
        }

        public user findUser(string user)
        {
            return db.users.Single(m => m.username == user);
        }

        public bool checkUser(string user, string pass)
        {
            try
            {
                user u = db.users.Single(m => m.username == user);
                if (u != null)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool checkLoginAdmin(string user, string pass, string quyen, bool Active)
        {
            try
            {
                user u = db.users.Single(m => m.username == user && m.password == pass && m.quyenhang == quyen && m.Active == Active);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public user findLoginAdmin(string user, string pass, string quyen)
        {
            return db.users.Single(m => m.username == user && m.password == pass && m.quyenhang == quyen);
        }

        public bool checkLoginUser(string user, string pass)
        {
            try
            {
                user u = db.users.Single(m => m.username == user && m.password == pass && m.Active == true && m.quyenhang == "user");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool checkLoginUserCart(string user, string pass, string quyenhang)
        {
            try
            {
                user u = db.users.Single(m => m.username == user && m.password == pass && m.quyenhang == quyenhang && m.Active == true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public user findLoginUser(string user, string pass)
        {
            return db.users.Single(m => m.username == user && m.password == pass && m.Active == true && m.quyenhang == "user");
        }

        public user findLoginUserCart(string user, string pass, string quyenhang)
        {
            return db.users.Single(m => m.username == user && m.password == pass && m.quyenhang == quyenhang && m.Active == true);
        }

        public bool insertUser(string user, string pass, string hoten, bool gioitinh, DateTime ngay, string diachi, string sdt, string hinh, string email, string quyen)
        {
            try
            {
                user u = new user();
                u.username = user;
                u.password = pass;
                u.hoten = hoten;
                u.gioitinhnam = gioitinh;
                u.ngaysinh = ngay;
                u.diachi = diachi;
                u.sdt = sdt;
                u.hinh = hinh;
                u.email = email;
                u.quyenhang = quyen;
                u.Active = true;
                db.users.InsertOnSubmit(u);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteUser(string user)
        {
            try
            {
                user u = db.users.Single(m => m.username == user);
                db.users.DeleteOnSubmit(u);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteActiveUser(string user)
        {
            try
            {
                user u = db.users.Single(m => m.username == user);
                u.Active = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateUser(string user, string pass, string hoten, bool gioitinh, DateTime ngay, string diachi, string sdt, string hinh, string email, string quyen)
        {
            try
            {
                user u = db.users.Single(m => m.username == user);
                u.password = pass;
                u.hoten = hoten;
                u.gioitinhnam = gioitinh;
                u.ngaysinh = ngay;
                u.diachi = diachi;
                u.sdt = sdt;
                u.hinh = hinh;
                u.email = email;
                u.quyenhang = quyen;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service Sản phẩm
        #region[sanpham]
        public List<sanpham> findAllSanPham()
        {
            return this.db.sanphams.Where(m => m.Active == true).ToList();
        }

        public List<sanpham> findAllSanPhamDaXoa()
        {
            return this.db.sanphams.Where(m => m.Active == false).ToList();
        }

        public string LayMaSPTT()
        {
            string MaSP = "";
            List<sanpham> l = (from o in db.sanphams where o.id == o.id && o.Active == true orderby o.id descending select o).Take(1).ToList();
            foreach (var item in l)
            {
                MaSP = item.masp;
            }
            return MaSP;
        }

        //Tim kiem nang cao
        public List<sanpham> SearchSanPhamNangCao(string mansx, float giatu, float giaden)
        {
            var list = new List<sanpham>();
            using (db)
            {
                try
                {
                    var sanpham = (from s in db.sanphams where s.Active == true select s).ToList();
                    if (mansx == "0" && giatu == 0 && giaden == 0)
                    {
                        sanpham = sanpham.ToList();
                    }
                    else if (mansx == "0" && giatu == 0 && giaden > 0)
                    {
                        sanpham = sanpham.Where(s => s.gia < giaden).ToList();
                    }
                    else if (mansx == "0" && giatu > 0 && giaden > 0)
                    {
                        sanpham = sanpham.Where(s => s.gia < giaden && s.gia > giatu).ToList();
                    }
                    else if (mansx == "0" && giatu > 0 && giaden == 0)
                    {
                        sanpham = sanpham.Where(s => s.gia > giatu).ToList();
                    }
                    else if (mansx != "0" && giatu == 0 && giaden == 0)
                    {
                        sanpham = sanpham.Where(s => s.mansx == mansx).ToList();
                    }
                    else if (mansx != "0" && giatu > 0 && giaden == 0)
                    {
                        sanpham = sanpham.Where(s => s.mansx == mansx && s.gia > giatu).ToList();
                    }
                    else if (mansx != "0" && giatu == 0 && giaden > 0)
                    {
                        sanpham = sanpham.Where(s => s.mansx == mansx && s.gia < giaden).ToList();
                    }
                    else if (mansx != "0" && giatu > 0 && giaden > 0)
                    {
                        sanpham = sanpham.Where(s => s.mansx == mansx && s.gia < giaden && s.gia > giatu).ToList();
                    }
                    else
                    {
                        sanpham = sanpham.ToList();
                    }

                    foreach (sanpham item in sanpham)
                    {
                        sanpham sp = new sanpham()
                        {
                            id = item.id,
                            masp = item.masp,
                            mansx = item.mansx,
                            tensp = item.tensp,
                            soluong = item.soluong,
                            gia = item.gia,
                            ngaynhap = item.ngaynhap,
                            hinh = item.hinh
                        };
                        list.Add(sp);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }

        public List<sanpham> findTenSanPham(string ten)
        {
            var product = (from p in db.sanphams where p.Active == true select p).ToList();
            if (!String.IsNullOrEmpty(ten))
            {
                product = product.Where(a => a.tensp.ToLower().Contains(ten)).ToList();
            }
            return product.ToList();
        }

        public List<sanpham> findTenSanPhamDaXoa(string ten)
        {
            var product = (from p in db.sanphams where p.Active == false select p).ToList();
            if (!String.IsNullOrEmpty(ten))
            {
                product = product.Where(a => a.tensp.ToLower().Contains(ten)).ToList();
            }
            return product.ToList();
        }

        public float LayGiaSP(string masp)
        {
            var sp = db.sanphams.Single(m => m.masp == masp && m.Active == true);
            float gia = (float)sp.gia;
            return gia;
        }

        public int LaySoLuongSP(string masp)
        {
            var sp = db.sanphams.Single(m => m.masp == masp && m.Active == true);
            int sl = (int)sp.soluong;
            return sl;
        }

        public List<sanpham> findAllSanPhamMoiNhat()
        {
            var s = from o in db.sanphams
                    where o.id >= o.id && o.Active == true orderby o.id descending
                    select o;
            return s.Take(8).ToList();
        }

        public sanpham findSanPham(string msp)
        {
            return db.sanphams.Single(m => m.masp == msp && m.Active == true);
        }

        public List<sanpham> findMaLoaiSanPham(string ml)
        {
            var s = from o in db.sanphams
                    where o.maloai == ml && o.Active == true
                    orderby o.id descending
                    select o;
            return s.ToList();
        }

        public bool insertSanPham(string msp, string ml, string mnsx, string ten, int sl, float gia, DateTime ngay, string hinh)
        {
            try
            {
                sanpham sp = new sanpham();
                sp.masp = msp;
                sp.maloai = ml;
                sp.mansx = mnsx;
                sp.tensp = ten;
                sp.soluong = sl;
                sp.gia = gia;
                sp.ngaynhap = ngay;
                sp.hinh = hinh;
                sp.Active = true;
                db.sanphams.InsertOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteSanPham(string msp)
        {
            try
            {
                sanpham sp = db.sanphams.Single(m => m.masp == msp);
                db.sanphams.DeleteOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteActiveSanPham(string msp)
        {
            try
            {
                sanpham sp = db.sanphams.Single(m => m.masp == msp);
                sp.Active = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateSanPham(string msp, string ml, string mnsx, string ten, int sl, float gia, DateTime ngay, string hinh)
        {
            try
            {
                sanpham sp = db.sanphams.Single(m => m.masp == msp);
                sp.maloai = ml;
                sp.mansx = mnsx;
                sp.tensp = ten;
                sp.soluong = sl;
                sp.gia = gia;
                sp.ngaynhap = ngay;
                sp.hinh = hinh;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool KhoiPhucSanPham(string msp)
        {
            try
            {
                sanpham sp = db.sanphams.Single(m => m.masp == msp);
                sp.Active = true;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateSoLuongSanPham(string msp, int soluong)
        {
            try
            {
                sanpham sp = db.sanphams.Single(m => m.masp == msp);
                sp.soluong = soluong;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service Chi tiết sản phẩm
        #region[ct_sanpham]
        public List<ct_sanpham> findAllCTSanPham()
        {
            return this.db.ct_sanphams.ToList();
        }

        public List<ct_sanpham> findListCTSanPham(string masp)
        {
            return this.db.ct_sanphams.Where(m => m.masp == masp).ToList();
        }

        public ct_sanpham findCTSanPham(string msp)
        {
            return db.ct_sanphams.Single(m => m.masp == msp);
        }

        public bool checkCTSanPham(string msp)
        {
            try
            {
                List<ct_sanpham> ct = db.ct_sanphams.Where(m => m.masp == msp).ToList();
                if (ct.Count < 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertCTSanPham(string msp, string xs, string mausac, string kieudang, string chatlieu, string mota)
        {
            try
            {
                ct_sanpham ct = new ct_sanpham();
                ct.masp = msp;
                ct.xuatxu = xs;
                ct.mausac = mausac;
                ct.kieudang = kieudang;
                ct.chatlieu = chatlieu;
                ct.mota = mota;
                db.ct_sanphams.InsertOnSubmit(ct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCTSanPham(string msp)
        {
            try
            {
                ct_sanpham ct = db.ct_sanphams.Single(m => m.masp == msp);
                db.ct_sanphams.DeleteOnSubmit(ct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateCTSanPham(string msp, string xs, string mausac, string kieudang, string chatlieu, string mota)
        {
            try
            {
                ct_sanpham ct = db.ct_sanphams.Single(m => m.masp == msp);
                ct.xuatxu = xs;
                ct.mausac = mausac;
                ct.kieudang = kieudang;
                ct.chatlieu = chatlieu;
                ct.mota = mota;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service Loại sản phẩm
        #region[loai]
        public List<loai> findAllLoai()
        {
            return this.db.loais.Where(m => m.Active == true).ToList();
        }

        public loai findLoai(string ml)
        {
            return db.loais.Single(l => l.maloai == ml && l.Active ==  true);
        }

        public string LayMaLoaiTT()
        {
            string MaLoai = "";
            List<loai> l = (from o in db.loais where o.id == o.id && o.Active == true orderby o.id descending select o).Take(1).ToList();
            foreach (var item in l)
            {
                MaLoai = item.maloai;
            }
            return MaLoai;
        }

        public List<loai> findTenLoai(string ten)
        {
            var l = (from p in db.loais where p.Active == true select p).ToList();
            if (!String.IsNullOrEmpty(ten))
            {
                l = l.Where(a => a.ten.ToLower().Contains(ten)).ToList();
            }
            return l.ToList();
        }

        public bool insertLoai(string mal, string tenl)
        {
            try
            {
                loai l = new loai();
                l.maloai = mal;
                l.ten = tenl;
                l.Active = true;
                db.loais.InsertOnSubmit(l);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteLoai(string mal)
        {
            try
            {
                loai l = db.loais.Single(d => d.maloai == mal);
                db.loais.DeleteOnSubmit(l);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteActiveLoai(string mal)
        {
            try
            {
                loai l = db.loais.Single(d => d.maloai == mal);
                l.Active = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateLoai(string mal, string tenl)
        {
            try
            {
                loai l = db.loais.Single(d => d.maloai == mal);
                l.ten = tenl;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service Nhà sản xuất
        #region[nhasx]
        public List<nhasx> findAllNhaSX()
        {
            return this.db.nhasxes.Where(m => m.Active == true).ToList();
        }

        public nhasx findNhaSX(string mnsx)
        {
            return db.nhasxes.Single(m => m.mansx == mnsx && m.Active == true);
        }

        public string LayMaNSXTT()
        {
            string MaNSX = "";
            List<nhasx> l = (from o in db.nhasxes where o.id == o.id && o.Active == true orderby o.id descending select o).Take(1).ToList();
            foreach (var item in l)
            {
                MaNSX = item.mansx;
            }
            return MaNSX;
        }

        public List<nhasx> findTenNhaSX(string ten)
        {
            var l = (from p in db.nhasxes where p.Active == true select p).ToList();
            if (!String.IsNullOrEmpty(ten))
            {
                l = l.Where(a => a.ten.ToLower().Contains(ten)).ToList();
            }
            return l.ToList();
        }

        public bool insertNhaSX(string mnsx, string ten, string diachi, string hinh)
        {
            try
            {
                nhasx n = new nhasx();
                n.mansx = mnsx;
                n.ten = ten;
                n.diachi = diachi;
                n.hinh = hinh;
                n.Active = true;
                db.nhasxes.InsertOnSubmit(n);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteNhaSX(string mnsx)
        {
            try
            {
                nhasx n = db.nhasxes.Single(m => m.mansx == mnsx);
                db.nhasxes.DeleteOnSubmit(n);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteActiveNhaSX(string mnsx)
        {
            try
            {
                nhasx n = db.nhasxes.Single(m => m.mansx == mnsx);
                n.Active = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateNhaSX(string mnsx, string ten, string diachi, string hinh)
        {
            try
            {
                nhasx n = db.nhasxes.Single(m => m.mansx == mnsx);
                n.ten = ten;
                n.diachi = diachi;
                n.hinh = hinh;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service Hóa đơn
        #region[hoadon]
        public List<hoadon> findAllHoaDon()
        {
            return this.db.hoadons.Where(m => m.Active == true).ToList();
        }

        public List<hoadon> findAllHoaDonChuaHT()
        {
            return this.db.hoadons.Where(m => m.Active == true && m.hoanthanh == false).ToList();
        }

        public bool checkHoDonHoanThanhChua(string mhd)
        {
            try
            {
                db.hoadons.Single(m => m.mahd == mhd && m.hoanthanh == true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string LayMaHDTT()
        {
            string MaHD = "";
            List<hoadon> l = (from o in db.hoadons where o.id == o.id orderby o.id descending select o).Take(1).ToList();
            foreach (var item in l)
            {
                MaHD = item.mahd;
            }
            return MaHD;
        }

        public List<hoadon> findAllHoaDonDaMua(string user)
        {
            return db.hoadons.Where(m => m.username == user && m.Active == true).ToList();
        }

        public List<hoadon> findListHoaDonChuaXong()
        {
            return db.hoadons.Where(m => m.hoanthanh == false && m.Active == true).ToList();
        }

        public List<hoadon> findMaHoaDon(string ten)
        {
            var l = (from p in db.hoadons where p.Active == true select p).ToList();
            if (!String.IsNullOrEmpty(ten))
            {
                l = l.Where(a => a.mahd.ToLower().Contains(ten)).ToList();
            }
            return l.ToList();
        }

        public hoadon findHoaDon(string mhd)
        {
            return db.hoadons.Single(m => m.mahd == mhd && m.Active == true);
        }

        public List<hoadon> findListHoaDon(string mhd)
        {
            return db.hoadons.Where(m => m.mahd == mhd && m.Active == true).ToList();
        }

        public bool insertHoaDon(string mhd, string user, DateTime ngay)
        {
            try
            {
                hoadon h = new hoadon();
                h.mahd = mhd;
                h.username = user;
                h.ngaymua = ngay;
                h.hoanthanh = false;
                h.Active = true;
                db.hoadons.InsertOnSubmit(h);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteHoaDon(string mhd)
        {
            try
            {
                hoadon h = db.hoadons.Single(m => m.mahd == mhd);
                db.hoadons.DeleteOnSubmit(h);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateHoaDon(string mhd, DateTime ngay)
        {
            try
            {
                hoadon h = db.hoadons.Single(m => m.mahd == mhd);
                h.ngaymua = ngay;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteActiveHoaDon(string mhd)
        {
            try
            {
                hoadon h = db.hoadons.Single(m => m.mahd == mhd);
                h.Active = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateTrangThaiHoaDon(string mhd)
        {
            try
            {
                hoadon h = db.hoadons.Single(m => m.mahd == mhd);
                h.hoanthanh = true;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service Chi tiết hóa đơn
        #region[ct_hoadon]
        public List<ct_hoadon> findAllCTHoaDon()
        {
            return this.db.ct_hoadons.ToList();
        }

        public ct_hoadon findCTHoaDon(string mhd)
        {
            return db.ct_hoadons.Single(m => m.mahd == mhd);
        }

        public ct_hoadon findCTHoaDonID(int id)
        {
            return db.ct_hoadons.Single(m => m.id == id);
        }

        public List<ct_hoadon> findListCTHoaDon(string mhd)
        {
            return db.ct_hoadons.Where(m => m.mahd == mhd).ToList();
        }

        public bool checkCTHoaDon(string mhd)
        {
            try
            {
                List<ct_hoadon> hd = db.ct_hoadons.Where(m => m.mahd == mhd).ToList();
                if (hd.Count < 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertCTHoaDon(string mhd, string msp, int sl, float tien)
        {
            try
            {
                ct_hoadon ct = new ct_hoadon();
                ct.mahd = mhd;
                ct.masp = msp;
                ct.soluong = sl;
                ct.thanhtien = tien;
                db.ct_hoadons.InsertOnSubmit(ct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCTHoaDonSP(string mhd, string masp)
        {
            try
            {
                List<ct_hoadon> ct = db.ct_hoadons.Where(m => m.mahd == mhd && m.masp == masp).ToList();
                foreach (var item in ct)
                {
                    db.ct_hoadons.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCTHoaDon(int id)
        {
            try
            {
                ct_hoadon ct = db.ct_hoadons.Single(m => m.id == id);
                db.ct_hoadons.DeleteOnSubmit(ct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateCTHoaDon(int id, string mhd, string msp, int sl, float tien)
        {
            try
            {
                ct_hoadon ct = db.ct_hoadons.Single(m => m.id == id);
                ct.mahd = mhd;
                ct.masp = msp;
                ct.soluong = sl;
                ct.thanhtien = tien;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service phiếu nhập
        #region[phieunhap]
        public List<phieunhap> findAllPhieuNhap()
        {
            return this.db.phieunhaps.Where(m => m.Active == true && m.trangthai == false).ToList();
        }

        public string LayMaPNTT()
        {
            string MaPN = "";
            List<phieunhap> l = (from o in db.phieunhaps where o.id == o.id orderby o.id descending select o).Take(1).ToList();
            foreach (var item in l)
            {
                MaPN = item.mapn;
            }
            return MaPN;
        }

        public bool checkPhieuNhap(string mpn)
        {
            try
            {
                db.phieunhaps.Single(m => m.mapn == mpn && m.Active == true && m.trangthai == false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public phieunhap findPhieuNhap(string mpn)
        {
            return db.phieunhaps.Single(m => m.mapn == mpn && m.Active == true && m.trangthai == false);
        }

        public bool insertPhieuNhap(string mpn, DateTime ngay)
        {
            try
            {
                phieunhap p = new phieunhap();
                p.mapn = mpn;
                p.ngaynhap = ngay;
                p.trangthai = false;
                p.Active = true;
                db.phieunhaps.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deletePhieuNhap(string mpn)
        {
            try
            {
                phieunhap p = db.phieunhaps.Single(m => m.mapn == mpn);
                db.phieunhaps.DeleteOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteActivePhieuNhap(string mpn)
        {
            try
            {
                phieunhap p = db.phieunhaps.Single(m => m.mapn == mpn && m.trangthai == false);
                p.Active = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateTrangThaiPhieuNhap(string mpn)
        {
            try
            {
                phieunhap p = db.phieunhaps.Single(m => m.mapn == mpn);
                p.trangthai = true;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updatePhieuNhap(string mpn, DateTime ngay)
        {
            try
            {
                phieunhap p = db.phieunhaps.Single(m => m.mapn == mpn);
                p.ngaynhap = ngay;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service chi tiết phiếu nhập
        #region[ct_phieunhap]
        public List<ct_phieunhap> findAllCTPhieuNhap()
        {
            return this.db.ct_phieunhaps.ToList();
        }

        public List<ct_phieunhap> findListCTPhieuNhap(string mpn)
        {
            return db.ct_phieunhaps.Where(m => m.mapn == mpn).ToList();
        }

        public ct_phieunhap findCTPhieuNhap(string mpn)
        {
            return db.ct_phieunhaps.Single(m => m.mapn == mpn);
        }

        public int LaySLSPCTPhieuNhap(string mpn, string msp)
        {
            try
            {
                var ct = from o in db.ct_phieunhaps
                          where o.mapn == mpn && o.masp == msp
                          orderby o.id descending
                          select o;
                List<ct_phieunhap> t = ct.Take(1).ToList();
                int soluongganday = 0;
                foreach (var item in t)
                {
                    soluongganday = item.soluong.Value;
                }
                return soluongganday;
            }
            catch
            {
                return 0;
            }
        }

        public bool checkCTPhieuNhap(string mpn)
        {
            try
            {
                List<ct_phieunhap> ct = db.ct_phieunhaps.Where(m => m.mapn == mpn).ToList();
                if (ct.Count < 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool checkCTPhieuNhapSP(string mpn, string msp)
        {
            try
            {
                List<ct_phieunhap> ct = db.ct_phieunhaps.Where(m => m.mapn == mpn && m.masp == msp).ToList();
                if (ct.Count < 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertCTPhieuNhap(string mpn, string msp, int sl, float gia, float tien)
        {
            try
            {
                ct_phieunhap ct = new ct_phieunhap();
                ct.mapn = mpn;
                ct.masp = msp;
                ct.soluong = sl;
                ct.gia = gia;
                ct.thanhtien = tien;
                db.ct_phieunhaps.InsertOnSubmit(ct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCTPhieuNhap(string mpn)
        {
            try
            {
                ct_phieunhap ct = db.ct_phieunhaps.Single(m => m.mapn == mpn);
                db.ct_phieunhaps.DeleteOnSubmit(ct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCTPhieuNhapSP(string mpn, string masp)
        {
            try
            {
                List<ct_phieunhap> ct = db.ct_phieunhaps.Where(m => m.mapn == mpn && m.masp == masp).ToList();
                foreach (var item in ct)
                {
                    db.ct_phieunhaps.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateCTPhieuNhap(int id, string mpn, string msp, int sl, float gia, float tien)
        {
            try
            {
                ct_phieunhap ct = db.ct_phieunhaps.Single(m => m.id == id);
                ct.mapn = mpn;
                ct.masp = msp;
                ct.soluong = sl;
                ct.gia = gia;
                ct.thanhtien = tien;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //Service tồn kho
        #region[tonkho]
        public List<tonkho> findAllTonKho()
        {
            return this.db.tonkhos.ToList();
        }

        public tonkho findTonKho(string msp)
        {
            return db.tonkhos.Single(m => m.masp == msp);
        }

        public int findListTonKhoTG(string msp, DateTime thoigian)
        {
            var kho = from o in db.tonkhos
                      where o.masp == msp && o.ngaycapnhat < thoigian
                      orderby o.id descending
                      select o;
            List<tonkho> t = kho.Take(1).ToList();
            int soluong = 0;
            foreach (var item in t)
            {
                soluong = item.soluongton.Value;
            }
            return soluong;
        }

        public int checkSoLuongTonKho(string msp)
        {
            var kho = from o in db.tonkhos
                      where o.masp == msp
                      orderby o.id descending
                      select o;
            List<tonkho> t = kho.Take(1).ToList();
            int soluong = 0;
            foreach (var item in t)
            {
                soluong = item.soluongton.Value;
            }
            return soluong;
        }

        public List<tonkho> findListTonKhoSP(string msp)
        {
            return db.tonkhos.Where(m => m.masp == msp).ToList();
        }

        public bool insertTonKho(string msp, DateTime ngay, int sl)
        {
            try
            {
                tonkho tk = new tonkho();
                tk.masp = msp;
                tk.ngaycapnhat = ngay;
                tk.soluongton = sl;
                db.tonkhos.InsertOnSubmit(tk);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteTonKho(string msp)
        {
            try
            {
                tonkho tk = db.tonkhos.Single(m => m.masp == msp);
                db.tonkhos.DeleteOnSubmit(tk);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateTonKho(int id, string msp, DateTime ngay, int sl)
        {
            try
            {
                tonkho tk = db.tonkhos.Single(m => m.id == id);
                tk.masp = msp;
                tk.ngaycapnhat = ngay;
                tk.soluongton = sl;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
