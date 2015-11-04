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
    public partial class FrmQLTonKho : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLTonKho()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            dgvtonkho.AutoGenerateColumns = false;
            this.dgvtonkho.DataSource = db.findAllTonKho();
        }

        private void LamMoi()
        {
            txttukhoa.Text = "";
            HienThi();
        }

        private void Reset()
        {
            txtmasp.Text = "";
            txtsoluongton.Text = "";
            dtthoigiancapnhat.Value = DateTime.Today;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvtonkho.AutoGenerateColumns = false;
            this.dgvtonkho.DataSource = db.findListTonKhoSP(tukhoa);
        }

        private void btloaddulieu_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;
                DateTime thoigian = dtthoigiancapnhat.Value;
                txtsoluongton.Text = db.findListTonKhoTG(masp, thoigian).ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi truy xuất tồn kho!!!");
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvtonkho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvtonkho.CurrentRow.Cells[1].Value.ToString();
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            FrmSystem frmMain = new FrmSystem();
            frmMain.Show();
            this.Close();
        }
    }
}
