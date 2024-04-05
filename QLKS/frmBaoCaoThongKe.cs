using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class btnTimKiem : Form
    {
        public btnTimKiem()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        // lớp kết nối abcdeaegsfggh4d23dfhhsfvfsghhhasfddf
        public void getData()
        {
            string query = " select * from ThongKe";
            DataSet ds = kn.LayDuLieu(query);
            dgvThongKe.DataSource = ds.Tables[0];
        }
        // Lấy dữ liệu thống kê 


        public void UpdateTotalRevenueInThongKe()
        {
            // 
            string query = "UPDATE ThongKe SET DoanhThu = (SELECT SUM(ThanhTien) FROM HoaDon,ThongKe), NgayThongKe = GETDATE()";

            // Thực hiện truy vấn cập nhật
            kn.ThucThi(query);
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel
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

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã thống kê";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tháng";

            cl2.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Doanh thu";
            cl3.ColumnWidth = 20.0;

            

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C1");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

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

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            getData();
            UpdateTotalRevenueInThongKe();
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã thống kê");
            DataColumn col2 = new DataColumn("Tháng");
            DataColumn col3 = new DataColumn("Doanh thu");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);

            foreach (DataGridViewRow dgvRow in dgvThongKe.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dgvRow.Cells[0].Value;
                dtRow[1] = dgvRow.Cells[1].Value;
                dtRow[2] = dgvRow.Cells[2].Value;

                dataTable.Rows.Add(dtRow);
            }
            ExportFile(dataTable, "Thong ke", "Thống kê doanh thu");
        }

        private void frmBaoCaoThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Form con đang đóng bởi người dùng (ấn nút "X"), thực hiện xử lý ở đây
                // Ví dụ: hiển thị lại các nút button trên form cha
                frmMain mainForm = this.MdiParent as frmMain;
                if (mainForm != null)
                {
                    mainForm.ShowButtons(); // Tự định nghĩa phương thức ShowButtons trên MainForm để hiển thị các nút
                }
            }
        }


        private void dgvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
