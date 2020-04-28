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
    public partial class FrmMau : Form
    {
        DataTable tblMau;
        public FrmMau()
        {
            InitializeComponent();
        }

        private void FrmMau_Load(object sender, EventArgs e)
        {
            txtMaMau.Enabled = false;
            loadDataToGridview();

        }
        private void loadDataToGridview()
        {
            string sql = "Select * from Mau";
            tblMau = Functions.GetDataToTable(sql);
            dataGridView_Mau.DataSource = tblMau;
        }

        private void dataGridView_Mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMau.Text = dataGridView_Mau.CurrentRow.Cells["MaMau"].Value.ToString();
            txtTenMau.Text = dataGridView_Mau.CurrentRow.Cells["TenMau"].Value.ToString();
            txtMaMau.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaMau.Text = "";
            txtTenMau.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaMau.Enabled = true;
            txtMaMau.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("không còn dữ liệu!");
            }
            if (txtMaMau.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã màu");
                txtMaMau.Focus();
            }
            if (txtTenMau.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên màu");
                txtTenMau.Focus();
            }
            sql = "update Mau set TenMau = '" + txtTenMau.Text
                + "'where MaMau = '" + txtMaMau.Text + "'";
            Functions.RunSqlDel(sql);

            loadDataToGridview();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu!");
            }
            if (txtMaMau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào ");
            }
            if (MessageBox.Show("Bạn có muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from Mau where MaMau= '" + txtMaMau.Text + "'";
                Functions.RunSqlDel(sql);
                loadDataToGridview();
                ResetValue();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("không còn dữ liệu");
                return;
            }
            if (txtMaMau.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã màu");
                txtMaMau.Focus();

            }
            if (txtTenMau.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên màu");
                txtTenMau.Focus();

            }

            sql = "Select MaMau from Mau where MaMau ='" + txtMaMau.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("mã màu này đã có, bạn phai nhập mã khác");
                txtMaMau.Focus();
                return;
            }
            sql = "insert into Mau values('" + txtMaMau.Text + "', '" + txtTenMau.Text + "')";
            Functions.RunSqlDel(sql);
            loadDataToGridview();
            ResetValue();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaMau.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
