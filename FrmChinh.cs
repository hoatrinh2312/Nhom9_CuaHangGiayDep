using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CuaHangGiayDep
{
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Connection();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoai DM_TL = new frmTheLoai();
            DM_TL.ShowDialog();
        }

        private void mnuCongViec_Click(object sender, EventArgs e)
        {
            frmCongViec DM_CV = new frmCongViec();
            DM_CV.ShowDialog();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham DM_SP = new frmSanPham();
            DM_SP.ShowDialog();
        }

        private void danhSáchHĐNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoHDN DM_BC = new frmBaoCaoHDN();
            DM_BC.ShowDialog();
        }

        private void mnuChiTietHDN_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhap HD_HDN = new FrmHoaDonNhap();
            HD_HDN.ShowDialog();
        }

        private void mnuTKSP_Click(object sender, EventArgs e)
        {
            FrmTKSanPham TK_SP = new FrmTKSanPham();
            TK_SP.ShowDialog();
        }
    }
}