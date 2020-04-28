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
    public partial class FrmTimKiemSP : Form
    {
        DataTable tblSanPham;
        public FrmTimKiemSP()
        {
            InitializeComponent();
        }

        private void FrmTimKiemSP_Load(object sender, EventArgs e)
        {
            dgvTimKiemSP.DataSource = null;
        }
        private void ResetValues()
        {
            txtAnh.Text = "";
            txtDonGiaBan.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtMaCL.Text = "";
            txtMaCo.Text = "";
            txtMaDT.Text = "";
            txtMaGD.Text = "";
            txtMaLoai.Text = "";
            txtMaMau.Text = "";
            txtMaNSX.Text = "";
            txtSoLuong.Text = "0";
            txt_MaMua.Text = "";
            txtTenGD.Text = "";
            picAnh.Image = null;
            txtMaGD.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaGD.Text == "") && (txtMaCL.Text == "") && (txtMaCo.Text == "") && (txtMaDT.Text == "")
              && (txtMaLoai.Text == "") && (txtMaMau.Text == "") && (txtMaNSX.Text == "") && (txtMaMua.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select *from SanPham where 1=1";
            if (txtMaCL.Text != "")
            {
                sql = sql + " AND MaCL Like '%" + txtMaCL.Text + "%'";
            }
            if (txtMaCo.Text != "")
            {
                sql = sql + " AND MaCo Like '%" + txtMaCo.Text + "%'";
            }
            if (txtMaDT.Text != "")
            {
                sql = sql + " AND MaDT Like '%" + txtMaDT.Text + "%'";
            }
            if (txtMaGD.Text != "")
            {
                sql = sql + " AND MaGD Like '%" + txtMaGD.Text + "%'";
            }
            if (txtMaLoai.Text != "")
            {
                sql = sql + " AND MaLoai Like '%" + txtMaLoai.Text + "%'";
            }
            if (txtMaMau.Text != "")
            {
                sql = sql + " AND MaMau Like '%" + txtMaMau.Text + "%'";
            }
            if (txtMaNSX.Text != "")
            {
                sql = sql + " AND MaNSX Like '%" + txtMaNSX.Text + "%'";
            }
            if (txt_MaMua.Text != "")
            {
                sql = sql + " AND MaMua Like '%" + txtMaMua.Text + "%'";
            }
            tblSanPham = Functions.GetDataToTable(sql);
            if (tblSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblSanPham.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTimKiemSP.DataSource = tblSanPham;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgvTimKiemSP.AllowUserToAddRows = false;
            dgvTimKiemSP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgopen.FilterIndex = 2;
            dlgopen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgopen.FileName);
                txtAnh.Text = dlgopen.FileName;
            }
        }

        private void dgvTimKiemSP_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtAnh.Text = dgvTimKiemSP.CurrentRow.Cells["Anh"].Value.ToString();
                txtDonGiaBan.Text = dgvTimKiemSP.CurrentRow.Cells["DonGiaBan"].Value.ToString();
                txtDonGiaNhap.Text = dgvTimKiemSP.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
                txtMaCL.Text = dgvTimKiemSP.CurrentRow.Cells["MaCL"].Value.ToString();
                txtMaCo.Text = dgvTimKiemSP.CurrentRow.Cells["MaCo"].Value.ToString();
                txtMaDT.Text = dgvTimKiemSP.CurrentRow.Cells["MaDT"].Value.ToString();
                txtMaGD.Text = dgvTimKiemSP.CurrentRow.Cells["MaGD"].Value.ToString();
                txtMaLoai.Text = dgvTimKiemSP.CurrentRow.Cells["MaLoai"].Value.ToString();
                txt_MaMua.Text = dgvTimKiemSP.CurrentRow.Cells["MaMau"].Value.ToString();
                txtMaNSX.Text = dgvTimKiemSP.CurrentRow.Cells["MaNSX"].Value.ToString();
                txtMaMua.Text = dgvTimKiemSP.CurrentRow.Cells["MaMua"].Value.ToString();
                txtSoLuong.Text = dgvTimKiemSP.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtTenGD.Text = dgvTimKiemSP.CurrentRow.Cells["TenGD"].Value.ToString();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKiemSP.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
