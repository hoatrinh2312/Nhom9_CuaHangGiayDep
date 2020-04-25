namespace CuaHangGiayDep
{
    partial class FrmChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiTetHDB = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHĐBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimHĐN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDSHĐB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(982, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCo,
            this.mnuChatLieu,
            this.mnuMua,
            this.mnuKhach,
            this.mnuNhanVien});
            this.mnuDanhMuc.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(115, 31);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuCo
            // 
            this.mnuCo.Name = "mnuCo";
            this.mnuCo.Size = new System.Drawing.Size(190, 30);
            this.mnuCo.Text = "Cỡ";
            // 
            // mnuChatLieu
            // 
            this.mnuChatLieu.Name = "mnuChatLieu";
            this.mnuChatLieu.Size = new System.Drawing.Size(190, 30);
            this.mnuChatLieu.Text = "Chất liệu";
            // 
            // mnuMua
            // 
            this.mnuMua.Name = "mnuMua";
            this.mnuMua.Size = new System.Drawing.Size(190, 30);
            this.mnuMua.Text = "Mùa";
            this.mnuMua.Click += new System.EventHandler(this.mnuMua_Click);
            // 
            // mnuKhach
            // 
            this.mnuKhach.Name = "mnuKhach";
            this.mnuKhach.Size = new System.Drawing.Size(190, 30);
            this.mnuKhach.Text = "Khách ";
            this.mnuKhach.Click += new System.EventHandler(this.mnuKhach_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(190, 30);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHDB,
            this.mnuChiTetHDB});
            this.mnuHoaDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(109, 31);
            this.mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuHDB
            // 
            this.mnuHDB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHDB.Name = "mnuHDB";
            this.mnuHDB.Size = new System.Drawing.Size(184, 26);
            this.mnuHDB.Text = "Hóa đơn bán ";
            // 
            // mnuChiTetHDB
            // 
            this.mnuChiTetHDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem});
            this.mnuChiTetHDB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChiTetHDB.Name = "mnuChiTetHDB";
            this.mnuChiTetHDB.ShowShortcutKeys = false;
            this.mnuChiTetHDB.Size = new System.Drawing.Size(184, 26);
            this.mnuChiTetHDB.Text = "Hóa đơn nhập";
            // 
            // chiTiếtHóaĐơnNhậpToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem.Name = "chiTiếtHóaĐơnNhậpToolStripMenuItem";
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem.Text = "Chi tiết hóa đơn nhập";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmHĐBToolStripMenuItem,
            this.mnuTimHĐN});
            this.mnuTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(117, 31);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // tìmKiếmHĐBToolStripMenuItem
            // 
            this.tìmKiếmHĐBToolStripMenuItem.Name = "tìmKiếmHĐBToolStripMenuItem";
            this.tìmKiếmHĐBToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.tìmKiếmHĐBToolStripMenuItem.Text = "Tìm kiếm HĐB";
            // 
            // mnuTimHĐN
            // 
            this.mnuTimHĐN.Name = "mnuTimHĐN";
            this.mnuTimHĐN.Size = new System.Drawing.Size(246, 32);
            this.mnuTimHĐN.Text = "Tìm kiếm HĐN";
            this.mnuTimHĐN.Click += new System.EventHandler(this.mnuTimHĐN_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCDSHĐB});
            this.mnuBaoCao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(111, 31);
            this.mnuBaoCao.Text = "Báo cáo ";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(82, 31);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuBCDSHĐB
            // 
            this.mnuBCDSHĐB.Name = "mnuBCDSHĐB";
            this.mnuBCDSHĐB.Size = new System.Drawing.Size(268, 32);
            this.mnuBCDSHĐB.Text = "Báo cáo DS HĐB";
            this.mnuBCDSHĐB.Click += new System.EventHandler(this.mnuBCDSHĐB_Click);
            // 
            // FrmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmChinh";
            this.Text = "Chương trình quản lý cửa hàng bán giày dép";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuCo;
        private System.Windows.Forms.ToolStripMenuItem mnuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHDB;
        private System.Windows.Forms.ToolStripMenuItem mnuChiTetHDB;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHĐBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMua;
        private System.Windows.Forms.ToolStripMenuItem mnuKhach;
        private System.Windows.Forms.ToolStripMenuItem mnuTimHĐN;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDSHĐB;
    }
}

