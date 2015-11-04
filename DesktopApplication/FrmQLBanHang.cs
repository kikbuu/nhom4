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
    public partial class FrmQLBanHang : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLBanHang()
        {
            InitializeComponent();
            HienThi();
            LayTenSP();
        }

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

        public void HienThi()
        {
            dgvhoadon.AutoGenerateColumns = false;
            this.dgvhoadon.DataSource = db.findListHoaDonChuaXong();
        }

        private void LamMoi()
        {
            txtmahd.Text = "";
            txtuser.Text = "";
            dtngaymua.Value = DateTime.Today;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvhoadon.AutoGenerateColumns = false;
            this.dgvhoadon.DataSource = db.findListHoaDon(tukhoa);
        }

        private void btthemhd_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = layMaHDTT();
                string user = txtuser.Text;
                DateTime ngaymua = dtngaymua.Value.Date;

                if (db.insertHoaDon(mahd, user, ngaymua))
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
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }

        private void btsuahd_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtmahd.Text;
                string user = txtuser.Text;
                DateTime ngaymua = dtngaymua.Value.Date;

                if (db.updateHoaDon(mahd, ngaymua))
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
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahd.Text = dgvhoadon.CurrentRow.Cells[1].Value.ToString();
            txtuser.Text = dgvhoadon.CurrentRow.Cells[2].Value.ToString();
            dtngaymua.Value = DateTime.Parse(dgvhoadon.CurrentRow.Cells[3].Value.ToString());

            txtmahdct.Text = dgvhoadon.CurrentRow.Cells[1].Value.ToString();
        }

        private void btloaddulieu_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        public void HienThiCT(string mhd)
        {
            dgvcthd.AutoGenerateColumns = false;
            this.dgvcthd.DataSource = db.findListCTHoaDon(mhd);
        }

        private void btcthd_Click(object sender, EventArgs e)
        {
            string mhd = txtmahdct.Text;
            if (db.checkCTHoaDon(mhd) == true)
            {
                HienThiCT(mhd);
            }
            else
            {
                MessageBox.Show("Mã hóa đơn này chư có chi tiết!!!");
            }
        }

        private void ResetThem()
        {
            txtsoluong.Text = "";
            txtid.Text = "";
            txtthanhtien.Text = "";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string mhd = txtmahdct.Text;
                int soluong = int.Parse(txtsoluong.Text);
                string masp = cbmasp.SelectedValue.ToString();

                float thanhtien = (float)db.findSanPham(masp).gia * soluong;
                if (db.insertCTHoaDon(mhd, masp, soluong, thanhtien))
                {
                    MessageBox.Show("Thêm thành công!!!");
                    HienThiCT(mhd);
                    ResetThem();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!!!");
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
                string mhd = txtmahdct.Text;
                string masp = cbmasp.SelectedValue.ToString();
                int soluong = int.Parse(txtsoluong.Text);

                float thanhtien = (float)db.findSanPham(masp).gia * soluong;
                if (db.updateCTHoaDon(id, mhd, masp, soluong, thanhtien))
                {
                    MessageBox.Show("Sửa thành công!!!");
                    HienThiCT(mhd);
                    ResetThem();
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
                int id = int.Parse(txtid.Text);
                string mhd = txtmahdct.Text;

                if (db.deleteCTHoaDon(id))
                {
                    MessageBox.Show("Xóa thành công!!!");
                    HienThiCT(mhd);
                    ResetThem();
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

        public void Reset()
        {
            txtid.Text = "";
            txtmahdct.Text = "";
            txtsoluong.Text = "";
            txtthanhtien.Text = "";
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            ResetThem();
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

        private void dgvcthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvcthd.CurrentRow.Cells[0].Value.ToString();
            txtmahdct.Text = dgvcthd.CurrentRow.Cells[1].Value.ToString();
            txtsoluong.Text = dgvcthd.CurrentRow.Cells[3].Value.ToString();
            txtthanhtien.Text = dgvcthd.CurrentRow.Cells[4].Value.ToString();

            string masp = dgvcthd.CurrentRow.Cells[2].Value.ToString();
            LayTenSPThamSo(masp);
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            FrmSystem frmMain = new FrmSystem();
            frmMain.Show();
            this.Close();
        }

        private void btxoahd_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtmahd.Text;

                if (db.deleteActiveHoaDon(mahd))
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

        private void btxacnhandonhang_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtmahd.Text;

                if (db.updateTrangThaiHoaDon(mahd))
                {
                    MessageBox.Show("Xác nhận đơn hàng thành công!!!");
                    HienThi();
                    LamMoi();
                    //Cập nhật tồn kho
                    List<ct_hoadon> ct = db.findListCTHoaDon(mahd).ToList();
                    foreach (var item in ct)
                    {
                        string masp = item.masp;
                        int soluong = item.soluong.Value;
                        DateTime ngay = DateTime.Today;
                        int soluongmoi = db.checkSoLuongTonKho(item.masp) - soluong;
                        db.insertTonKho(masp, ngay, soluongmoi);
                        db.updateSoLuongSanPham(masp, soluongmoi);
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận đơn hàng thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }
    }
}
