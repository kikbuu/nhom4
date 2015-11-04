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
    public partial class FrmQLSanPhamDaXoa : Form
    {
        private ServiceShopBanGiayProClient db = new ServiceShopBanGiayProClient();

        public FrmQLSanPhamDaXoa()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            dgvsanpham.AutoGenerateColumns = false;
            this.dgvsanpham.DataSource = db.findAllSanPhamDaXoa();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string tukhoa = txttukhoa.Text;
            dgvsanpham.AutoGenerateColumns = false;
            this.dgvsanpham.DataSource = db.findTenSanPhamDaXoa(tukhoa);
        }

        private void btkhoiphuc_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;

                if (db.KhoiPhucSanPham(masp))
                {
                    MessageBox.Show("Khôi phục thành công!!!");
                    HienThi();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Khôi phục thất bại!!!");
                }
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu nhập!!!");
            }
        }

        private void LamMoi()
        {
            txtmasp.Text = "";
            txttukhoa.Text = "";
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvsanpham.CurrentRow.Cells[0].Value.ToString();
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            FrmSystem frmMain = new FrmSystem();
            frmMain.Show();
            this.Close();
        }
    }
}
