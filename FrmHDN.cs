using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace CuaHangGiayDep
{
    public partial class FrmHDN : Form
    {
        DataTable tblCTHDN;
        public FrmHDN()
        {
            InitializeComponent();
        }

        private void FrmHDN_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
            txtSoHDN.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtThanhTien.Enabled = true;
            txtTongTien.ReadOnly = true;
            txtTenGD.ReadOnly = true;
            mskDienThoai.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            txtThanhTien.Text = "";
            Functions.FillCombo("Select MaNV from NhanVien", cboMaNV, "MaNV", "TenNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("Select MaNCC from NhaCungCap", cboMaNCC, "MaNCC", "TenNCC");
            cboMaNCC.SelectedIndex = -1;
            Functions.FillCombo("Select MaGD from SanPham", cboMaGD, "MaGD", "TenGD");
            cboMaGD.SelectedIndex = -1;
            if (txtSoHDN.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "Select a.MaGD, b.TenGD, a.SoLuong, b.DonGiaNhap,a.GiamGia, a.ThanhTien from ChiTietHDN as a, SanPham as b where a.SoHDN = N'"
                + txtSoHDN.Text + "'AND a.MaGD= b.MaGD";
            tblCTHDN = Functions.GetDataToTable(sql);
            dgvHDNhapHang.DataSource = tblCTHDN;
            dgvHDNhapHang.AllowUserToAddRows = false;
            dgvHDNhapHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "Select NgayNhap from HoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            dtpNgayNhap.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "Select MaNV from HoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            cboMaNV.Text = Functions.GetFieldValues(str);
            str = "Select MaNCC from HoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            cboMaNCC.Text = Functions.GetFieldValues(str);
            str = "Select TongTien from HoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
            lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtSoHDN.Text = Functions.CreateKey("HDN");
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtSoHDN.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            cboMaNV.Text = "";
            cboMaNCC.Text = "";
            txtTongTien.Text = "";
            lblBangChu.Text = "Bằng chữ: ";
            cboMaGD.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcapnhat, tong, Tongmoi;
            double dg, dgt,dgb;
            sql = "SELECT SoHDN FROM HoaDonNhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDN được sinh tự động do đó không có trường hợp trùng khóa             
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                if (cboMaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNCC.Focus();
                    return;
                }
                //Giá nhập trong sản phẩm tự động cập nhật khi nhập hàng
                dg = Convert.ToDouble(txtDonGia.Text);
                dgt = Convert.ToDouble(Functions.GetFieldValues("SELECT DonGiaNhap FROM SanPham WHERE MaGD = N'" + cboMaGD.SelectedValue + "'"));
                if (dg != dgt)
                {
                    sql = "UPDATE SanPham SET DonGiaNhap =" + dg + " WHERE MaGD= N'" + cboMaGD.SelectedValue + "'";
                    Functions.RunSQL(sql);
                }
                sql = "INSERT INTO HoaDonNhap(SoHDN, NgayNhap, MaNV, MaNCC, Tongtien) VALUES (N'" + txtSoHDN.Text.Trim() + "','" + dtpNgayNhap.Value + "',N'"
                    + cboMaNV.SelectedValue + "',N'" + cboMaNCC.SelectedValue + "',N'" + txtTongTien.Text + "'" + ")";
                Functions.RunSQL(sql);
                //Giá bán trong sản phẩm tự động cập nhật khi nhập hàng
                dgb = Convert.ToDouble(Functions.GetFieldValues("SELECT DonGiaBan FROM SanPham WHERE MaGD = N'" + cboMaGD.SelectedValue + "'"));
                dgb = dg * 1.1;
                sql = "UPDATE SanPham SET DonGiaBan =" + dgt + " WHERE MaGD= N'" + cboMaGD.SelectedValue + "'";
                Functions.RunSQL(sql);
                if (cboMaGD.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã giày dép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaGD.Focus();
                    return;
                }
                if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();
                    return;
                }
                if (txtGiamGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGiamGia.Focus();
                    return;
                }
                if (txtDonGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDonGia.Focus();
                    return;
                }
                sql = "SELECT MaGD FROM ChiTietHDN WHERE MaGD=N'" + cboMaGD.SelectedValue + "' AND SoHDN = N'" + txtSoHDN.Text.Trim() + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValuesSanPham();
                    cboMaGD.Focus();
                    return;
                }
                //số lượng ở sản phẩm tự động tăng khi nhập hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM SanPham WHERE MaGD = N'" + cboMaGD.SelectedValue + "'"));
                sql = "INSERT INTO ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + txtSoHDN.Text.Trim() +
                    "',N'" + cboMaGD.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGia.Text + ","
                    + txtGiamGia.Text + "," + txtThanhTien.Text + ")";
                Functions.RunSQL(sql);
                LoadDataGridView();
                // Cập nhật lại số lượng mới vào bảng Sản phẩm
                SLcapnhat = sl + Convert.ToDouble(txtSoLuong.Text);
                sql = "UPDATE SanPham SET SoLuong =" + SLcapnhat + " WHERE MaGD= N'" + cboMaGD.SelectedValue + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn nhập
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM HoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'"));
                Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
                sql = "UPDATE HoaDonNhap SET TongTien =" + Tongmoi + " WHERE SoHDN = N'" + txtSoHDN.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = Tongmoi.ToString();
                lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(Tongmoi.ToString()));
                ResetValuesSanPham();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnHuy.Enabled = true;
            }
        }
        private void ResetValuesSanPham()
        {
            cboMaGD.Text = "";
            txtSoLuong.Text = "0";
            txtGiamGia.Text = "0";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaGD,SoLuong FROM ChiTietHDN WHERE SoHDN = N'" + txtSoHDN.Text + "'";
                DataTable SanPham = Functions.GetDataToTable(sql);
                for (int sanpham = 0; sanpham <= SanPham.Rows.Count - 1; sanpham++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM SanPham WHERE MaGD = N'" + SanPham.Rows[sanpham][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(SanPham.Rows[sanpham][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE SanPham SET SoLuong =" + slcon + " WHERE MaGD= N'" + SanPham.Rows[sanpham][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE ChiTietHDN WHERE SoHDN=N'" + txtSoHDN.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE HoaDonNhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            txtSoHDN.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinSP;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng giày dép Covid-19";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526184";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP HÀNG";
            // Biểu diễn thông tin chung của hóa đơn nhập
            sql = "SELECT a.SoHDN, a.NgayNhap, a.TongTien, b.TenNCC, b.DiaChi, b.DienThoai, c.TenNV FROM HoaDonNhap AS a, NhaCungCap AS b, NhanVien AS c WHERE a.SoHDN = N'" + txtSoHDN.Text + "' AND a.MaNCC = b.MaNCC AND a.MaNV = c.MaNV";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Số hóa đơn nhập:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = "'" + tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = "'" + tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các sản phẩm
            sql = "SELECT b.TenGD, a.SoLuong, b.DonGiaNhap, a.GiamGia, a.ThanhTien " +
                  "FROM ChiTietHDN AS a , SanPham AS b WHERE a.SoHDN = N'" +
                  txtSoHDN.Text + "' AND a.MaGD = b.MaGD";
            tblThongtinSP = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinSP.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinSP.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinSP.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinSP.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập hàng";
            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboSoHDN.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một số hóa đơn nhập để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSoHDN.Focus();
                return;
            }
            txtSoHDN.Text = cboSoHDN.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cboSoHDN.SelectedIndex = -1;
        }

        private void dgvHDNhapHang_DoubleClick(object sender, EventArgs e)
        {
            string MaGDxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng sản phẩm 
                MaGDxoa = dgvHDNhapHang.CurrentRow.Cells["MaGD"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHDNhapHang.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHDNhapHang.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE ChiTietHDN WHERE SoHDN=N'" + txtSoHDN.Text + "' AND MaGD = N'" + MaGDxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại số lượ1ng cho các mặt sản phẩm
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM SanPham WHERE MaGD = N'" + MaGDxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE SanPham SET SoLuong =" + slcon + " WHERE MaGD= N'" + MaGDxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn nhập
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM HoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE HoaDonNhap SET TongTien =" + tongmoi + " WHERE SoHDN = N'" + txtSoHDN.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tongmoi.ToString()));
                LoadDataGridView();
            }
        }

        private void cboMaGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaGD.Text == "")
            {
                txtTenGD.Text = "";
                txtDonGia.Text = "";
            }
            // Khi chọn mã giày dép thì các thông tin về hàng hiện ra
            str = "SELECT TenGD FROM SanPham WHERE MaGD =N'" + cboMaGD.SelectedValue + "'";
            txtTenGD.Text = Functions.GetFieldValues(str);
        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                txtDiaChi.Text = "";
                mskDienThoai.Text = "";
            }
            //Khi chọn Mã nhà cung cấp thì các thông tin của nhà cung cấp sẽ hiện ra
            str = "Select TenNCC from NhaCungCap where MaNCC = N'" + cboMaNCC.Text + "'";
            txtTenNCC.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi from NhaCungCap where MaNCC = N'" + cboMaNCC.Text + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select DienThoai from NhaCungCap where MaNCC = N'" + cboMaNCC.Text + "'";
            mskDienThoai.Text = Functions.GetFieldValues(str);
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNV from NhanVien where MaNV =N'" + cboMaNV.Text + "'";
            txtTenNV.Text = Functions.GetFieldValues(str);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void cboSoHDN_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT SoHDN FROM HoaDonNhap", cboSoHDN, "SoHDN", "SoHDN");
            cboSoHDN.SelectedIndex = -1;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void dgvHDNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaGD.Text = dgvHDNhapHang.CurrentRow.Cells["MaGD"].Value.ToString();
            txtTenGD.Text = dgvHDNhapHang.CurrentRow.Cells["TenGD"].Value.ToString();
            txtDonGia.Text = dgvHDNhapHang.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtGiamGia.Text = dgvHDNhapHang.CurrentRow.Cells["GiamGia"].Value.ToString();
            txtThanhTien.Text = dgvHDNhapHang.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txtSoLuong.Text = dgvHDNhapHang.CurrentRow.Cells["SoLuong"].Value.ToString();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi đơn giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }
    }
}
