using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmThongKe : Form
    {
        PhieuMuonBLL pmBLL = new PhieuMuonBLL();
        PhieuTraBLL ptBLL = new PhieuTraBLL();
        Helper helper = new Helper();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void cmbLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDSThongKe.DataSource = null;
            dgvDSThongKe.ClearSelection();

            if (cmbLoaiPhieu.Text.Equals("Phiếu trả"))
            {
                dgvDSThongKe.DataSource = ptBLL.GetDSView_DSPhieuTra();
            }
            else
            {
                dgvDSThongKe.DataSource = pmBLL.GetDSView_DSPhieuMuon();
            }
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            cmbLoaiPhieu.SelectedIndex = 1;
            cmbLoaiPhieu_SelectedIndexChanged(sender, e);
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title, string type)
        {
            string col1, col2, col3, col4, col5, col6;

            // Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột. Nâng cấp lên sinh theo tên cột của view_DSPhieuMuon hoặc view_DSPhieuTra
            if (type.Equals("Phiếu mượn"))
            {
                col1 = "Mã phiếu mượn";
                col2 = "Nhân viên";
                col3 = "Mã thẻ";
                col4 = "Độc giả";
                col5 = "Ngày mượn";
                col6 = "Đã trả";
            }
            else
            {
                col1 = "Mã phiếu trả";
                col2 = "Mã phiếu mượn";
                col3 = "Nhân viên";
                col4 = "Mã thẻ";
                col5 = "Độc giả";
                col6 = "Ngày trả";
            }

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = col1;
            cl1.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = col2;
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = col3;
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = col4;
            cl4.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = col5;
            cl5.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = col6;
            cl6.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");
            rowHead.Font.Bold = true;

            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            // Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            // Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 2;
            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cmbLoaiPhieu.Text.Equals("Phiếu trả"))
            {
                DataTable dt = helper.ChuyenDoiListSangDataTable(ptBLL.GetDSView_DSPhieuTra());
                ExportFile(dt, "Thống kê phiếu trả", "DANH SÁCH PHIẾU TRẢ", "Phiếu trả");
            }
            else
            {
                DataTable dt = helper.ChuyenDoiListSangDataTable(pmBLL.GetDSView_DSPhieuMuon());
                ExportFile(dt, "Thống kê phiếu mượn", "DANH SÁCH PHIẾU MƯỢN", "Phiếu mượn");
            }
        }
    }
}
