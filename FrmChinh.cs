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

        private void mnuCo_Click(object sender, EventArgs e)
        {
            FrmCo DM_Co = new FrmCo();
            DM_Co.ShowDialog();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            FrmChatLieu Dm_Cl = new FrmChatLieu();
            Dm_Cl.ShowDialog();
        }

        private void mnuHDB_Click(object sender, EventArgs e)
        {
            FrmHDB HDB = new FrmHDB();
            HDB.ShowDialog();
        }

        

        private void mnuBaoCaoKH_Click(object sender, EventArgs e)
        {
            FrmBC_Top3KH baocao = new FrmBC_Top3KH();
            baocao.ShowDialog();
        }

        private void munHDN_Click(object sender, EventArgs e)
        {
            FrmHDN hoadonnhap = new FrmHDN();
            hoadonnhap.ShowDialog();
        }

        private void mnuMua_Click(object sender, EventArgs e)
        {
            FrmMua DM_mua = new FrmMua();
            DM_mua.ShowDialog();
        }

        private void munMau_Click(object sender, EventArgs e)
        {
            FrmMau DM_mau = new FrmMau();
            DM_mau.ShowDialog();
        }

        private void mnuDT_Click(object sender, EventArgs e)
        {
            FrmDoiTuong doituong = new FrmDoiTuong();
            doituong.ShowDialog();
        }

        private void munCL_Click(object sender, EventArgs e)
        {
            FrmChatLieu chatlieu = new FrmChatLieu();
            chatlieu.ShowDialog();

        }

        private void mnuNhaCC_Click(object sender, EventArgs e)
        {
            FrmNCC nhacc = new FrmNCC();
            nhacc.ShowDialog();
        }

        private void mnuNSX_Click(object sender, EventArgs e)
        {
            FrmNSX nuocsx = new FrmNSX();
            nuocsx.ShowDialog();
        }

        private void munNV_Click(object sender, EventArgs e)
        {
            FrmNhanVien nhanvien = new FrmNhanVien();
            nhanvien.ShowDialog();
        }

        private void mnuKhach_Click(object sender, EventArgs e)
        {
            FrmKhach khach = new FrmKhach();
            khach.ShowDialog();
        }

        private void mnuTimKiemHĐB_Click(object sender, EventArgs e)
        {
            FrmTimKiemHDB timkiem_HDB = new FrmTimKiemHDB();
            timkiem_HDB.ShowDialog();
        }

        private void mnuTimKiem_SP_Click(object sender, EventArgs e)
        {
            FrmTimKiemSP timkiem_SP = new FrmTimKiemSP();
            timkiem_SP.ShowDialog();
        }

        private void mnuTimKiemHDN_Click(object sender, EventArgs e)
        {
            FrmTimKiemHĐN timkiem_HĐN = new FrmTimKiemHĐN();
            timkiem_HĐN.ShowDialog();
        }

        private void hàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBC_HangTonKho BC_hangtonkho = new FrmBC_HangTonKho();
            BC_hangtonkho.ShowDialog();
        }

        private void danhSáchHĐBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCDSHoaDonBan DS_HĐB = new FrmBCDSHoaDonBan();
            DS_HĐB.ShowDialog();
        }
    }
}