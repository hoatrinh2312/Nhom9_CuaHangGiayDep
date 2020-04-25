namespace CuaHangGiayDep
{
    partial class frmBaoCaoHDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoHDN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_BC_HDN = new System.Windows.Forms.DataGridView();
            this.SoHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BC_HDN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboQuy);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn quý nhập năm";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(497, 35);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(250, 30);
            this.txtNam.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quý";
            // 
            // cboQuy
            // 
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuy.Location = new System.Drawing.Point(86, 35);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(254, 30);
            this.cboQuy.TabIndex = 0;
            this.cboQuy.SelectedIndexChanged += new System.EventHandler(this.cboQuy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(234, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Báo Cáo Danh Sách Hóa Đơn Nhập";
            // 
            // dataGridView_BC_HDN
            // 
            this.dataGridView_BC_HDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BC_HDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BC_HDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDN,
            this.MaNV,
            this.NgayNhap,
            this.MaNCC,
            this.TongTien});
            this.dataGridView_BC_HDN.Location = new System.Drawing.Point(87, 253);
            this.dataGridView_BC_HDN.Name = "dataGridView_BC_HDN";
            this.dataGridView_BC_HDN.RowHeadersWidth = 62;
            this.dataGridView_BC_HDN.RowTemplate.Height = 28;
            this.dataGridView_BC_HDN.Size = new System.Drawing.Size(872, 245);
            this.dataGridView_BC_HDN.TabIndex = 4;
            // 
            // SoHDN
            // 
            this.SoHDN.DataPropertyName = "SoHDN";
            this.SoHDN.HeaderText = "Số Hóa Đơn Nhập";
            this.SoHDN.MinimumWidth = 8;
            this.SoHDN.Name = "SoHDN";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.MinimumWidth = 8;
            this.NgayNhap.Name = "NgayNhap";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã Nhà CC";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamLai);
            this.groupBox2.Controls.Add(this.btnInBaoCao);
            this.groupBox2.Controls.Add(this.btnBaoCao);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Location = new System.Drawing.Point(87, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Chức Năng";
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamLai.Location = new System.Drawing.Point(522, 40);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(131, 34);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "Làm Lại BC";
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInBaoCao.Location = new System.Drawing.Point(81, 40);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(131, 34);
            this.btnInBaoCao.TabIndex = 4;
            this.btnInBaoCao.Text = "In Báo Cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaoCao.Location = new System.Drawing.Point(310, 41);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(131, 34);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(706, 41);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 34);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng Tiền Nhập Hàng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(661, 521);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(298, 26);
            this.txtTongTien.TabIndex = 11;
            // 
            // frmBaoCaoHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 697);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView_BC_HDN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCaoHDN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BC_HDN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_BC_HDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}