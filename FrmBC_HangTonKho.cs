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
    public partial class FrmBC_HangTonKho : Form
    {
        DataTable tblBaoCao;
        public FrmBC_HangTonKho()
        {
            InitializeComponent();
        }

        private void FrmBC_HangTonKho_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCo.Text = dataGridView_BaoCao.CurrentRow.Cells["MaGD"].Value.ToString();
            txtMaCL.Text = dataGridView_BaoCao.CurrentRow.Cells["TenGD"].Value.ToString();
            txtMaLoai.Text = dataGridView_BaoCao.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtMaCo.Text = dataGridView_BaoCao.CurrentRow.Cells["MaCo"].Value.ToString();
            txtMaCL.Text = dataGridView_BaoCao.CurrentRow.Cells["MaCL"].Value.ToString();
            txtMaDT.Text = dataGridView_BaoCao.CurrentRow.Cells["MaDT"].Value.ToString();
            txtMaMau.Text = dataGridView_BaoCao.CurrentRow.Cells["MaMau"].Value.ToString();
            txtMaMua.Text = dataGridView_BaoCao.CurrentRow.Cells["MaMua"].Value.ToString();
            txtSoLuong.Text = dataGridView_BaoCao.CurrentRow.Cells["soluong"].Value.ToString();
            txtMaNSX.Text = dataGridView_BaoCao.CurrentRow.Cells["MaNSX"].Value.ToString();
            txtDonGiaNhap.Text = dataGridView_BaoCao.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dataGridView_BaoCao.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtAnh.Text = dataGridView_BaoCao.CurrentRow.Cells["Anh"].Value.ToString();
            txtAnh.Text = Functions.GetFieldValues("select Anh from SanPham where Anh='" + txtAnh.Text + "'");
        }
        private void ResetValue()
        {
            txtMaGD.Text = "";
            txtTenGD.Text = "";
            txtMaLoai.Text = "";
            txtMaCo.Text = "";
            txtMaCL.Text = "";
            txtMaDT.Text = "";
            txtMaMau.Text = "";
            txtMaNSX.Text = "";
            txtMaMua.Text = "";
            txtSoLuong.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from SanPham where SoLuong >0 order by SoLuong desc";
            tblBaoCao = Functions.GetDataToTable(sql);
            dataGridView_BaoCao.DataSource = tblBaoCao;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongTinSP_TonKho;
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
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "BÁO CÁO SẢN PHẨM TỒN KHO";

            sql = "select MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaDT,MaMua, MaNSX, SoLuong, DonGiaNhap, DonGiaBan from SanPham where SoLuong>0 order by SoLuong  desc";
            tblThongTinSP_TonKho = Functions.GetDataToTable(sql);
            exRange.Range["A6:M6"].Font.Bold = true;
            exRange.Range["A6:M6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:O6"].ColumnWidth = 12;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Mã giày dép";
            exRange.Range["C6:C6"].Value = "Tên giày dép";
            exRange.Range["D6:D6"].Value = "Mã Loại";
            exRange.Range["E6:E6"].Value = "Mã Cỡ";
            exRange.Range["F6:F6"].Value = "Mã CL";
            exRange.Range["G6:G6"].Value = "Mã Màu";
            exRange.Range["H6:H6"].Value = "Mã DT";
            exRange.Range["I6:I6"].Value = "Mã Mùa";
            exRange.Range["J6:J6"].Value = "Mã NSX";
            exRange.Range["K6:K6"].Value = "Số Lượng";
            exRange.Range["L6:L6"].Value = "Đơn Giá Nhập";
            exRange.Range["M6:M6"].Value = "Đơn Giá Bán";
            for (hang = 0; hang < tblThongTinSP_TonKho.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 7
                exSheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot < tblThongTinSP_TonKho.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 7
                {
                    exSheet.Cells[cot + 2][hang + 7] = tblThongTinSP_TonKho.Rows[hang][cot].ToString();
                }
            }

            exRange.Range["D20:F20"].MergeCells = true;
            exRange.Range["D20:F20"].Font.Italic = true;
            exRange.Range["D20:F20"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range["D20:F20"].Value = "Hà Nội, ngày " + day + " tháng " + month + " năm " + year;
            exRange.Range["D21:F21"].MergeCells = true;
            exRange.Range["D21:F21"].Font.Italic = true;
            exRange.Range["D21:F21"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D21:F21"].Value = "Nhân viên lập báo cáo";
            exRange.Range["D22:F22"].MergeCells = true;
            exRange.Range["D22:F22"].Font.Italic = true;
            exRange.Range["D22:F22"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D22:F22"].Value = "(Kí và ghi rõ họ tên)";
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;


        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValue();
            dataGridView_BaoCao.DataSource = null;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(.bmp)|.bmp|JPEG(.jpg)|.jpg|GIF(.gif)|.gif|All files(.)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
