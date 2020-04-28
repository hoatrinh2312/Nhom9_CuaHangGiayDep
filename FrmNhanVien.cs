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
    public partial class FrmNhanVien : Form
    {
        DataTable tblNhanVien;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            loadDataToGridview();
            Functions.FillCombo("select MaCV,TenCV from CongViec", cboMaCV, "MaCV", "TenCV");
            cboMaCV.SelectedIndex = -1;
        }
        private void loadDataToGridview()
        {
            string sql = "select *from NhanVien";
            tblNhanVien = Functions.GetDataToTable(sql);
            DataGridView_NhanVien.DataSource = tblNhanVien;

        }

        private void DataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaCV;
            txtMaNV.Text = DataGridView_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = DataGridView_NhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (DataGridView_NhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkGioiTinh.Checked = true;
            else chkGioiTinh.Checked = false;
            dtpNgaySinh.Text = DataGridView_NhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            mskDienThoai.Text = DataGridView_NhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtDiaChi.Text = DataGridView_NhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            MaCV = DataGridView_NhanVien.CurrentRow.Cells["MaCV"].Value.ToString();

            cboMaCV.Text = Functions.GetFieldValues("select TenCV from CongViec where MaCV='" + MaCV + "'");
            txtMaNV.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            mskDienThoai.Text = "";
            cboMaCV.Text = "";
            dtpNgaySinh.Text = "";
            chkGioiTinh.Checked = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            ResetValue();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienThoai.Focus();
                return;
            }
            if (cboMaCV.Text == "")
            {
                MessageBox.Show("bạn nhập mã cv", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaCV.Focus();
                return;
            }
            if (dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE NhanVien SET  TenNV=N'" + txtTenNV.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtDiaChi.Text.Trim().ToString() +
                    "',DienThoai='" + mskDienThoai.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',NgaySinh='" + Functions.ConvertDateTime(dtpNgaySinh.Text) +
                    "' WHERE MaNV=N'" + txtMaNV.Text + "'";
            Functions.RunSQL(sql);
            loadDataToGridview();
            ResetValue();
            btn_huy.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu");
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("ban chua chon ma nhan vien");
            }
            if (MessageBox.Show("ban muon xoa khong", "thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from NhanVien where MaNV ='" + txtMaNV.Text + "'";
                Functions.RunSQL(sql);
                loadDataToGridview();
                ResetValue();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu");
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("nhap ma nhan vien");
                txtMaNV.Focus();

            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("nhap ten nhan vien");
                txtTenNV.Focus();
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("nhap dia chi");
                txtDiaChi.Focus();

            }
            if (cboMaCV.Text == "")
            {
                MessageBox.Show("nhap mã công việc");
                cboMaCV.Focus();

            }
            if (mskDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienThoai.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            

            sql = "select MaNV from NhanVien where MaNV ='" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("ma nay da co, ban nhap ma khac");
                txtMaNV.Focus();
                return;
            }
            sql = "INSERT INTO NhanVien(MaNV,TenNV,GioiTinh, DiaChi,DienThoai, NgaySinh, MaCV) " +
                "VALUES (N'" + txtMaNV.Text.Trim() + "',N'" + txtTenNV.Text.Trim() + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "','" +
                mskDienThoai.Text + "','" + Functions.ConvertDateTime(dtpNgaySinh.Text) + "', '" + cboMaCV.SelectedValue.ToString() + "')";
            Functions.RunSQL(sql);
            loadDataToGridview();
            ResetValue();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaNV.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
