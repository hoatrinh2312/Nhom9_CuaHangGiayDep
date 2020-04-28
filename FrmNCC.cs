﻿using System;
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
    public partial class FrmNCC : Form
    {
        DataTable tblNhaCungCap;
        public FrmNCC()
        {
            InitializeComponent();
        }

        private void FrmNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            loadDataToGridview();
        }
        private void loadDataToGridview()
        {
            string sql = "Select * from NhaCungCap";
            tblNhaCungCap = Functions.GetDataToTable(sql);
            dataGridView_NhaCungCap.DataSource = tblNhaCungCap;
        }


        private void ResetValue()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            mskDienThoai.Text = "";
        }

        private void dataGridView_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dataGridView_NhaCungCap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dataGridView_NhaCungCap.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = dataGridView_NhaCungCap.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienThoai.Text = dataGridView_NhaCungCap.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtMaNCC.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaNCC.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("không còn dữ liệu!");
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã NCC");
                txtMaNCC.Focus();
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên NCC");
                txtTenNCC.Focus();
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("bạn chưa nhập địa chỉ");
                txtDiaChi.Focus();
            }
            if (mskDienThoai.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số điện thoại");
                mskDienThoai.Focus();
            }

            sql = "update NhaCungCap set TenNCC = '" + txtTenNCC.Text.ToString() + "', "
                + "DiaChi = '" + txtDiaChi.Text.ToString() + "', " + "DienThoai = '" + mskDienThoai.Text.ToString()
                + "'where MaNCC = '" + txtMaNCC.Text + "'";
            Functions.RunSqlDel(sql);

            loadDataToGridview();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu!");
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản ghi nào ");
            }
            if (MessageBox.Show("Bạn có muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from NhaCungCap where MaNCC= '" + txtMaNCC.Text + "'";
                Functions.RunSqlDel(sql);
                loadDataToGridview();
                ResetValue();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("không còn dữ liệu");
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã NCC");
                txtMaNCC.Focus();

            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên NCC");
                txtTenNCC.Focus();

            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn cần nhập địa chỉ");
                txtDiaChi.Focus();

            }
            if (mskDienThoai.Text == "")
            {
                MessageBox.Show("Bạn cần nhập số điện thoại");
                mskDienThoai.Focus();

            }
            sql = "Select MaNCC from NhaCungCap where MaNCC ='" + txtMaNCC.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("mã NCC này đã có, bạn phai nhập mã khác");
                txtMaNCC.Focus();
                return;
            }
            sql = "insert into NhaCungCap values('" + txtMaNCC.Text + "', '" + txtTenNCC.Text
                + "', '" + txtDiaChi.Text + "', '" + mskDienThoai.Text + "')";
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
            txtMaNCC.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
