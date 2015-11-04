using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
        }

        private void btqlsanpham_Click(object sender, EventArgs e)
        {
            FrmQLSanPham frmMain = new FrmQLSanPham();
            frmMain.Show();
            this.Close();
        }

        private void btqlloaisp_Click(object sender, EventArgs e)
        {
            FrmQLLoaiSanPham frmMain = new FrmQLLoaiSanPham();
            frmMain.Show();
            this.Close();
        }

        private void btqlnsx_Click(object sender, EventArgs e)
        {
            FrmQLNhaSanXuat frmMain = new FrmQLNhaSanXuat();
            frmMain.Show();
            this.Close();
        }

        private void btqltonkho_Click(object sender, EventArgs e)
        {
            FrmQLTonKho frmMain = new FrmQLTonKho();
            frmMain.Show();
            this.Close();
        }

        private void btqlnhaphang_Click(object sender, EventArgs e)
        {
            FrmQLNhapHang frmMain = new FrmQLNhapHang();
            frmMain.Show();
            this.Close();
        }

        private void btqlbanhang_Click(object sender, EventArgs e)
        {
            FrmQLBanHang frmMain = new FrmQLBanHang();
            frmMain.Show();
            this.Close();
        }

        private void btqlnguoidung_Click(object sender, EventArgs e)
        {
            FrmQLNguoiDung frmMain = new FrmQLNguoiDung();
            frmMain.Show();
            this.Close();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btwebsite_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:24141/");
        }
    }
}