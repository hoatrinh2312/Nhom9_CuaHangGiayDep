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
    public partial class frmTheLoai : Form
    {
        DataTable tableTheLoai;

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            txtMaLoai.Enabled = false;
            loatDaTaToGridview();
        }
        private void loatDaTaToGridview()
        {
            string sql = "select *from TheLoai";
            tableTheLoai = Functions.GetDataToTable(sql);
            dataGridView_TheLoai.DataSource = tableTheLoai;
        }
        private void ResetValues()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private void dataGridView_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoai.Text = dataGridView_TheLoai.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtTenLoai.Text = dataGridView_TheLoai.CurrentRow.Cells["TenLoai"].Value.ToString();
            txtMaLoai.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaLoai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Bạn nhập mã loai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoai.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên loai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE TheLoai SET TenLoai='" +
                txtTenLoai.Text.ToString() +
                "' WHERE MaLoai='" + txtMaLoai.Text + "'";
            MessageBox.Show(sql);
            Functions.RunSQL(sql);
            loatDaTaToGridview();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có chắc chắn muốn xóa","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "Delete From TheLoai Where MaLoai= '" + txtMaLoai.Text + "'";
                Functions.RunSqlDel(sql);
                loatDaTaToGridview();
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            txtMaLoai.Enabled = false;
            loatDaTaToGridview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("bạn cần nhập mã loai");
                txtMaLoai.Focus();
                return;
            }
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("bạn cần nhập tên loai");
                txtTenLoai.Focus();
            }
            sql = "select MaLoai From TheLoai Where MaLoai='" + txtMaLoai.Text.Trim() + "'";

            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã loại này đã có, bạn vui lòng nhập mã khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                txtMaLoai.Text = "";
                return;
            }
            else
            {

                sql = "insert into TheLoai values ('" + txtMaLoai.Text + "','" + txtTenLoai.Text + "')";

                MessageBox.Show(sql);
                Functions.RunSqlDel(sql);
                loatDaTaToGridview();
                ResetValues();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
