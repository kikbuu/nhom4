using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApplication.ServiceReferenceShopBanGiayPro;

namespace DesktopApplication
{
    public partial class FrmQLNhapHang : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLNhapHang()
        {
            InitializeComponent();
            HienThi();
            LayTenSP();
        }

        private string LayMaPNTT()
        {
            string MaPN = db.LayMaPNTT();
            if (MaPN == "")
            {
                return "PN000001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "PN"; //Lấy ký tự mặc định trong mã đã có
                k = Convert.ToInt32(MaPN.ToString().Substring(2, 6));
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

        private void LamMoi()
        {
            txtmapn.Text = "";
            dtngaynhap.Value = DateTime.Today;
        }

        public void HienThi()
        {
            dgvphieunhap.AutoGenerateColumns = false;
            this.dgvphieunhap.DataSource = db.findAllPhieuNhap();
        }

        public void HienThiCT(string mahd)
        {
            dgvctpn.AutoGenerateColumns = false;
            this.dgvctpn.DataSource = db.findListCTPhieuNhap(mahd);
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvphieunhap.AutoGenerateColumns = false;
            this.dgvphieunhap.DataSource = db.findPhieuNhap(tukhoa);
        }

        private void btthempn_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = LayMaPNTT();
                DateTime ngaynhap = DateTime.Parse(dtngaynhap.Text);

                if (db.insertPhieuNhap(mapn, ngaynhap))
                {
                    MessageBox.Show("Thêm thành công!!!");
                    HienThi();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không đúng!!!");
            }
        }

        private void btsuapn_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = txtmapn.Text;
                DateTime ngaynhap = DateTime.Parse(dtngaynhap.Text);

                if (db.updatePhieuNhap(mapn, ngaynhap))
                {
                    MessageBox.Show("Sửa thành công!!!");
                    HienThi();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không đúng!!!");
            }
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvphieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmapn.Text = dgvphieunhap.CurrentRow.Cells[1].Value.ToString();
            dtngaynhap.Text = dgvphieunhap.CurrentRow.Cells[2].Value.ToString();

            txtmapnct.Text = dgvphieunhap.CurrentRow.Cells[1].Value.ToString();
        }

        private void btctpn_Click(object sender, EventArgs e)
        {
            string ma = txtmapnct.Text;
            if (ma != null)
            {
                if (db.checkPhieuNhap(ma))
                {
                    if(db.checkCTPhieuNhap(ma))
                        HienThiCT(ma);
                    else
                        MessageBox.Show("Mã phiếu nhập này chưa có chi tiết phiếu nhập!!!");
                }
                else
                    MessageBox.Show("Mã phiếu nhập này không có trong hệ thống!!!");
            }
            else
            {
                MessageBox.Show("Chưa nhập mã phiếu nhập!!!");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = txtmapnct.Text;
                string masp = cbmasp.SelectedValue.ToString();
                int soluong = int.Parse(txtsoluong.Text);
                float gia = float.Parse(txtgia.Text);
                float thanhtien = soluong * gia;

                if (db.checkCTPhieuNhapSP(mapn, masp) == false)
                {
                    if (db.insertCTPhieuNhap(mapn, masp, soluong, gia, thanhtien))
                    {
                        MessageBox.Show("Thêm thành công!!!");
                        //cap nhat ton kho
                        DateTime ngayhientai = DateTime.Today;
                        if (db.insertTonKho(masp, ngayhientai, soluong) == false)
                            MessageBox.Show("Xảy ra khi cập nhật tồn kho!!!");
                        HienThiCT(mapn);
                        LamMoiCT();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm này đã được chọn!!!");
                }
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                string mapn = txtmapnct.Text;
                string masp = cbmasp.SelectedValue.ToString();
                int soluong = int.Parse(txtsoluong.Text);
                float gia = float.Parse(txtgia.Text);
                float thanhtien = soluong * gia;

                int soluongcu = db.LaySLSPCTPhieuNhap(mapn, masp);
                if (db.updateCTPhieuNhap(id, mapn, masp, soluongcu, gia, thanhtien))
                {
                    MessageBox.Show("Sửa thành công!!!");
                    HienThiCT(mapn);
                    LamMoiCT();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = txtmapnct.Text;
                string masp = cbmasp.SelectedValue.ToString();

                if (db.deleteCTPhieuNhapSP(mapn, masp))
                {
                    MessageBox.Show("Xóa thành công!!!");
                    HienThiCT(mapn);
                    LamMoiCT();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }

        public void LamMoiCT()
        {
            txtsoluong.Text = "";
            txtthanhtien.Text = "";
            txtgia.Text = "";
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            LamMoiCT();
        }

        private void dgvctpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvctpn.CurrentRow.Cells[0].Value.ToString();
            txtmapnct.Text = dgvctpn.CurrentRow.Cells[1].Value.ToString();
            //txtmasp.Text = dgvctpn.CurrentRow.Cells[2].Value.ToString();
            txtsoluong.Text = dgvctpn.CurrentRow.Cells[3].Value.ToString();
            txtgia.Text = dgvctpn.CurrentRow.Cells[4].Value.ToString();
            txtthanhtien.Text = dgvctpn.CurrentRow.Cells[5].Value.ToString();

            string masp = dgvctpn.CurrentRow.Cells[2].Value.ToString();
            LayTenSPThamSo(masp);
        }

        public void LayTenSP()
        {
            List<sanpham> sp = db.findAllSanPham().ToList();
            cbmasp.DataSource = sp;
            cbmasp.DisplayMember = "tensp";
            cbmasp.ValueMember = "masp";
        }

        public void LayTenSPThamSo(string masp)
        {
            List<sanpham> sp = db.findAllSanPham().ToList();

            cbmasp.DataSource = sp;
            cbmasp.DisplayMember = "tensp";
            cbmasp.ValueMember = "masp";
            string ten = sp.Single(m => m.masp == masp).tensp.ToString();
            cbmasp.Text = ten;
        }

        private void btloaddulieu_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            FrmSystem frmMain = new FrmSystem();
            frmMain.Show();
            this.Close();
        }

        private void btxoapn_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = txtmapn.Text;

                if (db.deleteActivePhieuNhap(mapn))
                {
                    MessageBox.Show("Xóa thành công!!!");
                    HienThi();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsoluong.Text == "")
                    MessageBox.Show("Bạn chưa nhập số lượng!!!");
                else if (txtgia.Text == "")
                    MessageBox.Show("Bạn chưa nhập giá!!!");
                else
                {
                    int soluong = int.Parse(txtsoluong.Text);
                    float gia = float.Parse(txtgia.Text);
                    txtthanhtien.Text = (soluong * gia).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu nhập!!!");
            }
        }

        private void bthoanthanh_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = txtmapn.Text;

                if (db.updateTrangThaiPhieuNhap(mapn))
                {
                    MessageBox.Show("Xác nhận phiếu nhập thành công!!!");
                    HienThi();
                    LamMoi();
                    //Cập nhật tồn kho
                    List<ct_phieunhap> ct = db.findListCTPhieuNhap(mapn).ToList();
                    foreach (var item in ct)
                    {
                        string masp = item.masp;
                        int soluong = item.soluong.Value;
                        DateTime ngay = DateTime.Today;
                        int soluongmoi = soluong + db.checkSoLuongTonKho(item.masp);
                        db.insertTonKho(masp, ngay, soluongmoi);
                        db.updateSoLuongSanPham(masp, soluongmoi);
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận phiếu nhập thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không đúng!!!");
            }
        }
    }
}
