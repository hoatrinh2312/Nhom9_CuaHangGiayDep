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
    public partial class FrmKhach : Form
    {
        DataTable tblKhach;
        public FrmKhach()
        {
            InitializeComponent();
        }

        private void FrmKhach_Load(object sender, EventArgs e)
        {
            txtMaKhach.Enabled = false;
            loadDataToGridview();
        }
        private void loadDataToGridview()
        {
            string sql = "select * from Khach";
            tblKhach = Functions.GetDataToTable(sql);
            DataGridView_Khach.DataSource = tblKhach;

        }

        private void DataGridView_Khach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = DataGridView_Khach.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtTenKhach.Text = DataGridView_Khach.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtDiaChi.Text = DataGridView_Khach.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienThoai.Text = DataGridView_Khach.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtMaKhach.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            mskDienThoai.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            ResetValue();
            txtMaKhach.Enabled = true;
            txtMaKhach.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhach.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu");
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show(" Bạn chưa chọn mã khách nào", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTenKhach.Focus();

            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();

            }
            if (mskDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienThoai.Focus();

            }

            sql = " UPDATE Khach SET TenKhach =  '" + txtTenKhach.Text.ToString() +
            " ',DiaChi='" + txtDiaChi.Text.Trim().ToString() + "',DienThoai='" + mskDienThoai.Text.Trim().ToString() +
            " 'WHERE MaKhach='" + txtMaKhach.Text + "'";

            Functions.RunSqlDel(sql);
            loadDataToGridview();
            ResetValue();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhach.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu");
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("chua chon ma khach");
            }
            if (MessageBox.Show("ban co muon xoa khong", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from Khach where MaKhach = '" + txtMaKhach.Text + "'";
                Functions.RunSqlDel(sql);
                loadDataToGridview();
                ResetValue();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhach.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu");
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("nhap ma khách");
                txtMaKhach.Focus();

            }
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("nhap ten khách");
                txtTenKhach.Focus();
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("nhap dia chi");
                txtDiaChi.Focus();
            }
            if (mskDienThoai.Text == "")
            {
                MessageBox.Show("nhap dien thoai");
                mskDienThoai.Focus();
            }
            sql = "select MaKhach from Khach where MaKhach='" + txtMaKhach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("ma nay da co, ban nhap ma khac");
                txtMaKhach.Focus();
                return;
            }
            sql = "insert into Khach values('" + txtMaKhach.Text + "','" + txtTenKhach.Text + "','" + txtDiaChi.Text + "','" + mskDienThoai.Text + "')";
            Functions.RunSqlDel(sql);
            loadDataToGridview();
            ResetValue();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaKhach.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
