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
    public partial class FrmQLNhaSanXuat : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLNhaSanXuat()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            dgvnhasx.AutoGenerateColumns = false;
            this.dgvnhasx.DataSource = db.findAllNhaSX();
        }

        private string LayMaNSXTT()
        {
            string MaNSX = db.LayMaNSXTT();
            if (MaNSX == "")
            {
                return "SX000001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "SX"; //Lấy ký tự mặc định trong mã đã có
                k = Convert.ToInt32(MaNSX.ToString().Substring(2, 6));
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
            txtmansx.Text = "";
            txttennsx.Text = "";
            txtdiachi.Text = "";
            txthinh.Text = "";
        }

        private void dgvnhasx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmansx.Text = dgvnhasx.CurrentRow.Cells[0].Value.ToString();
            txttennsx.Text = dgvnhasx.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dgvnhasx.CurrentRow.Cells[2].Value.ToString();
            txthinh.Text = dgvnhasx.CurrentRow.Cells[3].Value.ToString();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvnhasx.AutoGenerateColumns = false;
            this.dgvnhasx.DataSource = db.findTenNhaSX(tukhoa);
        }

        private void btthemnhasx_Click(object sender, EventArgs e)
        {
            try
            {
                string mansx = LayMaNSXTT();
                string tennsx = txttennsx.Text;
                string diachi = txtdiachi.Text;
                string hinh = txthinh.Text;

                if (db.insertNhaSX(mansx, tennsx, diachi, hinh))
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

        private void btsuanhasx_Click(object sender, EventArgs e)
        {
            try
            {
                string mansx = txtmansx.Text;
                string tennsx = txttennsx.Text;
                string diachi = txtdiachi.Text;
                string hinh = txthinh.Text;

                if (db.updateNhaSX(mansx, tennsx, diachi, hinh))
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

        private string NoiLuuHinhAnh = @"..\..\..\..\ShopBanGiayPro\WebMVCApplication\Images\NhaSanXuat\";

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
                            txthinh.Text = "\\Images\\NhaSanXuat\\" + tenanh[tenanh.Length - 1];
                        }
                        catch
                        {
                            string ten = tenanh[tenanh.Length - 1];
                            string tenmoi = DateTime.Now.ToString("ddMMyyyyHHmmssmmmm") + ten.Substring(ten.LastIndexOf("."));
                            fi.CopyTo(NoiLuuHinhAnh + tenmoi);
                            txthinh.Text = "\\Images\\NhaSanXuat\\" + tenmoi;
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
                string mansx = txtmansx.Text;

                if (db.deleteActiveNhaSX(mansx))
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
