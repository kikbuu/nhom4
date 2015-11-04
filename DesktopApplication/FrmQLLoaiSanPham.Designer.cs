namespace DesktopApplication
{
    partial class FrmQLLoaiSanPham
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
            this.btlammoi = new System.Windows.Forms.Button();
            this.btloaddulieu = new System.Windows.Forms.Button();
            this.btsualoaisp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btthemloaisanpham = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvloai = new System.Windows.Forms.DataGridView();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).BeginInit();
            this.SuspendLayout();
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(354, 187);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(136, 23);
            this.btlammoi.TabIndex = 14;
            this.btlammoi.Text = "Làm mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // btloaddulieu
            // 
            this.btloaddulieu.Location = new System.Drawing.Point(354, 154);
            this.btloaddulieu.Name = "btloaddulieu";
            this.btloaddulieu.Size = new System.Drawing.Size(136, 23);
            this.btloaddulieu.TabIndex = 13;
            this.btloaddulieu.Text = "Load dữ liệu";
            this.btloaddulieu.UseVisualStyleBackColor = true;
            this.btloaddulieu.Click += new System.EventHandler(this.btloaddulieu_Click);
            // 
            // btsualoaisp
            // 
            this.btsualoaisp.Location = new System.Drawing.Point(354, 93);
            this.btsualoaisp.Name = "btsualoaisp";
            this.btsualoaisp.Size = new System.Drawing.Size(136, 23);
            this.btsualoaisp.TabIndex = 12;
            this.btsualoaisp.Text = "Sửa";
            this.btsualoaisp.UseVisualStyleBackColor = true;
            this.btsualoaisp.Click += new System.EventHandler(this.btsualoaisp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Location = new System.Drawing.Point(21, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 71);
            this.groupBox1.TabIndex = 11;
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
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "TRÌNH QUẢN LÝ LOẠI SẢN PHẨM";
            // 
            // btthemloaisanpham
            // 
            this.btthemloaisanpham.Location = new System.Drawing.Point(354, 64);
            this.btthemloaisanpham.Name = "btthemloaisanpham";
            this.btthemloaisanpham.Size = new System.Drawing.Size(136, 23);
            this.btthemloaisanpham.TabIndex = 10;
            this.btthemloaisanpham.Text = "Thêm";
            this.btthemloaisanpham.UseVisualStyleBackColor = true;
            this.btthemloaisanpham.Click += new System.EventHandler(this.btthemloaisanpham_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvloai);
            this.panel1.Location = new System.Drawing.Point(21, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 245);
            this.panel1.TabIndex = 15;
            // 
            // dgvloai
            // 
            this.dgvloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloai,
            this.tenloai});
            this.dgvloai.Location = new System.Drawing.Point(3, 3);
            this.dgvloai.Name = "dgvloai";
            this.dgvloai.Size = new System.Drawing.Size(463, 239);
            this.dgvloai.TabIndex = 0;
            this.dgvloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvloai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(85, 122);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.ReadOnly = true;
            this.txtmaloai.Size = new System.Drawing.Size(240, 20);
            this.txtmaloai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã loại:";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(85, 163);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(240, 20);
            this.txttenloai.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên loại:";
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(465, 6);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(75, 23);
            this.btdong.TabIndex = 36;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(354, 123);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(136, 23);
            this.btxoa.TabIndex = 37;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // maloai
            // 
            this.maloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Mã loại";
            this.maloai.Name = "maloai";
            // 
            // tenloai
            // 
            this.tenloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenloai.DataPropertyName = "ten";
            this.tenloai.HeaderText = "Tên loại";
            this.tenloai.Name = "tenloai";
            // 
            // FrmQLLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(552, 482);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btlammoi);
            this.Controls.Add(this.btloaddulieu);
            this.Controls.Add(this.btsualoaisp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthemloaisanpham);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmQLLoaiSanPham";
            this.Text = "Màn hình loại sản phẩm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btloaddulieu;
        private System.Windows.Forms.Button btsualoaisp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthemloaisanpham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
    }
}