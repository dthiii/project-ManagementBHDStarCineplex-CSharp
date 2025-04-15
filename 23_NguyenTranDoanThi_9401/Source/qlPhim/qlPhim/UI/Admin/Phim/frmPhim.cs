using qlPhim.BLL;
using qlPhim.DAL;
using qlPhim.UI.Admin.Phim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlPhim.UI.Admin
{
    public partial class frmPhim : Form
    {
        public frmPhim()
        {
            InitializeComponent();
        }

        public void LoadListMovie()
        {
            dgvPhim.DataSource = ChiTietPhimBLL.Instance.GetListMoiveDetail();
        }

        private void CustomizeDataGridView()
        {
            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
            editImageColumn.Name = "EditColumn";
            editImageColumn.HeaderText = "Chỉnh sửa";
            editImageColumn.Image = Properties.Resources.edit;
            dgvPhim.Columns.Add(editImageColumn);

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "Xóa";
            deleteImageColumn.Image = Properties.Resources.delete;
            dgvPhim.Columns.Add(deleteImageColumn);

            dgvPhim.EnableHeadersVisualStyles = false;
            dgvPhim.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvPhim.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPhim.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPhim.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhim.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPhim.RowTemplate.Height = 30;

            dgvPhim.Columns["MaPhim"].HeaderText = "Mã phim";
            dgvPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvPhim.Columns["BieuTuongPL"].HeaderText = "Phân loại";
            dgvPhim.Columns["DaoDien"].HeaderText = "Đạo diễn";
            dgvPhim.Columns["QuocGia"].HeaderText = "Quốc gia";
            dgvPhim.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgvPhim.Columns["NgayKhoiChieu"].HeaderText = "Ngày khởi chiếu";
            dgvPhim.Columns["TheLoaiPhim"].HeaderText = "Thể loại";

            dgvPhim.Columns["MaPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhim.Columns["ThoiLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhim.Columns["NgayKhoiChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPhim.Columns["MaPL"].Visible = false;
            dgvPhim.Columns["MoTa"].Visible = false;
            dgvPhim.Columns["Poster"].Visible = false;
            dgvPhim.Columns["Trailer"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvPhim.Width;

            dgvPhim.Columns["MaPhim"].Width = (int)(0.08 * totalWidth);
            dgvPhim.Columns["TenPhim"].Width = (int)(0.2 * totalWidth);
            dgvPhim.Columns["BieuTuongPL"].Width = (int)(0.07 * totalWidth);
            dgvPhim.Columns["DaoDien"].Width = (int)(0.1 * totalWidth);
            dgvPhim.Columns["QuocGia"].Width = (int)(0.1 * totalWidth);
            dgvPhim.Columns["ThoiLuong"].Width = (int)(0.05 * totalWidth);
            dgvPhim.Columns["NgayKhoiChieu"].Width = (int)(0.13 * totalWidth);
            dgvPhim.Columns["TheLoaiPhim"].Width = (int)(0.15 * totalWidth);
            dgvPhim.Columns["EditColumn"].Width = (int)(0.055 * totalWidth);
            dgvPhim.Columns["DeleteColumn"].Width = (int)(0.055 * totalWidth);

            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
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
            cl3.Value2 = "Phân loại";
            cl3.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Đạo diễn";
            cl4.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Quốc gia";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Thời lượng (phút)";
            cl6.ColumnWidth = 17;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Ngày khời chiếu";
            cl7.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Thể loại";
            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");
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
            Microsoft.Office.Interop.Excel.Range c04 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 3];
            Microsoft.Office.Interop.Excel.Range cN4 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 3];
            oSheet.get_Range(c04, cN4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            Microsoft.Office.Interop.Excel.Range c0N = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colEnd];
            Microsoft.Office.Interop.Excel.Range cNN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            oSheet.get_Range(c0N, cNN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }

        private void frmPhim_Load(object sender, EventArgs e)
        {
            LoadListMovie();
            CustomizeDataGridView();
            SetColumnWidthsInPercentage();
            this.SizeChanged += frmPhim_SizeChanged;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemphim f = new frmThemphim();
            f.ShowDialog();
        }

        private void dgvPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvPhim.Columns[e.ColumnIndex].Name;
            if (e.RowIndex == -1 || columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                return;
            }
            DataGridViewRow selectedRow = dgvPhim.CurrentRow;
            frmChitietphim f = new frmChitietphim();
            f.Text = "Chi tiết phim";
            f.LoadData(selectedRow);
            f.ShowDialog();
        }

        private void frmPhim_SizeChanged(object sender, EventArgs e)
        {
            if (dgvPhim.Columns.Count > 0)
            {
                SetColumnWidthsInPercentage();
            }
        }

        private void dgvPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == dgvPhim.Columns["EditColumn"].Index)
            {
                frmThemphim f = new frmThemphim();
                f.Text = "Chỉnh sửa thông tin phim";
                f.LoadData(dgvPhim.Rows[e.RowIndex]);
                f.ShowDialog();
            }

            if (e.ColumnIndex == dgvPhim.Columns["DeleteColumn"].Index)
            {
                if (MessageBox.Show("Bạn muốn xóa phim này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string maPhim = dgvPhim.Rows[e.RowIndex].Cells["MaPhim"].Value.ToString();
                    if (PhimBLL.Instance.DeleteMovie(maPhim))
                    {
                        MessageBox.Show("Đã xóa phim thành công.", "Thông báo", MessageBoxButtons.OK);
                        LoadListMovie();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnTimphim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNhap.Text))
            {
                if (rdbMaphim.Checked)
                {
                    dgvPhim.DataSource = ChiTietPhimBLL.Instance.GetListMoiveDetailByMovieID(txtNhap.Text);
                }
                else
                {
                    dgvPhim.DataSource = ChiTietPhimBLL.Instance.GetListMoiveDetailByMovieName(txtNhap.Text);
                }
            }
            else
            {
                LoadListMovie();
            }

        }

        private void btnTatcaphim_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            LoadListMovie();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<ChiTietPhimDAL> list = ChiTietPhimBLL.Instance.GetListMoiveDetail();
            rptPhim r = new rptPhim();
            r.SetDataSource(list);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaPhim");
            DataColumn col2 = new DataColumn("TenPhim");
            DataColumn col3 = new DataColumn("MaPL");
            DataColumn col4 = new DataColumn("DaoDien");
            DataColumn col5 = new DataColumn("QuocGia");
            DataColumn col6 = new DataColumn("ThoiLuong");
            DataColumn col7 = new DataColumn("NgayKhoiChieu");
            DataColumn col8 = new DataColumn("TheLoaiPhim");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);

            foreach (DataGridViewRow dgvRow in dgvPhim.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaPhim"].Value;
                row[1] = dgvRow.Cells["TenPhim"].Value;
                row[2] = dgvRow.Cells["MaPL"].Value;
                row[3] = dgvRow.Cells["DaoDien"].Value;
                row[4] = dgvRow.Cells["QuocGia"].Value;
                row[5] = dgvRow.Cells["ThoiLuong"].Value;
                row[6] = ((DateTime)dgvRow.Cells["NgayKhoiChieu"].Value).ToString("dd/MM/yyyy");
                row[7] = dgvRow.Cells["TheLoaiPhim"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFile(dataTable, "Phim", "DANH SÁCH PHIM");
        }
    }
}
