namespace DesktopApplication
{
    partial class FrmQLNhapHang
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
            this.btloaddulieu = new System.Windows.Forms.Button();
            this.btsuapn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btthempn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvphieunhap = new System.Windows.Forms.DataGridView();
            this.idhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btlammoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttinh = new System.Windows.Forms.Button();
            this.cbmasp = new System.Windows.Forms.ComboBox();
            this.btctpn = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmapnct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvctpn = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapnct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btdong = new System.Windows.Forms.Button();
            this.btxoapn = new System.Windows.Forms.Button();
            this.bthoanthanh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpn)).BeginInit();
            this.SuspendLayout();
            // 
            // btloaddulieu
            // 
            this.btloaddulieu.Location = new System.Drawing.Point(346, 157);
            this.btloaddulieu.Name = "btloaddulieu";
            this.btloaddulieu.Size = new System.Drawing.Size(136, 23);
            this.btloaddulieu.TabIndex = 40;
            this.btloaddulieu.Text = "Load dữ liệu";
            this.btloaddulieu.UseVisualStyleBackColor = true;
            this.btloaddulieu.Click += new System.EventHandler(this.btloaddulieu_Click);
            // 
            // btsuapn
            // 
            this.btsuapn.Location = new System.Drawing.Point(346, 95);
            this.btsuapn.Name = "btsuapn";
            this.btsuapn.Size = new System.Drawing.Size(136, 23);
            this.btsuapn.TabIndex = 39;
            this.btsuapn.Text = "Sửa PN";
            this.btsuapn.UseVisualStyleBackColor = true;
            this.btsuapn.Click += new System.EventHandler(this.btsuapn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Location = new System.Drawing.Point(13, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 71);
            this.groupBox1.TabIndex = 38;
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
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã PN:";
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
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "TRÌNH QUẢN LÝ NHẬP HÀNG";
            // 
            // btthempn
            // 
            this.btthempn.Location = new System.Drawing.Point(346, 64);
            this.btthempn.Name = "btthempn";
            this.btthempn.Size = new System.Drawing.Size(136, 23);
            this.btthempn.TabIndex = 37;
            this.btthempn.Text = "Thêm PN";
            this.btthempn.UseVisualStyleBackColor = true;
            this.btthempn.Click += new System.EventHandler(this.btthempn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvphieunhap);
            this.panel1.Location = new System.Drawing.Point(13, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 245);
            this.panel1.TabIndex = 42;
            // 
            // dgvphieunhap
            // 
            this.dgvphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhd,
            this.mapn,
            this.ngaynhap});
            this.dgvphieunhap.Location = new System.Drawing.Point(3, 3);
            this.dgvphieunhap.Name = "dgvphieunhap";
            this.dgvphieunhap.Size = new System.Drawing.Size(463, 239);
            this.dgvphieunhap.TabIndex = 0;
            this.dgvphieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieunhap_CellContentClick);
            this.dgvphieunhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieunhap_CellContentClick);
            // 
            // idhd
            // 
            this.idhd.DataPropertyName = "id";
            this.idhd.HeaderText = "ID";
            this.idhd.Name = "idhd";
            // 
            // mapn
            // 
            this.mapn.DataPropertyName = "mapn";
            this.mapn.HeaderText = "Mã PN";
            this.mapn.Name = "mapn";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày nhập:";
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(77, 153);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.ReadOnly = true;
            this.txtmapn.Size = new System.Drawing.Size(240, 20);
            this.txtmapn.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã PN:";
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(346, 193);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(136, 23);
            this.btlammoi.TabIndex = 41;
            this.btlammoi.Text = "Làm mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttinh);
            this.groupBox2.Controls.Add(this.cbmasp);
            this.groupBox2.Controls.Add(this.btctpn);
            this.groupBox2.Controls.Add(this.btreset);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Controls.Add(this.txtthanhtien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtgia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtmapnct);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(500, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 219);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // bttinh
            // 
            this.bttinh.Location = new System.Drawing.Point(611, 117);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(46, 23);
            this.bttinh.TabIndex = 18;
            this.bttinh.Text = "Tính";
            this.bttinh.UseVisualStyleBackColor = true;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // cbmasp
            // 
            this.cbmasp.FormattingEnabled = true;
            this.cbmasp.Location = new System.Drawing.Point(92, 118);
            this.cbmasp.Name = "cbmasp";
            this.cbmasp.Size = new System.Drawing.Size(206, 21);
            this.cbmasp.TabIndex = 17;
            // 
            // btctpn
            // 
            this.btctpn.Location = new System.Drawing.Point(92, 171);
            this.btctpn.Name = "btctpn";
            this.btctpn.Size = new System.Drawing.Size(75, 23);
            this.btctpn.TabIndex = 16;
            this.btctpn.Text = "Chi tiết PN";
            this.btctpn.UseVisualStyleBackColor = true;
            this.btctpn.Click += new System.EventHandler(this.btctpn_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(483, 171);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 15;
            this.btreset.Text = "Làm mới";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btxoa
            // 
            this.btxoa.Enabled = false;
            this.btxoa.Location = new System.Drawing.Point(380, 171);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 14;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(283, 171);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 13;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(176, 171);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 12;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(397, 120);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new System.Drawing.Size(208, 20);
            this.txtthanhtien.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thành tiền:";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(397, 80);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(208, 20);
            this.txtgia.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giá:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(397, 36);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(208, 20);
            this.txtsoluong.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên SP:";
            // 
            // txtmapnct
            // 
            this.txtmapnct.Location = new System.Drawing.Point(90, 80);
            this.txtmapnct.Name = "txtmapnct";
            this.txtmapnct.ReadOnly = true;
            this.txtmapnct.Size = new System.Drawing.Size(208, 20);
            this.txtmapnct.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã PN:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(90, 36);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(208, 20);
            this.txtid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvctpn);
            this.panel2.Location = new System.Drawing.Point(500, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 239);
            this.panel2.TabIndex = 48;
            // 
            // dgvctpn
            // 
            this.dgvctpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctpn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mapnct,
            this.masp,
            this.soluong,
            this.gia,
            this.thanhtien});
            this.dgvctpn.Location = new System.Drawing.Point(3, 3);
            this.dgvctpn.Name = "dgvctpn";
            this.dgvctpn.Size = new System.Drawing.Size(666, 233);
            this.dgvctpn.TabIndex = 0;
            this.dgvctpn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvctpn_CellContentClick);
            this.dgvctpn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvctpn_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // mapnct
            // 
            this.mapnct.DataPropertyName = "mapn";
            this.mapnct.HeaderText = "Mã PN";
            this.mapnct.Name = "mapnct";
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
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
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaynhap.Location = new System.Drawing.Point(77, 192);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(240, 20);
            this.dtngaynhap.TabIndex = 49;
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(1094, 9);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(75, 23);
            this.btdong.TabIndex = 50;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // btxoapn
            // 
            this.btxoapn.Location = new System.Drawing.Point(346, 125);
            this.btxoapn.Name = "btxoapn";
            this.btxoapn.Size = new System.Drawing.Size(136, 23);
            this.btxoapn.TabIndex = 51;
            this.btxoapn.Text = "Xóa PN";
            this.btxoapn.UseVisualStyleBackColor = true;
            this.btxoapn.Click += new System.EventHandler(this.btxoapn_Click);
            // 
            // bthoanthanh
            // 
            this.bthoanthanh.Location = new System.Drawing.Point(346, 222);
            this.bthoanthanh.Name = "bthoanthanh";
            this.bthoanthanh.Size = new System.Drawing.Size(136, 23);
            this.bthoanthanh.TabIndex = 52;
            this.bthoanthanh.Text = "Hoàn thành";
            this.bthoanthanh.UseVisualStyleBackColor = true;
            this.bthoanthanh.Click += new System.EventHandler(this.bthoanthanh_Click);
            // 
            // FrmQLNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1184, 543);
            this.Controls.Add(this.bthoanthanh);
            this.Controls.Add(this.btxoapn);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.dtngaynhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btloaddulieu);
            this.Controls.Add(this.btsuapn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthempn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btlammoi);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmQLNhapHang";
            this.Text = "Màn hình quản lý nhập hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btloaddulieu;
        private System.Windows.Forms.Button btsuapn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthempn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvphieunhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvctpn;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmapnct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btctpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapnct;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.ComboBox cbmasp;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.Button btxoapn;
        private System.Windows.Forms.Button bthoanthanh;
    }
}