namespace CuaHangGiayDep
{
    partial class FrmMua
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMua = new System.Windows.Forms.TextBox();
            this.txtTenMua = new System.Windows.Forms.TextBox();
            this.DataGridView_Mua = new System.Windows.Forms.DataGridView();
            this.MaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Mua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(306, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mùa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Mùa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Mùa";
            // 
            // txtMaMua
            // 
            this.txtMaMua.Location = new System.Drawing.Point(120, 96);
            this.txtMaMua.Name = "txtMaMua";
            this.txtMaMua.Size = new System.Drawing.Size(100, 22);
            this.txtMaMua.TabIndex = 3;
            // 
            // txtTenMua
            // 
            this.txtTenMua.Location = new System.Drawing.Point(548, 93);
            this.txtTenMua.Name = "txtTenMua";
            this.txtTenMua.Size = new System.Drawing.Size(100, 22);
            this.txtTenMua.TabIndex = 4;
            // 
            // DataGridView_Mua
            // 
            this.DataGridView_Mua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Mua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMua,
            this.TenMua});
            this.DataGridView_Mua.Location = new System.Drawing.Point(120, 167);
            this.DataGridView_Mua.Name = "DataGridView_Mua";
            this.DataGridView_Mua.RowHeadersWidth = 51;
            this.DataGridView_Mua.RowTemplate.Height = 24;
            this.DataGridView_Mua.Size = new System.Drawing.Size(465, 150);
            this.DataGridView_Mua.TabIndex = 5;
            this.DataGridView_Mua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Mua_CellClick);
            // 
            // MaMua
            // 
            this.MaMua.DataPropertyName = "MaMua";
            this.MaMua.HeaderText = "Mã Mùa";
            this.MaMua.MinimumWidth = 6;
            this.MaMua.Name = "MaMua";
            this.MaMua.Width = 125;
            // 
            // TenMua
            // 
            this.TenMua.DataPropertyName = "TenMua";
            this.TenMua.HeaderText = "Tên Mùa";
            this.TenMua.MinimumWidth = 6;
            this.TenMua.Name = "TenMua";
            this.TenMua.Width = 125;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(26, 366);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(85, 35);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(156, 364);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 35);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(268, 365);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 34);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(387, 366);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 33);
            this.btn_luu.TabIndex = 9;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(500, 368);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 33);
            this.btn_huy.TabIndex = 10;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(616, 368);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // FrmMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.DataGridView_Mua);
            this.Controls.Add(this.txtTenMua);
            this.Controls.Add(this.txtMaMua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMua";
            this.Text = "FrmMua";
            this.Load += new System.EventHandler(this.FrmMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Mua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMua;
        private System.Windows.Forms.TextBox txtTenMua;
        private System.Windows.Forms.DataGridView DataGridView_Mua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_thoat;
    }
}