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
    public partial class FrmLogin : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnDangnhap;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string ten, mk, quyen;
            bool Active;
            ten = txtDangnhap.Text;
            mk = txtMatkhau.Text;
            quyen = "admin";
            Active = true;
            if (db.checkLoginAdmin(ten, mk, quyen, Active) == true)
            {
                FrmSystem frmMain = new FrmSystem();
                frmMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!!", "ĐĂNG NHẬP", MessageBoxButtons.OK);
                txtMatkhau.Text = "";
                txtDangnhap.Text = "";
                txtMatkhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông tin", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
