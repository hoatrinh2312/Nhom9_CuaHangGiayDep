namespace CuaHangGiayDep
{
    partial class FrmBCDSHoaĐonBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_BCDSHDB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btn_inbaocao = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_lamlai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoHDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.SoHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BCDSHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo danh sách hóa đơn bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV";
            // 
            // DataGridView_BCDSHDB
            // 
            this.DataGridView_BCDSHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BCDSHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDB,
            this.MaNV,
            this.NgayBan,
            this.TenNV,
            this.TongTien,
            this.MaKhach});
            this.DataGridView_BCDSHDB.Location = new System.Drawing.Point(67, 203);
            this.DataGridView_BCDSHDB.Name = "DataGridView_BCDSHDB";
            this.DataGridView_BCDSHDB.RowHeadersWidth = 51;
            this.DataGridView_BCDSHDB.RowTemplate.Height = 24;
            this.DataGridView_BCDSHDB.Size = new System.Drawing.Size(786, 150);
            this.DataGridView_BCDSHDB.TabIndex = 3;
            this.DataGridView_BCDSHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_BCDSHDB_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(604, 389);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(171, 22);
            this.txtTongTien.TabIndex = 5;
            // 
            // btn_inbaocao
            // 
            this.btn_inbaocao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inbaocao.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inbaocao.Location = new System.Drawing.Point(133, 446);
            this.btn_inbaocao.Name = "btn_inbaocao";
            this.btn_inbaocao.Size = new System.Drawing.Size(92, 35);
            this.btn_inbaocao.TabIndex = 6;
            this.btn_inbaocao.Text = "In báo cáo";
            this.btn_inbaocao.UseVisualStyleBackColor = false;
            this.btn_inbaocao.Click += new System.EventHandler(this.btn_inbaocao_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_baocao.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocao.Location = new System.Drawing.Point(321, 446);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(75, 35);
            this.btn_baocao.TabIndex = 7;
            this.btn_baocao.Text = "Báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = false;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_lamlai
            // 
            this.btn_lamlai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_lamlai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamlai.Location = new System.Drawing.Point(514, 447);
            this.btn_lamlai.Name = "btn_lamlai";
            this.btn_lamlai.Size = new System.Drawing.Size(75, 34);
            this.btn_lamlai.TabIndex = 8;
            this.btn_lamlai.Text = "Làm lại";
            this.btn_lamlai.UseVisualStyleBackColor = false;
            this.btn_lamlai.Click += new System.EventHandler(this.btn_lamlai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(700, 446);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số HĐB";
            // 
            // txtSoHDB
            // 
            this.txtSoHDB.Location = new System.Drawing.Point(453, 69);
            this.txtSoHDB.Name = "txtSoHDB";
            this.txtSoHDB.Size = new System.Drawing.Size(100, 22);
            this.txtSoHDB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên NV";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(133, 119);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(115, 22);
            this.txtTenNV.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày Bán";
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(453, 119);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(100, 22);
            this.txtNgayBan.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã Khách";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(786, 67);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(100, 22);
            this.txtMaKhach.TabIndex = 18;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(133, 67);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(115, 24);
            this.cboMaNV.TabIndex = 19;
            // 
            // SoHDB
            // 
            this.SoHDB.DataPropertyName = "SoHDB";
            this.SoHDB.HeaderText = "Số HĐB";
            this.SoHDB.MinimumWidth = 6;
            this.SoHDB.Name = "SoHDB";
            this.SoHDB.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "tongtien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKhach";
            this.MaKhach.HeaderText = "Mã Khách";
            this.MaKhach.MinimumWidth = 6;
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.Width = 125;
            // 
            // FrmBCDSHoaĐonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 520);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNgayBan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoHDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lamlai);
            this.Controls.Add(this.btn_baocao);
            this.Controls.Add(this.btn_inbaocao);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridView_BCDSHDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBCDSHoaĐonBan";
            this.Text = "FrmBCDSHoaĐonBan";
            this.Load += new System.EventHandler(this.FrmBCDSHoaĐonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BCDSHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridView_BCDSHDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btn_inbaocao;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_lamlai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoHDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
    }
}