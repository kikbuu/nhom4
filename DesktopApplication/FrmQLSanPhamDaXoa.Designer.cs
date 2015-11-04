namespace DesktopApplication
{
    partial class FrmQLSanPhamDaXoa
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
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mansx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.btkhoiphuc = new System.Windows.Forms.Button();
            this.btlammoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.maloai,
            this.mansx,
            this.tensp,
            this.soluong,
            this.gia,
            this.ngaynhap,
            this.hinh});
            this.dgvsanpham.Location = new System.Drawing.Point(12, 162);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.Size = new System.Drawing.Size(830, 270);
            this.dgvsanpham.TabIndex = 1;
            this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellContentClick);
            this.dgvsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellContentClick);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Tên loại";
            this.maloai.Name = "maloai";
            // 
            // mansx
            // 
            this.mansx.DataPropertyName = "mansx";
            this.mansx.HeaderText = "Nhà sản xuất";
            this.mansx.Name = "mansx";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên SP";
            this.tensp.Name = "tensp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // hinh
            // 
            this.hinh.DataPropertyName = "hinh";
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QL Tìm Kiếm";
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(64, 37);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(159, 20);
            this.txttukhoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP:";
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(229, 34);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 23);
            this.bttim.TabIndex = 1;
            this.bttim.Text = "Tìm kiếm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã SP:";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(402, 108);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.ReadOnly = true;
            this.txtmasp.Size = new System.Drawing.Size(194, 20);
            this.txtmasp.TabIndex = 18;
            // 
            // btkhoiphuc
            // 
            this.btkhoiphuc.Location = new System.Drawing.Point(614, 108);
            this.btkhoiphuc.Name = "btkhoiphuc";
            this.btkhoiphuc.Size = new System.Drawing.Size(75, 23);
            this.btkhoiphuc.TabIndex = 4;
            this.btkhoiphuc.Text = "Khôi phục";
            this.btkhoiphuc.UseVisualStyleBackColor = true;
            this.btkhoiphuc.Click += new System.EventHandler(this.btkhoiphuc_Click);
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(708, 108);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(75, 23);
            this.btlammoi.TabIndex = 19;
            this.btlammoi.Text = "Làm mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "TRÌNH KHÔI PHỤC SẢN PHẨM";
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(767, 30);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(75, 23);
            this.btdong.TabIndex = 21;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // FrmQLSanPhamDaXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(854, 444);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btlammoi);
            this.Controls.Add(this.btkhoiphuc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvsanpham);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmQLSanPhamDaXoa";
            this.Text = "Quản lý sản phẩm đã xóa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mansx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Button btkhoiphuc;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdong;
    }
}