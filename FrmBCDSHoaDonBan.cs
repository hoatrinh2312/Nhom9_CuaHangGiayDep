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
    public partial class FrmBCDSHoaDonBan : Form
    {
        DataTable tblBCDSHDB;
        public FrmBCDSHoaDonBan()
        {
            InitializeComponent();
        }

        private void FrmBCDSHoaDonBan_Load(object sender, EventArgs e)
        {
            Functions.FillCombo1("select MaNV from NhanVien", cboMaNV, "MaNV");
            cboMaNV.SelectedIndex = -1;
        }
        private void ResetValues()
        {
            cboMaNV.Text = "";
            cboMaNV.Focus();

        }

        private void btn_inbaocao_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblBCDSHDB;
            exBook =
            exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            exRange = exSheet.Cells[1, 1];
            exRange.Range[" A1: B3 "].Font.Size = 10;
            exRange.Range[" A1: B3 "].Font.Name = " Times new roman";
            exRange.Range[" A1: B3 "].Font.Bold = true;
            exRange.Range[" A1: B3 "].Font.ColorIndex = 5;
            exRange.Range[" A1: A1 "].ColumnWidth = 7;
            exRange.Range[" B1: B1 "].ColumnWidth = 15;
            exRange.Range[" A1: B1 "].MergeCells = true;
            exRange.Range[" A1: B1 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A1: B1"].Value = " Cửa hàng giày dép";
            exRange.Range[" A2: B2 "].MergeCells = true;
            exRange.Range[" A2: B2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A2: B2"].Value = " Đống Đa -Hà Nội ";
            exRange.Range[" A3: B3 "].MergeCells = true;
            exRange.Range[" A3: B3 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A3: B3 "].Value = " Điện thoại: (023)3756222 ";

            exRange.Range[" C2: F2 "].Font.Size = 16;
            exRange.Range[" C2: F2 "].Font.Name = " Times new roman";
            exRange.Range[" C2: F2 "].Font.Bold = true;
            exRange.Range[" C2: F2 "].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range[" C2: F2 "].MergeCells = true;
            exRange.Range[" C2: F2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2: F2 "].Value = " Báo Cáo Danh Sách Hóa Đơn Bán";

            DataTable tblThongtinNV;
            sql = "SELECT * FROM NhanVien WHERE MaNV=N'" + cboMaNV.Text + "'";
            tblThongtinNV = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Tên nhân viên:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinNV.Rows[0][1].ToString();
            exRange.Range["B7:B7"].Value = "Điện thoại:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinNV.Rows[0][4].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinNV.Rows[0][5].ToString();



            //Lấy thông tin các mặt hàng
            sql = " SELECT a.SoHDB, a.NgayBan,a.TongTien,b.TenKhach FROM HoaDonBan AS a join Khach AS b on a.MaKhach=b.MaKhach WHERE a.MaNV= '" + cboMaNV.Text + "' ";
            tblBCDSHDB = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range[" A11: G11 "].Font.Bold = true;
            exRange.Range[" A11:G11 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C11: H11 "].ColumnWidth = 12;
            exRange.Range[" A11: A11 "].Value = " STT ";
            exRange.Range[" B11: B11 "].Value = " Số HĐB";

            exRange.Range[" C11: C11 "].Value = " Ngày Bán";

            exRange.Range[" D11: D11 "].Value = " Tổng Tiền ";
            exRange.Range[" E11: E11 "].Value = " Tên Khách ";
            for (hang = 0; hang <= tblBCDSHDB.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblBCDSHDB.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblBCDSHDB.Rows[hang][cot].ToString();
                exSheet.Cells[2][hang + 12] = "'" + tblBCDSHDB.Rows[hang][0].ToString();

            }
            sql = "select sum(TongTien) from HoaDonBan  where MaNV='" + cboMaNV.Text + "'";
            DataTable tblBC;
            tblBC = Functions.GetDataToTable(sql);

            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range[" A1: F1 "].MergeCells = true;
            exRange.Range[" A1: F1 "].Font.Bold = true;
            exRange.Range[" A1: F1 "].Font.Italic = true;
            exRange.Range[" A1: F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblBC.Rows[0][0].ToString()));
            exRange = exSheet.Cells[4][hang + 18];
            exRange.Range[" A1: C1 "].MergeCells = true;
            exRange.Range["A1: C1 "].Font.Italic = true;
            exRange.Range[" A1: C1 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range[" A1: C1 "].Value = " Hà Nội, ngày " + day + " tháng " + month + "năm " + year;
            exRange.Range[" A2: C2 "].MergeCells = true;
            exRange.Range[" A2: C2 "].Font.Italic = true;
            exRange.Range[" A2: C2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A2: C2 "].Value = " Nhân viên lập báo cáo ";
            exRange.Range[" A3: C3 "].MergeCells = true;
            exRange.Range[" A3: C3 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A3: C3 "].Value = " (Kí, Ghi rõ họ tên)";
            exSheet.Name = " Hóa Đơn Bán";
            exApp.Visible = true;
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaNV.Text == "")
            {
                MessageBox.Show("nhập một điều kiện tìm kiếm", "yêu cầu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.SoHDB, a.MaNV, a.NgayBan, b.TenNV, Sum(a.TongTien)as tongtien,a.MaKhach from HoaDonBan as a join NhanVien as b on a.MaNV=b.MaNV " +
               "where a.MaNV='" + cboMaNV.Text + "' group by a.SoHDB, a.MaNV, a.NgayBan, b.TenNV,a.MaKhach";


            tblBCDSHDB = Functions.GetDataToTable(sql);
            if (tblBCDSHDB.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thỏa mãn điều kiện", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("có" + tblBCDSHDB.Rows.Count + "bản ghi thỏa mãn điều kiện", "thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DataGridView_BCDSHDB.DataSource = tblBCDSHDB;
        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView_BCDSHDB.DataSource = null;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
