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

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap DM_NCC = new FrmNhaCungCap();
            DM_NCC.ShowDialog();
        }

        private void mnuDoiTuong_Click(object sender, EventArgs e)
        {
            FrmDoiTuong DM_DT = new FrmDoiTuong();
            DM_DT.ShowDialog();
        }

        private void mnuNuocSX_Click(object sender, EventArgs e)
        {
            FrmNuocSX DM_NSX = new FrmNuocSX();
            DM_NSX.ShowDialog();
        }

        private void mnuMau_Click(object sender, EventArgs e)
        {
            FrmMau DM_Mau = new FrmMau();
            DM_Mau.ShowDialog();
        }

        private void mnuSPTK_Click(object sender, EventArgs e)
        {
            FrmBaoCaoHangTonKho DM_BC = new FrmBaoCaoHangTonKho();
            DM_BC.ShowDialog();
        }
    }
}