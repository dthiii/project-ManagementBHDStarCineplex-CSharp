using qlPhim.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.ThongKe
{
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {
            LoadStatisticsByMovie();
            CustomizedgvTKPhim();
            LoadStatisticsByProduct();
            CustomizedgvTKBapnuoc();
            this.SizeChanged += frmThongke_SizeChanged;
            SetColumnWidthsInPercentagedgvTKPhim();
            SetColumnWidthsInPercentagedgvTKBapnuoc();
        }

        private void frmThongke_SizeChanged(object sender, EventArgs e)
        {
            if (dgvTKPhim.Columns.Count > 0)
            {
                SetColumnWidthsInPercentagedgvTKPhim();
            }
            if (dgvTKBapnuoc.Columns.Count > 0)
            {
                SetColumnWidthsInPercentagedgvTKBapnuoc();
            }
        }

        private void rdoPTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByMovie();
        }

        private void rdoPKhoangThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByMovie();
        }

        private void dtpPTuNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoPKhoangThoiGian.Checked = true;
            LoadStatisticsByMovie();
        }

        private void dtpPDenNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoPKhoangThoiGian.Checked = true;
            LoadStatisticsByMovie();
        }

        private void dgvTKPhim_DataSourceChanged(object sender, EventArgs e)
        {
            int tongVe = 0;
            double tongDoanhThu = 0;
            foreach (DataGridViewRow row in dgvTKPhim.Rows)
            {
                if (row.Cells["SoVeBanRa"].Value != null && int.TryParse(row.Cells["SoVeBanRa"].Value.ToString(), out int soVe))
                {
                    tongVe += soVe;
                }
                if (row.Cells["DoanhThu"].Value != null && int.TryParse(row.Cells["DoanhThu"].Value.ToString(), out int doanhTHu))
                {
                    tongDoanhThu += doanhTHu;
                }
            }
            txtPTongVe.Text = tongVe.ToString();
            txtDoanhThuPhim.Text = string.Format("{0:N0} đ", tongDoanhThu);
        }

        private void rdoSPTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByProduct();
        }

        private void rdoSPKhoangThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByProduct();
        }

        private void dtpSPTuNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoSPKhoangThoiGian.Checked = true;
            LoadStatisticsByProduct();
        }

        private void dtpSPDenNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoSPKhoangThoiGian.Checked = true;
            LoadStatisticsByProduct();
        }

        private void dgvTKBapnuoc_DataSourceChanged(object sender, EventArgs e)
        {
            int soLuongDaBan = 0;
            double tongDoanhThu = 0;
            foreach (DataGridViewRow row in dgvTKBapnuoc.Rows)
            {
                if (row.Cells["SoLuongDaBan"].Value != null && int.TryParse(row.Cells["SoLuongDaBan"].Value.ToString(), out int soLuong))
                {
                    soLuongDaBan += soLuong;
                }
                if (row.Cells["DoanhThu"].Value != null && int.TryParse(row.Cells["DoanhThu"].Value.ToString(), out int doanhTHu))
                {
                    tongDoanhThu += doanhTHu;
                }
            }
            txtSoLuongDaBan.Text = soLuongDaBan.ToString();
            txtDoanhThuSP.Text = string.Format("{0:N0} đ", tongDoanhThu);
        }

        private void btnPBieuDo_Click(object sender, EventArgs e)
        {
            frmBieuDo f = new frmBieuDo();
            f.DrawRevenueChartMovie(dgvTKPhim);
            f.ShowDialog();
        }

        private void btnPPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuPhim");
            rptTKPhim r = new rptTKPhim();
            r.SetDataSource(dataTable);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnPExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaPhim");
            DataColumn col2 = new DataColumn("TenPhim");
            DataColumn col3 = new DataColumn("SoSuatChieu");
            DataColumn col4 = new DataColumn("TongSoVe");
            DataColumn col5 = new DataColumn("SoVeBanRa");
            DataColumn col6 = new DataColumn("SoVeTon");
            DataColumn col7 = new DataColumn("DoanhThu");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            foreach (DataGridViewRow dgvRow in dgvTKPhim.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaPhim"].Value;
                row[1] = dgvRow.Cells["TenPhim"].Value;
                row[2] = dgvRow.Cells["SoSuatChieu"].Value;
                row[3] = dgvRow.Cells["TongSoVe"].Value;
                row[4] = dgvRow.Cells["SoVeBanRa"].Value;
                row[5] = dgvRow.Cells["SoVeTon"].Value;
                row[6] = dgvRow.Cells["DoanhThu"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFileStatisticsByMovie(dataTable, "Doanh thu", "THỐNG KÊ DOANH THU THEO PHIM");
        }

        private void btnSPBieuDo_Click(object sender, EventArgs e)
        {
            frmBieuDo f = new frmBieuDo();
            f.DrawRevenueChartProduct(dgvTKBapnuoc);
            f.ShowDialog();
        }

        private void btnSPPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuSanPham");
            rptTKBapnuoc r = new rptTKBapnuoc();
            r.SetDataSource(dataTable);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnSPExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaSP");
            DataColumn col2 = new DataColumn("TenSP");
            DataColumn col3 = new DataColumn("SoLuongTon");
            DataColumn col4 = new DataColumn("SoLuongDaBan");
            DataColumn col5 = new DataColumn("DoanhThu");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);

            foreach (DataGridViewRow dgvRow in dgvTKBapnuoc.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaSP"].Value;
                row[1] = dgvRow.Cells["TenSP"].Value;
                row[2] = dgvRow.Cells["SoLuongTon"].Value;
                row[3] = dgvRow.Cells["SoLuongDaBan"].Value;
                row[4] = dgvRow.Cells["DoanhThu"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFileStatisticsByProduct(dataTable, "Doanh thu", "THỐNG KÊ DOANH THU THEO SẢN PHẨM");
        }

        public void LoadStatisticsByMovie()
        {
            if (rdoPTatCa.Checked)
            {
                dgvTKPhim.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuPhim");
            }
            else
            {
                dgvTKPhim.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuPhim @tuNgay , @denNgay ", new object[] { dtpPTuNgay.Value, dtpPDenNgay.Value });
            }
        }

        public void LoadStatisticsByProduct()
        {
            if (rdoSPTatCa.Checked)
            {
                dgvTKBapnuoc.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuSanPham");
            }
            else
            {
                dgvTKBapnuoc.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuSanPham @tuNgay , @denNgay ", new object[] { dtpPTuNgay.Value, dtpPDenNgay.Value });
            }
        }

        private void CustomizedgvTKPhim()
        {
            dgvTKPhim.EnableHeadersVisualStyles = false;
            dgvTKPhim.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvTKPhim.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTKPhim.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTKPhim.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKPhim.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTKPhim.RowTemplate.Height = 30;

            dgvTKPhim.Columns["MaPhim"].HeaderText = "Mã Phim";
            dgvTKPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvTKPhim.Columns["SoSuatChieu"].HeaderText = "Số suất chiếu";
            dgvTKPhim.Columns["TongSoVe"].HeaderText = "Tổng số vé";
            dgvTKPhim.Columns["SoVeBanRa"].HeaderText = "Số vé bán ra";
            dgvTKPhim.Columns["SoVeTon"].HeaderText = "Số vé tồn";
            dgvTKPhim.Columns["DoanhThu"].HeaderText = "Doanh thu";

            dgvTKPhim.Columns["MaPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKPhim.Columns["SoSuatChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKPhim.Columns["TongSoVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKPhim.Columns["SoVeBanRa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKPhim.Columns["SoVeTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKPhim.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetColumnWidthsInPercentagedgvTKPhim()
        {
            int totalWidth = dgvTKPhim.Width;

            dgvTKPhim.Columns["MaPhim"].Width = (int)(0.1 * totalWidth);
            dgvTKPhim.Columns["TenPhim"].Width = (int)(0.3 * totalWidth);
            dgvTKPhim.Columns["SoSuatChieu"].Width = (int)(0.12 * totalWidth);
            dgvTKPhim.Columns["TongSoVe"].Width = (int)(0.12 * totalWidth);
            dgvTKPhim.Columns["SoVeBanRa"].Width = (int)(0.12 * totalWidth);
            dgvTKPhim.Columns["SoVeTon"].Width = (int)(0.12 * totalWidth);
            dgvTKPhim.Columns["DoanhThu"].Width = (int)(0.12 * totalWidth);

            dgvTKPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void CustomizedgvTKBapnuoc()
        {
            dgvTKBapnuoc.EnableHeadersVisualStyles = false;
            dgvTKBapnuoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvTKBapnuoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTKBapnuoc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTKBapnuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKBapnuoc.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTKBapnuoc.RowTemplate.Height = 30;

            dgvTKBapnuoc.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvTKBapnuoc.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvTKBapnuoc.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dgvTKBapnuoc.Columns["SoLuongDaBan"].HeaderText = "Số lượng đã bán";
            dgvTKBapnuoc.Columns["DoanhThu"].HeaderText = "Doanh thu";

            dgvTKBapnuoc.Columns["MaSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKBapnuoc.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKBapnuoc.Columns["SoLuongDaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTKBapnuoc.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetColumnWidthsInPercentagedgvTKBapnuoc()
        {
            int totalWidth = dgvTKBapnuoc.Width;

            dgvTKBapnuoc.Columns["MaSP"].Width = (int)(0.15 * totalWidth);
            dgvTKBapnuoc.Columns["TenSP"].Width = (int)(0.4 * totalWidth);
            dgvTKBapnuoc.Columns["SoLuongTon"].Width = (int)(0.15 * totalWidth);
            dgvTKBapnuoc.Columns["SoLuongDaBan"].Width = (int)(0.15 * totalWidth);
            dgvTKBapnuoc.Columns["DoanhThu"].Width = (int)(0.15 * totalWidth);

            dgvTKBapnuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        public void ExportFileStatisticsByMovie(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = oExcel.Workbooks.Add(Type.Missing);
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã phim";
            cl1.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên phim";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số suất chiếu";
            cl3.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tổng số vé";
            cl4.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số vé bán ra";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số vé tồn";
            cl6.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Doanh thu";
            cl7.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowHead.Font.Name = "Times New Roman";
            rowHead.Font.Size = "11";

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            int rowStart = 4;
            int colStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int colEnd = dataTable.Columns.Count;
            Microsoft.Office.Interop.Excel.Range c0 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];
            Microsoft.Office.Interop.Excel.Range cN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c0, cN);
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oSheet.get_Range(c0, cN).Font.Name = "Times New Roman";
            oSheet.get_Range(c0, cN).Font.Size = "11";
            oSheet.get_Range(c0, cN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range c02 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 1];
            Microsoft.Office.Interop.Excel.Range cN2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 1];
            oSheet.get_Range(c02, cN2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }

        public void ExportFileStatisticsByProduct(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = oExcel.Workbooks.Add(Type.Missing);
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã sản phẩm";
            cl1.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên sản phẩm";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số lượng tồn";
            cl3.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số lượng bán ra";
            cl4.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Doanh thu";
            cl5.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowHead.Font.Name = "Times New Roman";
            rowHead.Font.Size = "11";

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            int rowStart = 4;
            int colStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int colEnd = dataTable.Columns.Count;
            Microsoft.Office.Interop.Excel.Range c0 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];
            Microsoft.Office.Interop.Excel.Range cN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c0, cN);
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oSheet.get_Range(c0, cN).Font.Name = "Times New Roman";
            oSheet.get_Range(c0, cN).Font.Size = "11";
            oSheet.get_Range(c0, cN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range c02 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 1];
            Microsoft.Office.Interop.Excel.Range cN2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 1];
            oSheet.get_Range(c02, cN2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentagedgvTKPhim();
            SetColumnWidthsInPercentagedgvTKBapnuoc();
        }
    }
}
