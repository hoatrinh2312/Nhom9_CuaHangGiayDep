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
    public partial class FrmChatLieu : Form
    {
        DataTable tblChatLieu;
        public FrmChatLieu()
        {
            InitializeComponent();
        }

        private void FrmChatLieu_Load(object sender, EventArgs e)
        {
            txtMaCL.Enabled = false;
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string sql = "Select* From ChatLieu";
            tblChatLieu = Functions.GetDataToTable(sql);
            dataGridView_CL.DataSource = tblChatLieu;
        }

        private void dataGridView_CL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCL.Text = dataGridView_CL.CurrentRow.Cells["MaCL"].Value.ToString();
            txtTenCL.Text = dataGridView_CL.CurrentRow.Cells["TenCL"].Value.ToString();
            txtMaCL.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaCL.Text = "";
            txtTenCL.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaCL.Enabled = true;
            txtMaCL.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblChatLieu.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu!!");
            }
            if (txtMaCL.Text == "")
            {
                MessageBox.Show("bạn chua nhập mã chất liệu");
                txtMaCL.Focus();

            }
            if (txtTenCL.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên chất liệu");
                txtTenCL.Focus();
            }
            sql = " update ChatLieu set MaCL='" + txtMaCL.Text + "', TenCL='" + txtTenCL.Text + "'";
            Functions.RunSqlDel(sql);
            loadDataGridView();
            ResetValue();
            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblChatLieu.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu!!");
            }
            if (txtMaCL.Text == "")
            {
                MessageBox.Show("bạn chưa có bản ghi nào.");
            }
            if (MessageBox.Show("bạn có muốn xóa dữ liệu không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from ChatLieu where MaCL='" + txtMaCL.Text + "'";
                Functions.RunSqlDel(sql);
                loadDataGridView();
                ResetValue();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaCL.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblChatLieu.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu");
            }
            if (txtMaCL.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã chất liệu");
                txtMaCL.Focus();
            }
            if (txtTenCL.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên chất liệu.");
                txtTenCL.Focus();
            }
            sql = "Select MaCL from ChatLieu where MaCL='" + txtMaCL.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác!!");
                txtMaCL.Focus();
            }
            sql = "insert into ChatLieu values('" + txtMaCL.Text + "' , '" + txtTenCL.Text + "'";
            Functions.RunSqlDel(sql);
            loadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
