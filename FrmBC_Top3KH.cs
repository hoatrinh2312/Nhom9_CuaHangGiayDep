using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace CuaHangGiayDep
{
    public partial class FrmBC_Top3KH : Form
    {
        DataTable tblBaoCao;
        public FrmBC_Top3KH()
        {
            InitializeComponent();
        }

        private void FrmCau9_Load(object sender, EventArgs e)
        {

        }
        private void ResetValues()
        {
            txtNam.Text = "";
            txtTongTien.Text = "0";
            cboQuy.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            mskDienThoai.Text = "";

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboQuy.Text == "" || txtNam.Text == "")
            {
                MessageBox.Show("Bạn phải nhập cả quý và năm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQuy.Focus();
                txtNam.Focus();
            }

            sql = "select top 3 a.TenKhach, a.DiaChi,a.DienThoai,  SUM(b.TongTien) as tongtien from Khach as a Join HoaDonBan as b on a.MaKhach = b.MaKhach where((Datepart(QUARTER, b.NgayBan))='" + cboQuy.SelectedItem + "' and Year(b.NgayBan)= '" + txtNam.Text + "')" +
                    "group by a.TenKhach,a.DiaChi,a.DienThoai Order by Sum(b.TongTien) DESC";

            tblBaoCao = Functions.GetDataToTable(sql);
            if (tblBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                cboQuy.Focus();

            }
            else
            {
                MessageBox.Show("Có " + tblBaoCao.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            dataGridView_Cau9.DataSource = tblBaoCao;
        }

        private void dataGridView_Cau9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKhach.Text = dataGridView_Cau9.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtTongTien.Text = dataGridView_Cau9.CurrentRow.Cells["tongtien"].Value.ToString();
            txtDiaChi.Text = dataGridView_Cau9.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienThoai.Text = dataGridView_Cau9.CurrentRow.Cells["DienThoai"].Value.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cboQuy.Text == "" || txtNam.Text == "")
            {
                MessageBox.Show("Bạn phải nhập cả quý và năm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQuy.Focus();
                txtNam.Focus();
            }
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongTinKhach;
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
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526419";
            exRange.Range["C2:E2"].Font.Size = 14;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "Báo cáo danh sách họ tên, tổng tiền của top 3 khách mua nhiều nhất";
            exRange.Range["B4:B4"].MergeCells = true;
            exRange.Range["B4:B4"].Font.Bold = true;
            exRange.Range["B4:B4"].Font.Italic = true;
            exRange.Range["B4:B4"].Value = "Báo cáo: ";
            exRange.Range["C4:C4"].MergeCells = true;
            exRange.Range["C4:C4"].Value = "Quý " + cboQuy.Text + "-Năm" + txtNam.Text;

            sql = "select top 3 a.MaKhach, a.TenKhach,a.DiaChi,a.DienThoai, SUM(b.TongTien) as tongtien from Khach as a Join HoaDonBan as b on a.MaKhach = b.MaKhach where((Datepart(QUARTER, b.NgayBan))='" + cboQuy.SelectedItem + "' and Year(b.NgayBan)= '" + txtNam.Text + "')" +
                    "group by a.MaKhach, a.TenKhach,a.DiaChi,a.DienThoai Order by Sum(b.TongTien) DESC";
            tblThongTinKhach = Functions.GetDataToTable(sql);

            exRange.Range["B6:G6"].Font.Bold = true;
            exRange.Range["B6:G6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B6:G6"].ColumnWidth = 12;
            exRange.Range["B6:B6"].Value = "STT";
            exRange.Range["C6:C6"].Value = "Mã khách";
            exRange.Range["C7:C7"].MergeCells = true;
            exRange.Range["D6:D6"].Value = "Tên khách";
            exRange.Range["D7:D7"].MergeCells = true;
            exRange.Range["E6:E6"].Value = "Địa chỉ";
            exRange.Range["E7:E7"].MergeCells = true;
            exRange.Range["F6:F6"].Value = "Điện thoại";
            exRange.Range["F7:F7"].MergeCells = true;
            exRange.Range["G6:G6"].Value = "Tổng tiền";
            exRange.Range["G7:G7"].MergeCells = true;


            for (hang = 0; hang <= tblThongTinKhach.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 2 từ dòng 7
                exSheet.Cells[2][hang + 7] = hang + 1;

                for (cot = 0; cot <= tblThongTinKhach.Columns.Count - 1; cot++)
                //Điền thông tin Khách từ cột thứ 3, dòng 7
                {
                    exSheet.Cells[cot + 3][hang + 7] = tblThongTinKhach.Rows[hang][cot].ToString();
                    exSheet.Cells[6][hang + 7] = "'" + tblThongTinKhach.Rows[hang][3].ToString();

                }
            }

            exRange.Range["D12:F12"].MergeCells = true;
            exRange.Range["D12:F12"].Font.Italic = true;
            exRange.Range["D12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range["D12:F12"].Value = "Hà Nội, ngày " + day + " tháng " + month + " năm " + year;
            exRange.Range["D13:F13"].MergeCells = true;
            exRange.Range["D13:F13"].Font.Italic = true;
            exRange.Range["D13:F13"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D13:F13"].Value = "Nhân viên lập báo cáo";
            exRange.Range["D14:F14"].MergeCells = true;
            exRange.Range["D14:F14"].Font.Italic = true;
            exRange.Range["D14:F14"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D14:F14"].Value = "(Kí và ghi rõ họ tên)";
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView_Cau9.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
