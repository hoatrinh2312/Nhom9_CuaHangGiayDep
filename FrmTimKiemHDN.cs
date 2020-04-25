using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuaHangGiayDep
{
    public partial class FrmTimKiemHDN : Form
    {
        DataTable tblTimHĐN;
        public FrmTimKiemHDN()
        {
            InitializeComponent();
        }

        private void FrmTimKiemHDN_Load(object sender, EventArgs e)
        {
            DataGridView_TimHĐN.DataSource = null;
        }
        private void loadDataGridView()
        {
            DataGridView_TimHĐN.AllowUserToAddRows = false;
            DataGridView_TimHĐN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_TimHĐN_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn hiển thị thông tin chi tiết?", "xác nhận",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                txtSoHDN.Text = DataGridView_TimHĐN.CurrentRow.Cells["SoHDN"].Value.ToString();
                txtMaNV.Text = DataGridView_TimHĐN.CurrentRow.Cells["MaNV"].Value.ToString();
                txtMaNCC.Text = DataGridView_TimHĐN.CurrentRow.Cells["MaNCC"].Value.ToString();
                txtMaGD.Text = DataGridView_TimHĐN.CurrentRow.Cells["MaGD"].Value.ToString();
                txtTongTien.Text = DataGridView_TimHĐN.CurrentRow.Cells["TongTien"].Value.ToString();
                dtpNgayNhap.Text = DataGridView_TimHĐN.CurrentRow.Cells["NgayNhap"].Value.ToString();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaNV.Text == "") && (txtMaNCC.Text == "") && (txtMaGD.Text == ""))
            {
                MessageBox.Show("nhập một điều kiện tìm kiếm", "yêu cầu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.MaNV,a.SoHDN,a.MaNCC, a.NgayNhap, a.TongTien, b.MaGD from HoaDonNhap as a join ChiTietHDN as b on a.SoHDN= b.SoHDN where 1=1";
            if (txtMaNV.Text != "")
            {
                sql = sql + "and MaNV ='" + txtMaNV.Text + "'";
            }

            if (txtMaNCC.Text != "")
            {
                sql = sql + "and MaNCC ='" + txtMaNCC.Text + "'";
            }

            if (txtMaGD.Text != "")
            {
                sql = sql + "and b.MaGD ='" + txtMaGD.Text + "'";
            }
            tblTimHĐN = Functions.GetDataToTable(sql);
            if (tblTimHĐN.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thỏa mãn điều kiện", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("có" + tblTimHĐN.Rows.Count + "bản ghi thỏa mãn điều kiện", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridView_TimHĐN.DataSource = tblTimHĐN;
            loadDataGridView();
        }
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtMaNCC.Text = "";
            txtMaGD.Text = "";
            txtSoHDN.Text = "";
            txtTongTien.Text = "";
            dtpNgayNhap.Text = "";
            txtMaNV.Focus();
            
        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView_TimHĐN.DataSource = null;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }


}
















