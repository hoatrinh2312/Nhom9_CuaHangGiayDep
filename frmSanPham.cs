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
    public partial class frmSanPham : Form
    {
        DataTable tableSanPham;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaGD.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            Functions.FillCombo("select MaCL,TenCL from ChatLieu", cboMaCL, "MaCL", "TenCL");
            cboMaCL.SelectedIndex = -1;
            Functions.FillCombo("select MaMau,TenMau From Mau", cboMaMau, "MaMau", "TenMau");
            cboMaMau.SelectedIndex = -1;
            Functions.FillCombo("select MaCo,TenCo From Co", cboMaCo, "MaCo", "TenCo");
            cboMaCo.SelectedIndex = -1;
            Functions.FillCombo("select MaDT,TenDT From DoiTuong", cboMaDT, "MaDT", "TenDT");
            cboMaDT.SelectedIndex = -1;
            Functions.FillCombo("select MaLoai,TenLoai From TheLoai", cboMaLoai, "MaLoai", "TenLoai");
            cboMaLoai.SelectedIndex = -1;
            Functions.FillCombo("select MaNSX,TenNSX From NuocSX", cboMaNSX, "MaNSX", "TenNSX");
            cboMaNSX.SelectedIndex = -1;
            Functions.FillCombo("select MaMua,TenMua From Mua", cboMaMua, "MaMua", "TenMua");
            cboMaMua.SelectedIndex = -1;

            loatDaTaToGridview();
            ResetValues();
        }
        private void loatDaTaToGridview()
        {
            string sql = "select *from SanPham";
            tableSanPham = Functions.GetDataToTable(sql);

            dataGridView_SanPham.DataSource = tableSanPham;

        }
        private void ResetValues()
        {
            txtMaGD.Text = "";
            txtTenGD.Text = "";
            cboMaCL.Text = "";
            cboMaCo.Text = "";
            cboMaDT.Text = "";
            cboMaMua.Text = "";
            cboMaMau.Text = "";
            cboMaNSX.Text = "";
            cboMaLoai.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtSoLuong.Enabled = true;
            //txtDonGiaNhap.Enabled = false;
           // txtDonGiaBan.Enabled = false;
            txtAnh.Text = "";
            PicAnh.Image = null;

        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaCo, MaMua, MaMau, MaDT, MaCL, MaNSX, MaLoai;
            txtMaGD.Text = dataGridView_SanPham.CurrentRow.Cells["MaGD"].Value.ToString();
            txtTenGD.Text = dataGridView_SanPham.CurrentRow.Cells["TenGD"].Value.ToString();
            MaLoai = dataGridView_SanPham.CurrentRow.Cells["MaLoai"].Value.ToString();
            cboMaLoai.Text = Functions.GetFieldValues("select TenLoai from TheLoai where MaLoai='" + MaLoai + "'");
            MaCo = dataGridView_SanPham.CurrentRow.Cells["MaCo"].Value.ToString();
            cboMaCo.Text = Functions.GetFieldValues("select TenCo From Co Where MaCo='" + MaCo + "'");
            MaMau = dataGridView_SanPham.CurrentRow.Cells["MaMau"].Value.ToString();
            cboMaMau.Text = Functions.GetFieldValues("Select TenMau From Mau Where MaMau='" + MaMau + "'");
            MaMua = dataGridView_SanPham.CurrentRow.Cells["MaMua"].Value.ToString();
            cboMaMua.Text = Functions.GetFieldValues("select TenMua From Mua Where MaMua='" + MaMua + "'");
            MaCL = dataGridView_SanPham.CurrentRow.Cells["MaCL"].Value.ToString();
            cboMaCL.Text = Functions.GetFieldValues("select TenCL From ChatLieu Where MaCL='" + MaCL + "'");
            MaDT = dataGridView_SanPham.CurrentRow.Cells["MaDT"].Value.ToString();
            cboMaDT.Text = Functions.GetFieldValues("select TenDT From DoiTuong Where MaDT='" + MaDT + "'");
            MaNSX = dataGridView_SanPham.CurrentRow.Cells["MaNSX"].Value.ToString();
            cboMaNSX.Text = Functions.GetFieldValues("select TenNSX From NuocSX Where MaNSX='" + MaNSX + "'");
            txtSoLuong.Text = dataGridView_SanPham.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtAnh.Text = dataGridView_SanPham.CurrentRow.Cells["Anh"].Value.ToString();
            txtAnh.Text = Functions.GetFieldValues("Select Anh From SanPham Where Anh='" + txtAnh.Text + "'");
            PicAnh.Image = Image.FromFile(txtAnh.Text);
            txtDonGiaNhap.Text = dataGridView_SanPham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dataGridView_SanPham.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtMaGD.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                PicAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("bạn đang nhập sai dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("bạn đang nhập sai dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("bạn đang nhập sai dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaGD.Enabled = true;
            txtMaGD.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled =true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tableSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGD.Focus();
                return;
            }
            if (txtTenGD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGD.Focus();
                return;
            }
            if (cboMaCL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCL.Focus();
                return;
            }
            if (cboMaDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaDT.Focus();
                return;
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoai.Focus();
                return;
            }
            if (cboMaMau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMau.Focus();
                return;
            }
            if (cboMaMua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMua.Focus();
                return;
            }
            if (cboMaNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNSX.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE SanPham SET TenGD='" + txtTenGD.Text +
                "',MaCL='" + cboMaCL.SelectedValue.ToString() + "',MaCo='" + cboMaCo.SelectedValue.ToString() +
               "',MaLoai='" + cboMaLoai.SelectedValue.ToString()

               + "',MaMau='" + cboMaMau.SelectedValue.ToString() + "',MaMua='" + cboMaMua.SelectedValue.ToString() + "',MaNSX='" + cboMaNSX.SelectedValue.ToString()
               + "',MaDT='" + cboMaDT.SelectedValue.ToString() +
                "',SoLuong='" + txtSoLuong.Text +
                "',Anh='" + txtAnh.Text + "' WHERE MaGD='" + txtMaGD.Text + "'";
            Functions.RunSQL(sql);
            loatDaTaToGridview();
            ResetValues();
            btnHuy.Enabled = false;
        }

        private void btnXoas_Click(object sender, EventArgs e)
        {
            string sql;
            if (tableSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE SanPham WHERE MaGD='" + txtMaGD.Text + "'";
                Functions.RunSqlDel(sql);
                loatDaTaToGridview();
                ResetValues();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaGD.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaGD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGD.Focus();
                return;
            }
            if (txtTenGD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGD.Focus();
                return;
            }
            if (cboMaCL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCL.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            if (cboMaCo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCo.Focus();
            }
            if (cboMaDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaDT.Focus();
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoai.Focus();
            }
            if (cboMaMau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMau.Focus();
            }
            if (cboMaMua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMua.Focus();
            }
            if (cboMaNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNSX.Focus();
            }

           
            sql = "select MaGD From SanPham Where MaGD='" + txtMaGD.Text.Trim() + "'";

            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Giày dép này đã có, bạn vui lòng nhập mã khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGD.Focus();
                return;
            }

            sql = "INSERT INTO SanPham(MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaDT,MaMua,MaNSX,SoLuong,DonGiaNhap, DonGiaBan,Anh) VALUES('" + txtMaGD.Text.Trim() + "','" + txtTenGD.Text.Trim() + "','" + cboMaLoai.SelectedValue.ToString() +
                "','" + cboMaCo.SelectedValue.ToString() +
                "','" + cboMaCL.SelectedValue.ToString()
                + "','" + cboMaMau.SelectedValue.ToString() + "','" + cboMaDT.SelectedValue.ToString() + "','" + cboMaMua.SelectedValue.ToString() + "','" + cboMaNSX.SelectedValue.ToString()
                + "','" + txtSoLuong.Text.Trim() + "','" + txtDonGiaNhap.Text + "','" + txtDonGiaBan.Text + "','" + txtAnh.Text + "')";

            Functions.RunSQL(sql);
            loatDaTaToGridview();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaGD.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            
                Application.Exit();
            
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            double dgn, dgb;
            if (txtDonGiaNhap.Text == "")
                dgn = 0;
            else
                dgn = Convert.ToDouble(txtDonGiaNhap.Text);
            dgb = dgn * 1.1;
            txtDonGiaBan.Text = dgb.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaGD.Text == "") && (txtTenGD.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaGD.Text == "" && txtTenGD.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điều kiệm tìm kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGD.Focus();
                return;
            }
            sql = "SELECT * from SanPham WHERE 1=1";
            if (txtMaGD.Text != "")
                sql += " AND MaGD LIKE '%" + txtMaGD.Text + "%'";
            if (txtTenGD.Text != "")
                sql += " AND TenGD LIKE '%" + txtTenGD.Text + "%'";

            tableSanPham = Functions.GetDataToTable(sql);
            if (tableSanPham.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tableSanPham.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView_SanPham.DataSource = tableSanPham;
            ResetValues();
        }

        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            loatDaTaToGridview();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
