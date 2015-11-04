namespace DesktopApplication
{
    partial class FrmSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Button();
            this.btqlnguoidung = new System.Windows.Forms.Button();
            this.btqlbanhang = new System.Windows.Forms.Button();
            this.btqlnhaphang = new System.Windows.Forms.Button();
            this.btqltonkho = new System.Windows.Forms.Button();
            this.btqlnsx = new System.Windows.Forms.Button();
            this.btqlloaisp = new System.Windows.Forms.Button();
            this.btqlsanpham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btwebsite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btwebsite);
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.btqlnguoidung);
            this.panel1.Controls.Add(this.btqlbanhang);
            this.panel1.Controls.Add(this.btqlnhaphang);
            this.panel1.Controls.Add(this.btqltonkho);
            this.panel1.Controls.Add(this.btqlnsx);
            this.panel1.Controls.Add(this.btqlloaisp);
            this.panel1.Controls.Add(this.btqlsanpham);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 394);
            this.panel1.TabIndex = 0;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(795, 359);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 9;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btqlnguoidung
            // 
            this.btqlnguoidung.Location = new System.Drawing.Point(613, 105);
            this.btqlnguoidung.Name = "btqlnguoidung";
            this.btqlnguoidung.Size = new System.Drawing.Size(134, 90);
            this.btqlnguoidung.TabIndex = 8;
            this.btqlnguoidung.Text = "QL Người Dùng";
            this.btqlnguoidung.UseVisualStyleBackColor = true;
            this.btqlnguoidung.Click += new System.EventHandler(this.btqlnguoidung_Click);
            // 
            // btqlbanhang
            // 
            this.btqlbanhang.Location = new System.Drawing.Point(431, 247);
            this.btqlbanhang.Name = "btqlbanhang";
            this.btqlbanhang.Size = new System.Drawing.Size(134, 90);
            this.btqlbanhang.TabIndex = 6;
            this.btqlbanhang.Text = "QL Bán Hàng";
            this.btqlbanhang.UseVisualStyleBackColor = true;
            this.btqlbanhang.Click += new System.EventHandler(this.btqlbanhang_Click);
            // 
            // btqlnhaphang
            // 
            this.btqlnhaphang.Location = new System.Drawing.Point(238, 247);
            this.btqlnhaphang.Name = "btqlnhaphang";
            this.btqlnhaphang.Size = new System.Drawing.Size(134, 90);
            this.btqlnhaphang.TabIndex = 5;
            this.btqlnhaphang.Text = "QL Nhập Hàng";
            this.btqlnhaphang.UseVisualStyleBackColor = true;
            this.btqlnhaphang.Click += new System.EventHandler(this.btqlnhaphang_Click);
            // 
            // btqltonkho
            // 
            this.btqltonkho.Location = new System.Drawing.Point(54, 247);
            this.btqltonkho.Name = "btqltonkho";
            this.btqltonkho.Size = new System.Drawing.Size(134, 90);
            this.btqltonkho.TabIndex = 4;
            this.btqltonkho.Text = "QL Tồn Kho";
            this.btqltonkho.UseVisualStyleBackColor = true;
            this.btqltonkho.Click += new System.EventHandler(this.btqltonkho_Click);
            // 
            // btqlnsx
            // 
            this.btqlnsx.Location = new System.Drawing.Point(431, 105);
            this.btqlnsx.Name = "btqlnsx";
            this.btqlnsx.Size = new System.Drawing.Size(134, 90);
            this.btqlnsx.TabIndex = 3;
            this.btqlnsx.Text = "QL Nhà Sản Xuất";
            this.btqlnsx.UseVisualStyleBackColor = true;
            this.btqlnsx.Click += new System.EventHandler(this.btqlnsx_Click);
            // 
            // btqlloaisp
            // 
            this.btqlloaisp.Location = new System.Drawing.Point(238, 105);
            this.btqlloaisp.Name = "btqlloaisp";
            this.btqlloaisp.Size = new System.Drawing.Size(134, 90);
            this.btqlloaisp.TabIndex = 2;
            this.btqlloaisp.Text = "QL Loại Sản Phẩm";
            this.btqlloaisp.UseVisualStyleBackColor = true;
            this.btqlloaisp.Click += new System.EventHandler(this.btqlloaisp_Click);
            // 
            // btqlsanpham
            // 
            this.btqlsanpham.Location = new System.Drawing.Point(54, 105);
            this.btqlsanpham.Name = "btqlsanpham";
            this.btqlsanpham.Size = new System.Drawing.Size(134, 90);
            this.btqlsanpham.TabIndex = 1;
            this.btqlsanpham.Text = "QL Sản Phẩm";
            this.btqlsanpham.UseVisualStyleBackColor = true;
            this.btqlsanpham.Click += new System.EventHandler(this.btqlsanpham_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ BÁN GIÀY";
            // 
            // btwebsite
            // 
            this.btwebsite.Location = new System.Drawing.Point(613, 247);
            this.btwebsite.Name = "btwebsite";
            this.btwebsite.Size = new System.Drawing.Size(134, 90);
            this.btwebsite.TabIndex = 10;
            this.btwebsite.Text = "Website Người Dùng";
            this.btwebsite.UseVisualStyleBackColor = true;
            this.btwebsite.Click += new System.EventHandler(this.btwebsite_Click);
            // 
            // FrmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(882, 394);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmSystem";
            this.Text = "Trang chủ hệ thống";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btqlbanhang;
        private System.Windows.Forms.Button btqlnhaphang;
        private System.Windows.Forms.Button btqltonkho;
        private System.Windows.Forms.Button btqlnsx;
        private System.Windows.Forms.Button btqlloaisp;
        private System.Windows.Forms.Button btqlsanpham;
        private System.Windows.Forms.Button btqlnguoidung;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btwebsite;
    }
}