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
    public partial class FrmQLNguoiDung : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLNguoiDung()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            dgvnguoidung.AutoGenerateColumns = false;
            this.dgvnguoidung.DataSource = db.finAllUser();
        }

        private void LamMoi()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txthoten.Text = "";
            dtngaysinh.Value = DateTime.Today;
            txtdiachi.Text = "";
            txtemail.Text = "";
            cbquyenhang.Text = "";
            txthinh.Text = "";
            txtsdt.Text = "";
            cbgioitinh.Text = "";
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvnguoidung.AutoGenerateColumns = false;
            this.dgvnguoidung.DataSource = db.findTenUser(tukhoa);
        }

        private void btthemnguoidung_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtusername.Text;
                string pass = txtpassword.Text;
                string hoten = txthoten.Text;
                bool gioitinhnam;
                if (cbgioitinh.Text == "Nam")
                    gioitinhnam = true;
                else
                    gioitinhnam = false;
                DateTime ngaysinh = DateTime.Parse(dtngaysinh.Text);
                string diachi = txtdiachi.Text;
                string sdt = txtsdt.Text;
                string hinh = txthinh.Text;
                string email = txtemail.Text;
                string quyenhang = cbquyenhang.Text;

                if (db.insertUser(user, pass, hoten, gioitinhnam, ngaysinh, diachi, sdt, hinh, email, quyenhang) == true)
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

        private void btsuanguoidung_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtusername.Text;
                string pass = txtpassword.Text;
                string hoten = txthoten.Text;
                bool gioitinhnam;
                if (cbgioitinh.Text == "Nam")
                    gioitinhnam = true;
                else
                    gioitinhnam = false;
                DateTime ngaysinh = DateTime.Parse(dtngaysinh.Text);
                string diachi = txtdiachi.Text;
                string sdt = txtsdt.Text;
                string hinh = txthinh.Text;
                string email = txtemail.Text;
                string quyenhang = cbquyenhang.Text;

                if (db.updateUser(user, pass, hoten, gioitinhnam, ngaysinh, diachi, sdt, hinh, email, quyenhang) == true)
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

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = dgvnguoidung.CurrentRow.Cells[0].Value.ToString();
            txtpassword.Text = dgvnguoidung.CurrentRow.Cells[1].Value.ToString();
            txthoten.Text = dgvnguoidung.CurrentRow.Cells[2].Value.ToString();
            if (dgvnguoidung.CurrentRow.Cells[3].Value.ToString() == "True")
                cbgioitinh.Text = "Nam";
            else
                cbgioitinh.Text = "Nữ";
            dtngaysinh.Text = dgvnguoidung.CurrentRow.Cells[4].Value.ToString();
            txtdiachi.Text = dgvnguoidung.CurrentRow.Cells[5].Value.ToString();
            txtsdt.Text = dgvnguoidung.CurrentRow.Cells[6].Value.ToString();
            txthinh.Text = dgvnguoidung.CurrentRow.Cells[7].Value.ToString();
            txtemail.Text = dgvnguoidung.CurrentRow.Cells[8].Value.ToString();
            cbquyenhang.Text = dgvnguoidung.CurrentRow.Cells[9].Value.ToString();
        }

        private string NoiLuuHinhAnh = @"..\..\..\..\ShopBanGiayPro\WebMVCApplication\Images\NguoiDung\";

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
                            txthinh.Text = "\\Images\\NguoiDung\\" + tenanh[tenanh.Length - 1];
                        }
                        catch
                        {
                            string ten = tenanh[tenanh.Length - 1];
                            string tenmoi = DateTime.Now.ToString("ddMMyyyyHHmmssmmmm") + ten.Substring(ten.LastIndexOf("."));
                            fi.CopyTo(NoiLuuHinhAnh + tenmoi);
                            txthinh.Text = "\\Images\\NguoiDung\\" + tenmoi;
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
                string user = txtusername.Text;

                if (db.deleteActiveUser(user))
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
    }
}
