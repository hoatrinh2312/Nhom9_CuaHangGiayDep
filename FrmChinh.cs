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

        private void mnuMua_Click(object sender, EventArgs e)
        {
            FrmMua DM_Mua = new FrmMua();
            DM_Mua.ShowDialog();
        }

        private void mnuKhach_Click(object sender, EventArgs e)
        {
            FrmKhachHang DM_K = new FrmKhachHang();
            DM_K.ShowDialog();
        }

        private void mnuTimHĐN_Click(object sender, EventArgs e)
        {
            FrmTimKiemHDN DM_TimHĐN = new FrmTimKiemHDN();
            DM_TimHĐN.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien DM_NV = new FrmNhanVien();
            DM_NV.ShowDialog();
        }

        private void mnuBCDSHĐB_Click(object sender, EventArgs e)
        {
            FrmBCDSHoaĐonBan DM_BCHĐB = new FrmBCDSHoaĐonBan();
            DM_BCHĐB.ShowDialog();
        }
    }
}