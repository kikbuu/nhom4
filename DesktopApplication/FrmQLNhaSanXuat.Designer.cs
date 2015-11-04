namespace DesktopApplication
{
    partial class FrmQLNhaSanXuat
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtmansx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvnhasx = new System.Windows.Forms.DataGridView();
            this.mansx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttennsx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btlammoi = new System.Windows.Forms.Button();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.btloaddulieu = new System.Windows.Forms.Button();
            this.btsuanhasx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btthemnhasx = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txthinh = new System.Windows.Forms.TextBox();
            this.btchonhinh = new System.Windows.Forms.Button();
            this.btdong = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhasx)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên NSX:";
            // 
            // txtmansx
            // 
            this.txtmansx.Location = new System.Drawing.Point(89, 125);
            this.txtmansx.Name = "txtmansx";
            this.txtmansx.ReadOnly = true;
            this.txtmansx.Size = new System.Drawing.Size(240, 20);
            this.txtmansx.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã NSX:";
            // 
            // dgvnhasx
            // 
            this.dgvnhasx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhasx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mansx,
            this.tennsx,
            this.diachi,
            this.hinh});
            this.dgvnhasx.Location = new System.Drawing.Point(3, 3);
            this.dgvnhasx.Name = "dgvnhasx";
            this.dgvnhasx.Size = new System.Drawing.Size(463, 239);
            this.dgvnhasx.TabIndex = 0;
            this.dgvnhasx.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhasx_CellContentClick);
            this.dgvnhasx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhasx_CellContentClick);
            // 
            // mansx
            // 
            this.mansx.DataPropertyName = "mansx";
            this.mansx.HeaderText = "Mã NSX";
            this.mansx.Name = "mansx";
            // 
            // tennsx
            // 
            this.tennsx.DataPropertyName = "ten";
            this.tennsx.HeaderText = "Tên NSX";
            this.tennsx.Name = "tennsx";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // hinh
            // 
            this.hinh.DataPropertyName = "hinh";
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            // 
            // txttennsx
            // 
            this.txttennsx.Location = new System.Drawing.Point(89, 166);
            this.txttennsx.Name = "txttennsx";
            this.txttennsx.Size = new System.Drawing.Size(240, 20);
            this.txttennsx.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvnhasx);
            this.panel1.Location = new System.Drawing.Point(25, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 245);
            this.panel1.TabIndex = 26;
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(358, 199);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(136, 23);
            this.btlammoi.TabIndex = 25;
            this.btlammoi.Text = "Làm mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
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
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhà SX:";
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
            // btloaddulieu
            // 
            this.btloaddulieu.Location = new System.Drawing.Point(358, 164);
            this.btloaddulieu.Name = "btloaddulieu";
            this.btloaddulieu.Size = new System.Drawing.Size(136, 23);
            this.btloaddulieu.TabIndex = 24;
            this.btloaddulieu.Text = "Load dữ liệu";
            this.btloaddulieu.UseVisualStyleBackColor = true;
            this.btloaddulieu.Click += new System.EventHandler(this.btloaddulieu_Click);
            // 
            // btsuanhasx
            // 
            this.btsuanhasx.Location = new System.Drawing.Point(358, 100);
            this.btsuanhasx.Name = "btsuanhasx";
            this.btsuanhasx.Size = new System.Drawing.Size(136, 23);
            this.btsuanhasx.TabIndex = 23;
            this.btsuanhasx.Text = "Sửa Nhà SX";
            this.btsuanhasx.UseVisualStyleBackColor = true;
            this.btsuanhasx.Click += new System.EventHandler(this.btsuanhasx_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Location = new System.Drawing.Point(25, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 71);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QL Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "TRÌNH QUẢN LÝ NHÀ SẢN XUẤT";
            // 
            // btthemnhasx
            // 
            this.btthemnhasx.Location = new System.Drawing.Point(358, 67);
            this.btthemnhasx.Name = "btthemnhasx";
            this.btthemnhasx.Size = new System.Drawing.Size(136, 23);
            this.btthemnhasx.TabIndex = 21;
            this.btthemnhasx.Text = "Thêm Nhà SX";
            this.btthemnhasx.UseVisualStyleBackColor = true;
            this.btthemnhasx.Click += new System.EventHandler(this.btthemnhasx_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(89, 201);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(240, 20);
            this.txtdiachi.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hình:";
            // 
            // txthinh
            // 
            this.txthinh.Location = new System.Drawing.Point(89, 240);
            this.txthinh.Name = "txthinh";
            this.txthinh.ReadOnly = true;
            this.txthinh.Size = new System.Drawing.Size(159, 20);
            this.txthinh.TabIndex = 32;
            // 
            // btchonhinh
            // 
            this.btchonhinh.Location = new System.Drawing.Point(254, 238);
            this.btchonhinh.Name = "btchonhinh";
            this.btchonhinh.Size = new System.Drawing.Size(75, 23);
            this.btchonhinh.TabIndex = 33;
            this.btchonhinh.Text = "Chọn hình";
            this.btchonhinh.UseVisualStyleBackColor = true;
            this.btchonhinh.Click += new System.EventHandler(this.btchonhinh_Click);
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(449, 12);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(75, 23);
            this.btdong.TabIndex = 36;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(358, 129);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(136, 23);
            this.btxoa.TabIndex = 37;
            this.btxoa.Text = "Xóa Nhà SX";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // FrmQLNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(529, 545);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.btchonhinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmansx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttennsx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btlammoi);
            this.Controls.Add(this.btloaddulieu);
            this.Controls.Add(this.btsuanhasx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthemnhasx);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmQLNhaSanXuat";
            this.Text = "Màn hình quản lý nhà sản xuất";
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhasx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmansx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvnhasx;
        private System.Windows.Forms.TextBox txttennsx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btloaddulieu;
        private System.Windows.Forms.Button btsuanhasx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthemnhasx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txthinh;
        private System.Windows.Forms.Button btchonhinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mansx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinh;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button btxoa;
    }
}