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
    public partial class FrmQLLoaiSanPham : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLLoaiSanPham()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            dgvloai.AutoGenerateColumns = false;
            this.dgvloai.DataSource = db.findAllLoai();
        }

        private string LayMaLoaiTT()
        {
            string MaLoai = db.LayMaLoaiTT();
            if (MaLoai == "")
            {
                return "ML000001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "ML"; //Lấy ký tự mặc định trong mã đã có
                k = Convert.ToInt32(MaLoai.ToString().Substring(2, 6));
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
            txtmaloai.Text = "";
            txttenloai.Text = "";
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvloai.AutoGenerateColumns = false;
            this.dgvloai.DataSource = db.findTenLoai(tukhoa);
        }

        private void btthemloaisanpham_Click(object sender, EventArgs e)
        {
            try
            {
                string maloai = LayMaLoaiTT();
                string tenloai = txttenloai.Text;

                if (db.insertLoai(maloai, tenloai))
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

        private void btsualoaisp_Click(object sender, EventArgs e)
        {
            try
            {
                string maloai = txtmaloai.Text;
                string tenloai = txttenloai.Text;

                if (db.updateLoai(maloai, tenloai))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaloai.Text = dgvloai.CurrentRow.Cells[0].Value.ToString();
            txttenloai.Text = dgvloai.CurrentRow.Cells[1].Value.ToString();
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

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maloai = txtmaloai.Text;

                if (db.deleteActiveLoai(maloai))
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
                MessageBox.Show("Dữ liệu nhập không đúng!!!");
            }
        }
    }
}
