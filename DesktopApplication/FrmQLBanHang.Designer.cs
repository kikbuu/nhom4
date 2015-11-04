namespace DesktopApplication
{
    partial class FrmQLBanHang
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
            this.dgvcthd = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahdct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btcthd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbmasp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btreset = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmahdct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btlammoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btloaddulieu = new System.Windows.Forms.Button();
            this.btsuahd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btthemhd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.idhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoanthanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtngaymua = new System.Windows.Forms.DateTimePicker();
            this.btdong = new System.Windows.Forms.Button();
            this.btxoahd = new System.Windows.Forms.Button();
            this.btxacnhandonhang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcthd
            // 
            this.dgvcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mahdct,
            this.masp,
            this.soluong,
            this.thanhtien});
            this.dgvcthd.Location = new System.Drawing.Point(3, 3);
            this.dgvcthd.Name = "dgvcthd";
            this.dgvcthd.Size = new System.Drawing.Size(666, 233);
            this.dgvcthd.TabIndex = 0;
            this.dgvcthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcthd_CellContentClick);
            this.dgvcthd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcthd_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // mahdct
            // 
            this.mahdct.DataPropertyName = "mahd";
            this.mahdct.HeaderText = "Mã HD";
            this.mahdct.Name = "mahdct";
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
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvcthd);
            this.panel2.Location = new System.Drawing.Point(498, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 239);
            this.panel2.TabIndex = 63;
            // 
            // btcthd
            // 
            this.btcthd.Location = new System.Drawing.Point(92, 171);
            this.btcthd.Name = "btcthd";
            this.btcthd.Size = new System.Drawing.Size(75, 23);
            this.btcthd.TabIndex = 16;
            this.btcthd.Text = "Chi tiết HD";
            this.btcthd.UseVisualStyleBackColor = true;
            this.btcthd.Click += new System.EventHandler(this.btcthd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbmasp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btcthd);
            this.groupBox2.Controls.Add(this.btreset);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Controls.Add(this.txtthanhtien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtmahdct);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(498, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 219);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // cbmasp
            // 
            this.cbmasp.FormattingEnabled = true;
            this.cbmasp.Location = new System.Drawing.Point(90, 124);
            this.cbmasp.Name = "cbmasp";
            this.cbmasp.Size = new System.Drawing.Size(208, 21);
            this.cbmasp.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tên SP:";
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
            this.txtthanhtien.Location = new System.Drawing.Point(397, 80);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new System.Drawing.Size(208, 20);
            this.txtthanhtien.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thành tiền:";
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
            // txtmahdct
            // 
            this.txtmahdct.Location = new System.Drawing.Point(90, 80);
            this.txtmahdct.Name = "txtmahdct";
            this.txtmahdct.ReadOnly = true;
            this.txtmahdct.Size = new System.Drawing.Size(208, 20);
            this.txtmahdct.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã HD:";
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
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(75, 154);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(240, 20);
            this.txtuser.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "UserName:";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(75, 122);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.ReadOnly = true;
            this.txtmahd.Size = new System.Drawing.Size(240, 20);
            this.txtmahd.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Mã HD:";
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(344, 201);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(136, 23);
            this.btlammoi.TabIndex = 56;
            this.btlammoi.Text = "Làm mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ngày mua:";
            // 
            // btloaddulieu
            // 
            this.btloaddulieu.Location = new System.Drawing.Point(344, 164);
            this.btloaddulieu.Name = "btloaddulieu";
            this.btloaddulieu.Size = new System.Drawing.Size(136, 23);
            this.btloaddulieu.TabIndex = 55;
            this.btloaddulieu.Text = "Load dữ liệu";
            this.btloaddulieu.UseVisualStyleBackColor = true;
            this.btloaddulieu.Click += new System.EventHandler(this.btloaddulieu_Click);
            // 
            // btsuahd
            // 
            this.btsuahd.Location = new System.Drawing.Point(344, 98);
            this.btsuahd.Name = "btsuahd";
            this.btsuahd.Size = new System.Drawing.Size(136, 23);
            this.btsuahd.TabIndex = 54;
            this.btsuahd.Text = "Sửa HD";
            this.btsuahd.UseVisualStyleBackColor = true;
            this.btsuahd.Click += new System.EventHandler(this.btsuahd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Location = new System.Drawing.Point(11, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 71);
            this.groupBox1.TabIndex = 53;
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
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã HD:";
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
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "TRÌNH QUẢN LÝ BÁN HÀNG";
            // 
            // btthemhd
            // 
            this.btthemhd.Location = new System.Drawing.Point(344, 64);
            this.btthemhd.Name = "btthemhd";
            this.btthemhd.Size = new System.Drawing.Size(136, 23);
            this.btthemhd.TabIndex = 52;
            this.btthemhd.Text = "Thêm HD";
            this.btthemhd.UseVisualStyleBackColor = true;
            this.btthemhd.Click += new System.EventHandler(this.btthemhd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvhoadon);
            this.panel1.Location = new System.Drawing.Point(11, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 245);
            this.panel1.TabIndex = 57;
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhd,
            this.mahh,
            this.user,
            this.ngaymua,
            this.hoanthanh});
            this.dgvhoadon.Location = new System.Drawing.Point(3, 3);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.Size = new System.Drawing.Size(463, 239);
            this.dgvhoadon.TabIndex = 0;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellContentClick);
            this.dgvhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellContentClick);
            // 
            // idhd
            // 
            this.idhd.DataPropertyName = "id";
            this.idhd.HeaderText = "ID";
            this.idhd.Name = "idhd";
            // 
            // mahh
            // 
            this.mahh.DataPropertyName = "mahd";
            this.mahh.HeaderText = "Mã HD";
            this.mahh.Name = "mahh";
            // 
            // user
            // 
            this.user.DataPropertyName = "username";
            this.user.HeaderText = "User";
            this.user.Name = "user";
            // 
            // ngaymua
            // 
            this.ngaymua.DataPropertyName = "ngaymua";
            this.ngaymua.HeaderText = "Ngày mua";
            this.ngaymua.Name = "ngaymua";
            // 
            // hoanthanh
            // 
            this.hoanthanh.DataPropertyName = "hoanthanh";
            this.hoanthanh.HeaderText = "Hoàn thành";
            this.hoanthanh.Name = "hoanthanh";
            // 
            // dtngaymua
            // 
            this.dtngaymua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaymua.Location = new System.Drawing.Point(75, 184);
            this.dtngaymua.Name = "dtngaymua";
            this.dtngaymua.Size = new System.Drawing.Size(240, 20);
            this.dtngaymua.TabIndex = 66;
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(1095, 12);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(75, 23);
            this.btdong.TabIndex = 67;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // btxoahd
            // 
            this.btxoahd.Location = new System.Drawing.Point(344, 129);
            this.btxoahd.Name = "btxoahd";
            this.btxoahd.Size = new System.Drawing.Size(136, 23);
            this.btxoahd.TabIndex = 68;
            this.btxoahd.Text = "Xóa HD";
            this.btxoahd.UseVisualStyleBackColor = true;
            this.btxoahd.Click += new System.EventHandler(this.btxoahd_Click);
            // 
            // btxacnhandonhang
            // 
            this.btxacnhandonhang.Location = new System.Drawing.Point(344, 241);
            this.btxacnhandonhang.Name = "btxacnhandonhang";
            this.btxacnhandonhang.Size = new System.Drawing.Size(136, 23);
            this.btxacnhandonhang.TabIndex = 69;
            this.btxacnhandonhang.Text = "Xác nhận đơn hàng";
            this.btxacnhandonhang.UseVisualStyleBackColor = true;
            this.btxacnhandonhang.Click += new System.EventHandler(this.btxacnhandonhang_Click);
            // 
            // FrmQLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1197, 546);
            this.Controls.Add(this.btxacnhandonhang);
            this.Controls.Add(this.btxoahd);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.dtngaymua);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btlammoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btloaddulieu);
            this.Controls.Add(this.btsuahd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthemhd);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmQLBanHang";
            this.Text = "Màn hình quản lý bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcthd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btcthd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmahdct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btloaddulieu;
        private System.Windows.Forms.Button btsuahd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthemhd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.DateTimePicker dtngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoanthanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdct;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbmasp;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button btxoahd;
        private System.Windows.Forms.Button btxacnhandonhang;
    }
}