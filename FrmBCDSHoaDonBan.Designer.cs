namespace CuaHangGiayDep
{
    partial class FrmBCDSHoaDonBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_BCDSHDB = new System.Windows.Forms.DataGridView();
            this.SoHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lamlai = new System.Windows.Forms.Button();
            this.btn_inbaocao = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BCDSHDB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(166, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Báo Cáo Danh Sách Hóa Đơn Bán\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(60, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập vào mã nhân viên ";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(282, 46);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(186, 28);
            this.cboMaNV.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã NV";
            // 
            // DataGridView_BCDSHDB
            // 
            this.DataGridView_BCDSHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_BCDSHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BCDSHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDB,
            this.MaNV,
            this.NgayBan,
            this.MaKhach,
            this.TongTien});
            this.DataGridView_BCDSHDB.Location = new System.Drawing.Point(93, 210);
            this.DataGridView_BCDSHDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView_BCDSHDB.Name = "DataGridView_BCDSHDB";
            this.DataGridView_BCDSHDB.RowHeadersWidth = 62;
            this.DataGridView_BCDSHDB.RowTemplate.Height = 28;
            this.DataGridView_BCDSHDB.Size = new System.Drawing.Size(607, 186);
            this.DataGridView_BCDSHDB.TabIndex = 6;
            // 
            // SoHDB
            // 
            this.SoHDB.DataPropertyName = "SoHDB";
            this.SoHDB.HeaderText = "Số Hóa Đơn Bán";
            this.SoHDB.MinimumWidth = 8;
            this.SoHDB.Name = "SoHDB";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.MinimumWidth = 8;
            this.NgayBan.Name = "NgayBan";
            // 
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKhach";
            this.MaKhach.HeaderText = "Mã khách";
            this.MaKhach.MinimumWidth = 8;
            this.MaKhach.Name = "MaKhach";
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
            this.groupBox2.Controls.Add(this.btn_lamlai);
            this.groupBox2.Controls.Add(this.btn_inbaocao);
            this.groupBox2.Controls.Add(this.btn_baocao);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Location = new System.Drawing.Point(60, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng";
            // 
            // btn_lamlai
            // 
            this.btn_lamlai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_lamlai.Location = new System.Drawing.Point(361, 34);
            this.btn_lamlai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lamlai.Name = "btn_lamlai";
            this.btn_lamlai.Size = new System.Drawing.Size(107, 38);
            this.btn_lamlai.TabIndex = 11;
            this.btn_lamlai.Text = "Làm Lại ";
            this.btn_lamlai.UseVisualStyleBackColor = false;
            this.btn_lamlai.Click += new System.EventHandler(this.btn_lamlai_Click);
            // 
            // btn_inbaocao
            // 
            this.btn_inbaocao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inbaocao.Location = new System.Drawing.Point(53, 31);
            this.btn_inbaocao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inbaocao.Name = "btn_inbaocao";
            this.btn_inbaocao.Size = new System.Drawing.Size(121, 38);
            this.btn_inbaocao.TabIndex = 8;
            this.btn_inbaocao.Text = "In Báo Cáo";
            this.btn_inbaocao.UseVisualStyleBackColor = false;
            this.btn_inbaocao.Click += new System.EventHandler(this.btn_inbaocao_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_baocao.Location = new System.Drawing.Point(208, 34);
            this.btn_baocao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(115, 37);
            this.btn_baocao.TabIndex = 9;
            this.btn_baocao.Text = "Báo Cáo";
            this.btn_baocao.UseVisualStyleBackColor = false;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(511, 34);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(96, 38);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // FrmBCDSHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DataGridView_BCDSHDB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBCDSHoaDonBan";
            this.Text = "FrmBCDSHoaDonBan";
            this.Load += new System.EventHandler(this.FrmBCDSHoaDonBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BCDSHDB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridView_BCDSHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_lamlai;
        private System.Windows.Forms.Button btn_inbaocao;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cboMaNV;
    }
}