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
    public partial class FrmTimKiemHDB : Form
    {
        DataTable tblHDB;
        public FrmTimKiemHDB()
        {
            InitializeComponent();
        }

        private void FrmTimKiemHDB_Load(object sender, EventArgs e)
        {
            dataGridView_TimHDB.DataSource = null;
        }
        private void loadDataGridView()
        {
            dataGridView_TimHDB.AllowUserToAddRows = false;
            dataGridView_TimHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView_TimHDB_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                txtSoHDB.Text = dataGridView_TimHDB.CurrentRow.Cells["SoHDB"].Value.ToString();
                txtMaNV.Text = dataGridView_TimHDB.CurrentRow.Cells["MaNV"].Value.ToString();
                txtMaKhach.Text = dataGridView_TimHDB.CurrentRow.Cells["MaKhach"].Value.ToString();
                txtTongTien.Text = dataGridView_TimHDB.CurrentRow.Cells["TongTien"].Value.ToString();
                dtpNgayBan.Text = dataGridView_TimHDB.CurrentRow.Cells["NgayBan"].Value.ToString();
                txtMaGD.Text = dataGridView_TimHDB.CurrentRow.Cells["MaGD"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaNV.Text == "") && (txtMaKhach.Text == "") && (txtMaGD.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.SoHDB,a.MaNV,a.NgayBan,a.MaKhach,a.TongTien,b.MaGD from HoaDonBan as a join ChiTietHDB as b on a.SoHDB=b.SoHDB  where 1=1";
            if (txtMaNV.Text != "")
            {
                sql = sql + " AND MaNV Like '%" + txtMaNV.Text + "%'";
            }
            if (txtMaKhach.Text != "")
            {
                sql = sql + " and MaKhach Like '%" + txtMaKhach.Text + "%'";
            }
            if (txtMaGD.Text != "")
            {
                sql = sql + "and b.MaGD Like'%" + txtMaGD.Text + "%'";

            }
            tblHDB = Functions.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView_TimHDB.DataSource = tblHDB;
            loadDataGridView();
        }
        private void ResetValues()
        {
            txtMaKhach.Text = "";
            txtMaNV.Text = "";
            txtSoHDB.Text = "";
            txtTongTien.Text = "";
            dtpNgayBan.Text = "";
            txtMaGD.Text = "";
            txtMaNV.Focus();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView_TimHDB.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
