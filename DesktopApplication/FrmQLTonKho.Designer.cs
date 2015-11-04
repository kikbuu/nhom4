namespace DesktopApplication
{
    partial class FrmQLTonKho
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluongton = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btloaddulieu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvtonkho = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgcapnhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btlammoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtthoigiancapnhat = new System.Windows.Forms.DateTimePicker();
            this.btreset = new System.Windows.Forms.Button();
            this.btthongke = new System.Windows.Forms.Button();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtonkho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Số lượng tồn:";
            // 
            // txtsoluongton
            // 
            this.txtsoluongton.Location = new System.Drawing.Point(121, 138);
            this.txtsoluongton.Name = "txtsoluongton";
            this.txtsoluongton.ReadOnly = true;
            this.txtsoluongton.Size = new System.Drawing.Size(231, 20);
            this.txtsoluongton.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Thời gian CN:";
            // 
            // btloaddulieu
            // 
            this.btloaddulieu.Location = new System.Drawing.Point(350, 54);
            this.btloaddulieu.Name = "btloaddulieu";
            this.btloaddulieu.Size = new System.Drawing.Size(136, 23);
            this.btloaddulieu.TabIndex = 40;
            this.btloaddulieu.Text = "Load dữ liệu";
            this.btloaddulieu.UseVisualStyleBackColor = true;
            this.btloaddulieu.Click += new System.EventHandler(this.btloaddulieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Location = new System.Drawing.Point(17, 45);
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
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP:";
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
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "TRÌNH QUẢN LÝ TỒN KHO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvtonkho);
            this.panel1.Location = new System.Drawing.Point(20, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 384);
            this.panel1.TabIndex = 42;
            // 
            // dgvtonkho
            // 
            this.dgvtonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtonkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.masp,
            this.tgcapnhat,
            this.soluongton});
            this.dgvtonkho.Location = new System.Drawing.Point(3, 1);
            this.dgvtonkho.Name = "dgvtonkho";
            this.dgvtonkho.Size = new System.Drawing.Size(463, 380);
            this.dgvtonkho.TabIndex = 0;
            this.dgvtonkho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtonkho_CellContentClick);
            this.dgvtonkho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtonkho_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
            // 
            // tgcapnhat
            // 
            this.tgcapnhat.DataPropertyName = "ngaycapnhat";
            this.tgcapnhat.HeaderText = "Thời gian cập nhật";
            this.tgcapnhat.Name = "tgcapnhat";
            // 
            // soluongton
            // 
            this.soluongton.DataPropertyName = "soluongton";
            this.soluongton.HeaderText = "Số lượng tồn";
            this.soluongton.Name = "soluongton";
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(350, 99);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(136, 23);
            this.btlammoi.TabIndex = 41;
            this.btlammoi.Text = "Làm mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtthoigiancapnhat);
            this.groupBox2.Controls.Add(this.btreset);
            this.groupBox2.Controls.Add(this.btthongke);
            this.groupBox2.Controls.Add(this.txtmasp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtsoluongton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(517, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 483);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểm tra tồn kho";
            // 
            // dtthoigiancapnhat
            // 
            this.dtthoigiancapnhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtthoigiancapnhat.Location = new System.Drawing.Point(121, 94);
            this.dtthoigiancapnhat.Name = "dtthoigiancapnhat";
            this.dtthoigiancapnhat.Size = new System.Drawing.Size(231, 20);
            this.dtthoigiancapnhat.TabIndex = 51;
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(277, 180);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 50;
            this.btreset.Text = "Làm mới";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btthongke
            // 
            this.btthongke.Location = new System.Drawing.Point(121, 180);
            this.btthongke.Name = "btthongke";
            this.btthongke.Size = new System.Drawing.Size(75, 23);
            this.btthongke.TabIndex = 49;
            this.btthongke.Text = "Thống kê";
            this.btthongke.UseVisualStyleBackColor = true;
            this.btthongke.Click += new System.EventHandler(this.btthongke_Click);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(121, 51);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(231, 20);
            this.txtmasp.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Mã SP:";
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(931, 9);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(75, 23);
            this.btdong.TabIndex = 50;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // FrmQLTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1018, 544);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btloaddulieu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btlammoi);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FrmQLTonKho";
            this.Text = "Màn hình quản lý tồn kho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtonkho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoluongton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btloaddulieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvtonkho;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgcapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btthongke;
        private System.Windows.Forms.DateTimePicker dtthoigiancapnhat;
        private System.Windows.Forms.Button btdong;
    }
}