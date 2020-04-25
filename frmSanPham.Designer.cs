namespace CuaHangGiayDep
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.PicAnh = new System.Windows.Forms.PictureBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboMaNSX = new System.Windows.Forms.ComboBox();
            this.cboMaMua = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboMaDT = new System.Windows.Forms.ComboBox();
            this.cboMaMau = new System.Windows.Forms.ComboBox();
            this.cboMaCL = new System.Windows.Forms.ComboBox();
            this.cboMaCo = new System.Windows.Forms.ComboBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.txtTenGD = new System.Windows.Forms.TextBox();
            this.txtMaGD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHienThiDS = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(376, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Sản Phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.PicAnh);
            this.groupBox1.Controls.Add(this.txtDonGiaBan);
            this.groupBox1.Controls.Add(this.txtDonGiaNhap);
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboMaNSX);
            this.groupBox1.Controls.Add(this.cboMaMua);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboMaDT);
            this.groupBox1.Controls.Add(this.cboMaMau);
            this.groupBox1.Controls.Add(this.cboMaCL);
            this.groupBox1.Controls.Add(this.cboMaCo);
            this.groupBox1.Controls.Add(this.cboMaLoai);
            this.groupBox1.Controls.Add(this.txtTenGD);
            this.groupBox1.Controls.Add(this.txtMaGD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thực hiện nhập";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpen.Location = new System.Drawing.Point(778, 40);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 33);
            this.btnOpen.TabIndex = 28;
            this.btnOpen.Text = "Mở Ảnh";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // PicAnh
            // 
            this.PicAnh.Location = new System.Drawing.Point(778, 86);
            this.PicAnh.Name = "PicAnh";
            this.PicAnh.Size = new System.Drawing.Size(157, 199);
            this.PicAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAnh.TabIndex = 27;
            this.PicAnh.TabStop = false;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(553, 260);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(196, 30);
            this.txtDonGiaBan.TabIndex = 26;
            this.txtDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaBan_KeyPress);
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(553, 219);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(196, 30);
            this.txtDonGiaNhap.TabIndex = 25;
            this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged);
            this.txtDonGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaNhap_KeyPress);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(553, 155);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(196, 54);
            this.txtAnh.TabIndex = 24;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(553, 114);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(196, 30);
            this.txtSoLuong.TabIndex = 22;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 22);
            this.label14.TabIndex = 21;
            this.label14.Text = "Đơn Giá Bán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Đơn Giá Nhập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ảnh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số Lượng";
            // 
            // cboMaNSX
            // 
            this.cboMaNSX.FormattingEnabled = true;
            this.cboMaNSX.Location = new System.Drawing.Point(553, 78);
            this.cboMaNSX.Name = "cboMaNSX";
            this.cboMaNSX.Size = new System.Drawing.Size(196, 30);
            this.cboMaNSX.TabIndex = 17;
            // 
            // cboMaMua
            // 
            this.cboMaMua.FormattingEnabled = true;
            this.cboMaMua.Location = new System.Drawing.Point(553, 42);
            this.cboMaMua.Name = "cboMaMua";
            this.cboMaMua.Size = new System.Drawing.Size(196, 30);
            this.cboMaMua.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mã NSX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã Mùa";
            // 
            // cboMaDT
            // 
            this.cboMaDT.FormattingEnabled = true;
            this.cboMaDT.Location = new System.Drawing.Point(131, 260);
            this.cboMaDT.Name = "cboMaDT";
            this.cboMaDT.Size = new System.Drawing.Size(207, 30);
            this.cboMaDT.TabIndex = 13;
            // 
            // cboMaMau
            // 
            this.cboMaMau.FormattingEnabled = true;
            this.cboMaMau.Location = new System.Drawing.Point(131, 224);
            this.cboMaMau.Name = "cboMaMau";
            this.cboMaMau.Size = new System.Drawing.Size(207, 30);
            this.cboMaMau.TabIndex = 12;
            // 
            // cboMaCL
            // 
            this.cboMaCL.FormattingEnabled = true;
            this.cboMaCL.Location = new System.Drawing.Point(131, 188);
            this.cboMaCL.Name = "cboMaCL";
            this.cboMaCL.Size = new System.Drawing.Size(207, 30);
            this.cboMaCL.TabIndex = 11;
            // 
            // cboMaCo
            // 
            this.cboMaCo.FormattingEnabled = true;
            this.cboMaCo.Location = new System.Drawing.Point(131, 152);
            this.cboMaCo.Name = "cboMaCo";
            this.cboMaCo.Size = new System.Drawing.Size(207, 30);
            this.cboMaCo.TabIndex = 10;
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(131, 114);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(207, 30);
            this.cboMaLoai.TabIndex = 9;
            // 
            // txtTenGD
            // 
            this.txtTenGD.Location = new System.Drawing.Point(131, 77);
            this.txtTenGD.Name = "txtTenGD";
            this.txtTenGD.Size = new System.Drawing.Size(207, 30);
            this.txtTenGD.TabIndex = 8;
            // 
            // txtMaGD
            // 
            this.txtMaGD.Location = new System.Drawing.Point(131, 40);
            this.txtMaGD.Name = "txtMaGD";
            this.txtMaGD.Size = new System.Drawing.Size(207, 30);
            this.txtMaGD.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã ĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Màu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã CL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Cỡ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên GD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã GD";
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGD,
            this.TenGD,
            this.MaLoai,
            this.MaCo,
            this.MaCL,
            this.MaMau,
            this.MaDT,
            this.MaMua,
            this.MaNSX,
            this.SoLuong,
            this.Anh,
            this.DonGiaNhap,
            this.DonGiaBan});
            this.dataGridView_SanPham.Location = new System.Drawing.Point(86, 441);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowHeadersWidth = 62;
            this.dataGridView_SanPham.RowTemplate.Height = 28;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(971, 223);
            this.dataGridView_SanPham.TabIndex = 2;
            this.dataGridView_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SanPham_CellClick);
            // 
            // MaGD
            // 
            this.MaGD.DataPropertyName = "MaGD";
            this.MaGD.HeaderText = "Mã GD";
            this.MaGD.MinimumWidth = 8;
            this.MaGD.Name = "MaGD";
            // 
            // TenGD
            // 
            this.TenGD.DataPropertyName = "TenGD";
            this.TenGD.HeaderText = "Tên GD";
            this.TenGD.MinimumWidth = 8;
            this.TenGD.Name = "TenGD";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.MinimumWidth = 8;
            this.MaLoai.Name = "MaLoai";
            // 
            // MaCo
            // 
            this.MaCo.DataPropertyName = "MaCo";
            this.MaCo.HeaderText = "Mã Cỡ";
            this.MaCo.MinimumWidth = 8;
            this.MaCo.Name = "MaCo";
            // 
            // MaCL
            // 
            this.MaCL.DataPropertyName = "MaCL";
            this.MaCL.HeaderText = "Mã CL";
            this.MaCL.MinimumWidth = 8;
            this.MaCL.Name = "MaCL";
            // 
            // MaMau
            // 
            this.MaMau.DataPropertyName = "MaMau";
            this.MaMau.HeaderText = "Mã Màu";
            this.MaMau.MinimumWidth = 8;
            this.MaMau.Name = "MaMau";
            // 
            // MaDT
            // 
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.HeaderText = "Mã ĐT";
            this.MaDT.MinimumWidth = 8;
            this.MaDT.Name = "MaDT";
            // 
            // MaMua
            // 
            this.MaMua.DataPropertyName = "MaMua";
            this.MaMua.HeaderText = "Mã Mùa";
            this.MaMua.MinimumWidth = 8;
            this.MaMua.Name = "MaMua";
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã NSX";
            this.MaNSX.MinimumWidth = 8;
            this.MaNSX.Name = "MaNSX";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.MinimumWidth = 8;
            this.Anh.Name = "Anh";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.DonGiaNhap.MinimumWidth = 8;
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá Bán";
            this.DonGiaBan.MinimumWidth = 8;
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHienThiDS);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(86, 691);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Chức Năng";
            // 
            // btnHienThiDS
            // 
            this.btnHienThiDS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHienThiDS.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiDS.Location = new System.Drawing.Point(713, 35);
            this.btnHienThiDS.Name = "btnHienThiDS";
            this.btnHienThiDS.Size = new System.Drawing.Size(146, 41);
            this.btnHienThiDS.TabIndex = 7;
            this.btnHienThiDS.Text = "Hiển Thị DS";
            this.btnHienThiDS.UseVisualStyleBackColor = false;
            this.btnHienThiDS.Click += new System.EventHandler(this.btnHienThiDS_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(573, 34);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 41);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(866, 34);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(458, 35);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 41);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(118, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 41);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(236, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 41);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoas_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(346, 34);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 41);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 795);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView_SanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox PicAnh;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboMaNSX;
        private System.Windows.Forms.ComboBox cboMaMua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMaDT;
        private System.Windows.Forms.ComboBox cboMaMau;
        private System.Windows.Forms.ComboBox cboMaCL;
        private System.Windows.Forms.ComboBox cboMaCo;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.TextBox txtTenGD;
        private System.Windows.Forms.TextBox txtMaGD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.Button btnHienThiDS;
        private System.Windows.Forms.Button btnTimKiem;
    }
}