using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceShopBanGiayPro" in both code and config file together.
    [ServiceContract]
    public interface IServiceShopBanGiayPro
    {
        #region[user]
        [OperationContract]
        List<user> finAllUser();

        [OperationContract]
        List<user> findTenUser(string ten);

        [OperationContract]
        user findUser(string user);

        [OperationContract]
        bool checkUser(string user, string pass);

        [OperationContract]
        bool checkLoginUserCart(string user, string pass, string quyenhang);

        [OperationContract]
        bool checkLoginAdmin(string user, string pass, string quyen, bool Active);

        [OperationContract]
        user findLoginAdmin(string user, string pass, string quyen);

        [OperationContract]
        bool checkLoginUser(string user, string pass);

        [OperationContract]
        bool deleteActiveUser(string user);

        [OperationContract]
        user findLoginUserCart(string user, string pass, string quyenhang);

        [OperationContract]
        user findLoginUser(string user, string pass);

        [OperationContract]
        bool insertUser(string user, string pass, string hoten, bool gioitinh, DateTime ngay, string diachi, string sdt, string hinh, string email, string quyen);

        [OperationContract]
        bool deleteUser(string user);

        [OperationContract]
        bool updateUser(string user, string pass, string hoten, bool gioitinh, DateTime ngay, string diachi, string sdt, string hinh, string email, string quyen);
        #endregion
        #region[sanpham]
        [OperationContract]
        List<sanpham> findAllSanPham();

        [OperationContract]
        List<sanpham> findTenSanPhamDaXoa(string ten);

        [OperationContract]
        bool KhoiPhucSanPham(string msp);

        [OperationContract]
        List<sanpham> findAllSanPhamDaXoa();

        [OperationContract]
        List<sanpham> SearchSanPhamNangCao(string mansx, float giatu, float giaden);

        [OperationContract]
        string LayMaSPTT();

        [OperationContract]
        float LayGiaSP(string masp);

        [OperationContract]
        int LaySoLuongSP(string masp);

        [OperationContract]
        List<sanpham> findTenSanPham(string ten);

        [OperationContract]
        List<sanpham> findAllSanPhamMoiNhat();

        [OperationContract]
        sanpham findSanPham(string msp);

        [OperationContract]
        List<sanpham> findMaLoaiSanPham(string ml);

        [OperationContract]
        bool insertSanPham(string msp, string ml, string mnsx, string ten, int sl, float gia, DateTime ngay, string hinh);

        [OperationContract]
        bool deleteSanPham(string msp);

        [OperationContract]
        bool deleteActiveSanPham(string msp);

        [OperationContract]
        bool updateSanPham(string msp, string ml, string mnsx, string ten, int sl, float gia, DateTime ngay, string hinh);

        [OperationContract]
        bool updateSoLuongSanPham(string msp, int soluong);
        #endregion
        #region[ct_sanpham]
        [OperationContract]
        List<ct_sanpham> findAllCTSanPham();

        [OperationContract]
        List<ct_sanpham> findListCTSanPham(string msp);

        [OperationContract]
        ct_sanpham findCTSanPham(string msp);

        [OperationContract]
        bool checkCTSanPham(string msp);

        [OperationContract]
        bool insertCTSanPham(string msp, string xs, string mausac, string kieudang, string chatlieu, string mota);

        [OperationContract]
        bool deleteCTSanPham(string msp);

        [OperationContract]
        bool updateCTSanPham(string msp, string xs, string mausac, string kieudang, string chatlieu, string mota);
        #endregion
        #region[loai]
        [OperationContract]
        List<loai> findAllLoai();

        [OperationContract]
        string LayMaLoaiTT();

        [OperationContract]
        loai findLoai(string ml);

        [OperationContract]
        List<loai> findTenLoai(string ten);

        [OperationContract]
        bool insertLoai(string mal, string tenl);

        [OperationContract]
        bool deleteLoai(string mal);

        [OperationContract]
        bool deleteActiveLoai(string mal);

        [OperationContract]
        bool updateLoai(string mal, string tenl);
        #endregion
        #region[nhasx]
        [OperationContract]
        List<nhasx> findAllNhaSX();

        [OperationContract]
        string LayMaNSXTT();

        [OperationContract]
        nhasx findNhaSX(string mnsx);

        [OperationContract]
        List<nhasx> findTenNhaSX(string ten);

        [OperationContract]
        bool insertNhaSX(string mnsx, string ten, string diachi, string hinh);

        [OperationContract]
        bool deleteNhaSX(string mnsx);

        [OperationContract]
        bool deleteActiveNhaSX(string mnsx);

        [OperationContract]
        bool updateNhaSX(string mnsx, string ten, string diachi, string hinh);
        #endregion
        #region[hoadon]
        [OperationContract]
        List<hoadon> findAllHoaDon();

        [OperationContract]
        bool checkHoDonHoanThanhChua(string mhd);

        [OperationContract]
        List<hoadon> findAllHoaDonChuaHT();

        [OperationContract]
        string LayMaHDTT();

        [OperationContract]
        List<hoadon> findAllHoaDonDaMua(string user);

        [OperationContract]
        List<hoadon> findListHoaDonChuaXong();

        [OperationContract]
        List<hoadon> findMaHoaDon(string ten);

        [OperationContract]
        List<hoadon> findListHoaDon(string mhd);

        [OperationContract]
        hoadon findHoaDon(string mhd);

        [OperationContract]
        bool deleteActiveHoaDon(string mhd);

        [OperationContract]
        bool insertHoaDon(string mhd, string user, DateTime ngay);

        [OperationContract]
        bool deleteHoaDon(string mhd);

        [OperationContract]
        bool updateTrangThaiHoaDon(string mhd);

        [OperationContract]
        bool updateHoaDon(string mhd, DateTime ngay);
        #endregion
        #region[ct_hoadon]
        [OperationContract]
        List<ct_hoadon> findAllCTHoaDon();

        [OperationContract]
        List<ct_hoadon> findListCTHoaDon(string mhd);

        [OperationContract]
        ct_hoadon findCTHoaDonID(int id);

        [OperationContract]
        ct_hoadon findCTHoaDon(string mhd);

        [OperationContract]
        bool checkCTHoaDon(string mhd);

        [OperationContract]
        bool insertCTHoaDon(string mhd, string msp, int sl, float tien);

        [OperationContract]
        bool deleteCTHoaDonSP(string mhd, string masp);

        [OperationContract]
        bool deleteCTHoaDon(int id);

        [OperationContract]
        bool updateCTHoaDon(int id, string mhd, string msp, int sl, float tien);
        #endregion
        #region[phieunhap]
        [OperationContract]
        List<phieunhap> findAllPhieuNhap();

        [OperationContract]
        string LayMaPNTT();

        [OperationContract]
        phieunhap findPhieuNhap(string mpn);

        [OperationContract]
        bool checkPhieuNhap(string mpn);

        [OperationContract]
        bool insertPhieuNhap(string mpn, DateTime ngay);

        [OperationContract]
        bool deletePhieuNhap(string mpn);

        [OperationContract]
        bool deleteActivePhieuNhap(string mpn);

        [OperationContract]
        bool updateTrangThaiPhieuNhap(string mpn);

        [OperationContract]
        bool updatePhieuNhap(string mpn, DateTime ngay);
        #endregion
        #region[ct_phieunhap]
        [OperationContract]
        List<ct_phieunhap> findAllCTPhieuNhap();

        [OperationContract]
        List<ct_phieunhap> findListCTPhieuNhap(string mpn);

        [OperationContract]
        ct_phieunhap findCTPhieuNhap(string mpn);

        [OperationContract]
        int LaySLSPCTPhieuNhap(string mpn, string msp);

        [OperationContract]
        bool checkCTPhieuNhap(string mpn);

        [OperationContract]
        bool checkCTPhieuNhapSP(string mpn, string msp);

        [OperationContract]
        bool insertCTPhieuNhap(string mpn, string msp, int sl, float gia, float tien);

        [OperationContract]
        bool deleteCTPhieuNhap(string mpn);

        [OperationContract]
        bool deleteCTPhieuNhapSP(string mpn, string masp);

        [OperationContract]
        bool updateCTPhieuNhap(int id, string mpn, string msp, int sl, float gia, float tien);
        #endregion
        #region[tonkho]
        [OperationContract]
        List<tonkho> findAllTonKho();

        [OperationContract]
        List<tonkho> findListTonKhoSP(string msp);

        [OperationContract]
        tonkho findTonKho(string msp);

        [OperationContract]
        int findListTonKhoTG(string msp, DateTime thoigian);

        [OperationContract]
        bool insertTonKho(string msp, DateTime ngay, int sl);

        [OperationContract]
        int checkSoLuongTonKho(string msp);

        [OperationContract]
        bool deleteTonKho(string msp);

        [OperationContract]
        bool updateTonKho(int id, string msp, DateTime ngay, int sl);
        #endregion
    }
}
