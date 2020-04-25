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
    public partial class FrmCo : Form
    {
        DataTable tblCo;
        public FrmCo()
        {
            InitializeComponent();
        }

        private void FrmCo_Load(object sender, EventArgs e)
        {
            txtMaCo.Enabled = false;
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            string sql = "Select * from Co";
            tblCo = Functions.GetDataToTable(sql);
            DataGridView_Co.DataSource = tblCo;
        }

        private void DataGridView_Co_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCo.Text = DataGridView_Co.CurrentRow.Cells["MaCo"].Value.ToString();
            txtTenCo.Text = DataGridView_Co.CurrentRow.Cells["TenCo"].Value.ToString();
            txtMaCo.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaCo.Text = "";
            txtTenCo.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaCo.Enabled = true;
            txtMaCo.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCo.Rows.Count == 0)
            {
                MessageBox.Show("không còn dữ liệu!!");

            }
            if (txtMaCo.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã cỡ");
                txtMaCo.Focus();
            }
            if (txtTenCo.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên cỡ");
                txtTenCo.Focus();
            }
            sql = "update Co set TenCo='" + txtTenCo.Text + "' where MaCo ='" + txtMaCo.Text + "'";
            Functions.RunSqlDel(sql);
            loadDataGridView();
            ResetValue();
            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCo.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu!");
            }
            if (txtMaCo.Text == "")
            {
                MessageBox.Show("bạn chưa chọn bản ghi nào.");
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from Co where MaCo= '" + txtMaCo.Text + "'";
                Functions.RunSqlDel(sql);
                loadDataGridView();
                ResetValue();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCo.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu!!");
                return;
            }
            if (txtMaCo.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã cỡ");
                txtMaCo.Focus();
            }
            if (txtTenCo.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên cỡ");
                txtTenCo.Focus();
            }
            sql = "Select MaCo from Co where MaCo ='" + txtMaCo.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã cỡ này đã có, bạn phải nhập mã khác");
                txtMaCo.Focus();
                return;
            }
            sql = "insert into Co values( '" + txtMaCo.Text + "' ,'" + txtTenCo.Text + "')";
            Functions.RunSqlDel(sql);
            loadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaCo.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaCo.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

    }
    }
    

