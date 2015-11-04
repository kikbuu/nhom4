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
using System.IO;

namespace DesktopApplication
{
    public partial class FrmQLSanPham : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLSanPham()
        {
            InitializeComponent();
            HienThi();
            LayTenLoai();
            LayTenNSX();
        }

        public void HienThi()
        {
            dgvsanpham.AutoGenerateColumns = false;
            this.dgvsanpham.DataSource = db.findAllSanPham();
        }

        private string LayMaSPTT()
        {
            string MaSP = db.LayMaSPTT();
            if (MaSP == "")
            {
                return "SP000001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "SP"; //Lấy ký tự mặc định trong mã đã có
                k = Convert.ToInt32(MaSP.ToString().Substring(2, 6));
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

        public void HienThiCT(string masp)
        {
            dgvctsanpham.AutoGenerateColumns = false;
            this.dgvctsanpham.DataSource = db.findListCTSanPham(masp);
        }

        private void btthemsanpham_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = LayMaSPTT();
                string maloai = cbloaisp.SelectedValue.ToString();
                string mansx = cbmansx.SelectedValue.ToString();
                string tensp = txttensp.Text;
                int soluong = 0;
                float gia = float.Parse(txtgia.Text);
                DateTime ngaynhap = DateTime.Parse(dtngaynhap.Text);
                string hinh = txthinh.Text;

                if (db.insertSanPham(masp, maloai, mansx, tensp, soluong, gia, ngaynhap, hinh))
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

        private void btsuasp_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;
                string maloai = cbloaisp.SelectedValue.ToString();
                string mansx = cbmansx.SelectedValue.ToString();
                string tensp = txttensp.Text;
                int soluong = int.Parse(txtsoluong.Text);
                float gia = float.Parse(txtgia.Text);
                DateTime ngaynhap = DateTime.Parse(dtngaynhap.Text);
                string hinh = txthinh.Text;

                if (db.updateSanPham(masp, maloai, mansx, tensp, soluong, gia, ngaynhap, hinh))
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

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvsanpham.AutoGenerateColumns = false;
            this.dgvsanpham.DataSource = db.findTenSanPham(tukhoa);
        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvsanpham.CurrentRow.Cells[0].Value.ToString();
            txttensp.Text = dgvsanpham.CurrentRow.Cells[3].Value.ToString();
            txtsoluong.Text = dgvsanpham.CurrentRow.Cells[4].Value.ToString();
            txtgia.Text = dgvsanpham.CurrentRow.Cells[5].Value.ToString();
            dtngaynhap.Text = dgvsanpham.CurrentRow.Cells[6].Value.ToString();
            txthinh.Text = dgvsanpham.CurrentRow.Cells[7].Value.ToString();

            txtmaspct.Text = dgvsanpham.CurrentRow.Cells[0].Value.ToString();

            string maloai = dgvsanpham.CurrentRow.Cells[1].Value.ToString();
            LayTenLoaiThamSo(maloai);
            string mansx = dgvsanpham.CurrentRow.Cells[2].Value.ToString();
            LayTenNSXThamSo(mansx);
        }

        private void LamMoi()
        {
            txtmasp.Text = "";
            cbloaisp.Text = "";
            cbmansx.Text = "";
            txttensp.Text = "";
            txtsoluong.Text = "";
            txtgia.Text = "";
            dtngaynhap.Value = DateTime.Today;
            txthinh.Text = "";
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private string NoiLuuHinhAnh = @"..\..\..\..\ShopBanGiayPro\WebMVCApplication\Images\SanPham\";

        private void btchonhinh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op1 = new OpenFileDialog();
                op1.Filter = "Images |*.jpg;*.jpeg;*.png;*.gif";
                op1.Multiselect = false;
                if (op1.ShowDialog() == DialogResult.OK)
                {
                    string[] tmp = op1.FileNames;
                    foreach (string i in tmp)
                    {
                        FileInfo fi = new FileInfo(i);
                        string[] tenanh = i.Split('\\');
                        string des = NoiLuuHinhAnh + tenanh[tenanh.Length - 1];
                        try
                        {
                            fi.CopyTo(des);
                            txthinh.Text = "\\Images\\SanPham\\" + tenanh[tenanh.Length - 1];
                        }
                        catch
                        {
                            string ten = tenanh[tenanh.Length - 1];
                            string tenmoi = DateTime.Now.ToString("ddMMyyyyHHmmssmmmm") + ten.Substring(ten.LastIndexOf("."));
                            fi.CopyTo(NoiLuuHinhAnh + tenmoi);
                            txthinh.Text = "\\Images\\SanPham\\" + tenmoi;
                        }
                    }
                    MessageBox.Show("Upload ảnh thành công!!!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi trong quá trình tải hình!!!");
            }
        }

        private void btloaddulieu_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btchitiet_Click(object sender, EventArgs e)
        {
            string masp = txtmaspct.Text;
            HienThiCT(masp);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;
                string xuatxu = txtxuatxu.Text;
                string kieudang = txtkieudang.Text;
                string mausac = txtmausac.Text;
                string chatlieu = txtchatlieu.Text;
                string mota = txtmota.Text;
                if (db.checkCTSanPham(masp) == false)
                {
                    if (db.insertCTSanPham(masp, xuatxu, kieudang, mausac, chatlieu, mota))
                    {
                        MessageBox.Show("Thêm thành công!!!");
                        HienThiCT(masp);
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm này đã có chi tiết!!!");
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
                string masp = txtmasp.Text;
                string xuatxu = txtxuatxu.Text;
                string kieudang = txtkieudang.Text;
                string mausac = txtmausac.Text;
                string chatlieu = txtchatlieu.Text;
                string mota = txtmota.Text;

                if (db.updateCTSanPham(masp, xuatxu, kieudang, mausac, chatlieu, mota))
                {
                    MessageBox.Show("Sửa thành công!!!");
                    HienThiCT(masp);
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

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;

                if (db.deleteCTSanPham(masp))
                {
                    MessageBox.Show("Xóa thành công!!!");
                    HienThiCT(masp);
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

        private void btlammoict_Click(object sender, EventArgs e)
        {
            LamMoiCT();
        }

        private void dgvctsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvctsanpham.CurrentRow.Cells[0].Value.ToString();
            txtmaspct.Text = dgvctsanpham.CurrentRow.Cells[1].Value.ToString();
            txtxuatxu.Text = dgvctsanpham.CurrentRow.Cells[2].Value.ToString();
            txtmausac.Text = dgvctsanpham.CurrentRow.Cells[3].Value.ToString();
            txtkieudang.Text = dgvctsanpham.CurrentRow.Cells[4].Value.ToString();
            txtchatlieu.Text = dgvctsanpham.CurrentRow.Cells[5].Value.ToString();
            txtmota.Text = dgvctsanpham.CurrentRow.Cells[6].Value.ToString();
        }

        public void LayTenLoai()
        {
            List<loai> l = db.findAllLoai().ToList();
            cbloaisp.DataSource = l;
            cbloaisp.DisplayMember = "ten";
            cbloaisp.ValueMember = "maloai";
        }

        public void LayTenLoaiThamSo(string maloai)
        {
            List<loai> l = db.findAllLoai().ToList();

            cbloaisp.DataSource = l;
            cbloaisp.DisplayMember = "ten";
            cbloaisp.ValueMember = "maloai";
            string ten = l.Single(m => m.maloai == maloai).ten.ToString();
            cbloaisp.Text = ten;
        }

        public void LayTenNSX()
        {
            List<nhasx> nsx = db.findAllNhaSX().ToList();
            cbmansx.DataSource = nsx;
            cbmansx.DisplayMember = "ten";
            cbmansx.ValueMember = "mansx";
        }

        public void LayTenNSXThamSo(string mansx)
        {
            List<nhasx> nsx = db.findAllNhaSX().ToList();

            cbmansx.DataSource = nsx;
            cbmansx.DisplayMember = "ten";
            cbmansx.ValueMember = "mansx";
            string ten = nsx.Single(m => m.mansx == mansx).ten.ToString();
            cbmansx.Text = ten;
        }

        private void LamMoiCT()
        {
            txtid.Text = "";
            txtxuatxu.Text = "";
            txtmota.Text = "";
            txtchatlieu.Text = "";
            txtkieudang.Text = "";
            txtmausac.Text = "";
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            FrmSystem frmMain = new FrmSystem();
            frmMain.Show();
            this.Close();
        }

        private void btxoasanpham_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;

                if (db.deleteActiveSanPham(masp))
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

        private void btkhoiphucsp_Click(object sender, EventArgs e)
        {
            FrmQLSanPhamDaXoa frmMain = new FrmQLSanPhamDaXoa();
            frmMain.Show();
            this.Close();
        }
    }
}
