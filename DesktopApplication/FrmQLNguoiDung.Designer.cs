namespace DesktopApplication
{
    partial class FrmQLNguoiDung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.btchonhinh = new System.Windows.Forms.Button();
            this.txthinh = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.dgvnguoidung = new System.Windows.Forms.DataGridView();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btthemnguoidung = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btsuanguoidung = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btloaddulieu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.cbquyenhang = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btdong = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguoidung)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Location = new System.Drawing.Point(41, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QL Tìm Kiếm";
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(97, 37);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(159, 20);
            this.txttukhoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người dùng:";
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(276, 34);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 23);
            this.bttim.TabIndex = 1;
            this.bttim.Text = "Tìm kiếm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // btchonhinh
            // 
            this.btchonhinh.Location = new System.Drawing.Point(466, 279);
            this.btchonhinh.Name = "btchonhinh";
            this.btchonhinh.Size = new System.Drawing.Size(75, 23);
            this.btchonhinh.TabIndex = 29;
            this.btchonhinh.Text = "Chọn hình";
            this.btchonhinh.UseVisualStyleBackColor = true;
            this.btchonhinh.Click += new System.EventHandler(this.btchonhinh_Click);
            // 
            // txthinh
            // 
            this.txthinh.Location = new System.Drawing.Point(346, 253);
            this.txthinh.Name = "txthinh";
            this.txthinh.ReadOnly = true;
            this.txthinh.Size = new System.Drawing.Size(194, 20);
            this.txthinh.TabIndex = 27;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(346, 99);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(194, 20);
            this.txtemail.TabIndex = 23;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(346, 47);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(194, 20);
            this.txtsdt.TabIndex = 22;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(346, 210);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(194, 20);
            this.txtdiachi.TabIndex = 21;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(67, 154);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(194, 20);
            this.txthoten.TabIndex = 18;
            // 
            // dgvnguoidung
            // 
            this.dgvnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.hoten,
            this.gioitinhnam,
            this.ngaysinh,
            this.diachi,
            this.sdt,
            this.hinh,
            this.email,
            this.quyenhang});
            this.dgvnguoidung.Location = new System.Drawing.Point(3, 3);
            this.dgvnguoidung.Name = "dgvnguoidung";
            this.dgvnguoidung.Size = new System.Drawing.Size(606, 186);
            this.dgvnguoidung.TabIndex = 0;
            this.dgvnguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellContentClick);
            this.dgvnguoidung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellContentClick);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(67, 99);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(194, 20);
            this.txtpassword.TabIndex = 17;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(67, 47);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(194, 20);
            this.txtusername.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày sinh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Họ tên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Uername:";
            // 
            // btthemnguoidung
            // 
            this.btthemnguoidung.Location = new System.Drawing.Point(418, 88);
            this.btthemnguoidung.Name = "btthemnguoidung";
            this.btthemnguoidung.Size = new System.Drawing.Size(136, 23);
            this.btthemnguoidung.TabIndex = 2;
            this.btthemnguoidung.Text = "Thêm";
            this.btthemnguoidung.UseVisualStyleBackColor = true;
            this.btthemnguoidung.Click += new System.EventHandler(this.btthemnguoidung_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Địa chỉ:";
            // 
            // btsuanguoidung
            // 
            this.btsuanguoidung.Location = new System.Drawing.Point(418, 117);
            this.btsuanguoidung.Name = "btsuanguoidung";
            this.btsuanguoidung.Size = new System.Drawing.Size(136, 23);
            this.btsuanguoidung.TabIndex = 5;
            this.btsuanguoidung.Text = "Sửa";
            this.btsuanguoidung.UseVisualStyleBackColor = true;
            this.btsuanguoidung.Click += new System.EventHandler(this.btsuanguoidung_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Giới tính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "SDT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quyền hạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hình:";
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(418, 210);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(136, 23);
            this.btlammoi.TabIndex = 8;
            this.btlammoi.Text = "Làm mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // btloaddulieu
            // 
            this.btloaddulieu.Location = new System.Drawing.Point(418, 179);
            this.btloaddulieu.Name = "btloaddulieu";
            this.btloaddulieu.Size = new System.Drawing.Size(136, 23);
            this.btloaddulieu.TabIndex = 7;
            this.btloaddulieu.Text = "Load dữ liệu";
            this.btloaddulieu.UseVisualStyleBackColor = true;
            this.btloaddulieu.Click += new System.EventHandler(this.btloaddulieu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbgioitinh);
            this.groupBox2.Controls.Add(this.cbquyenhang);
            this.groupBox2.Controls.Add(this.dtngaysinh);
            this.groupBox2.Controls.Add(this.btchonhinh);
            this.groupBox2.Controls.Add(this.txthinh);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txthoten);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Location = new System.Drawing.Point(634, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 353);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Người dùng";
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(70, 202);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(191, 21);
            this.cbgioitinh.TabIndex = 32;
            // 
            // cbquyenhang
            // 
            this.cbquyenhang.FormattingEnabled = true;
            this.cbquyenhang.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbquyenhang.Location = new System.Drawing.Point(346, 152);
            this.cbquyenhang.Name = "cbquyenhang";
            this.cbquyenhang.Size = new System.Drawing.Size(195, 21);
            this.cbquyenhang.TabIndex = 31;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(70, 248);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(191, 20);
            this.dtngaysinh.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvnguoidung);
            this.panel2.Location = new System.Drawing.Point(13, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 192);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRÌNH QUẢN LÝ NGƯỜI DÙNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Controls.Add(this.btdong);
            this.panel1.Controls.Add(this.btlammoi);
            this.panel1.Controls.Add(this.btloaddulieu);
            this.panel1.Controls.Add(this.btsuanguoidung);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btthemnguoidung);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 465);
            this.panel1.TabIndex = 1;
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(1125, 12);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(75, 23);
            this.btdong.TabIndex = 36;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "UserName";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.Visible = false;
            this.password.Width = 78;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            // 
            // gioitinhnam
            // 
            this.gioitinhnam.DataPropertyName = "gioitinhnam";
            this.gioitinhnam.HeaderText = "GT Nam";
            this.gioitinhnam.Name = "gioitinhnam";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SDT";
            this.sdt.Name = "sdt";
            // 
            // hinh
            // 
            this.hinh.DataPropertyName = "hinh";
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // quyenhang
            // 
            this.quyenhang.DataPropertyName = "quyenhang";
            this.quyenhang.HeaderText = "Quyền Hạng";
            this.quyenhang.Name = "quyenhang";
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(418, 146);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(136, 23);
            this.btxoa.TabIndex = 37;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // FrmQLNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1212, 465);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmQLNguoiDung";
            this.Text = "Màn hình quản lý người dùng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguoidung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btchonhinh;
        private System.Windows.Forms.TextBox txthinh;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.DataGridView dgvnguoidung;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btthemnguoidung;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btsuanguoidung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btloaddulieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenhang;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.ComboBox cbquyenhang;
    }
}