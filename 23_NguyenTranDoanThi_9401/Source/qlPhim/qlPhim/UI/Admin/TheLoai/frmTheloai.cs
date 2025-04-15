using qlPhim.BLL;
using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.TheLoai
{
    public partial class frmTheloai : Form
    {
        BindingSource bsGenreList = new BindingSource();

        public frmTheloai()
        {
            InitializeComponent();
        }

        private void frmTheloai_Load(object sender, EventArgs e)
        {
            dgvTheLoai.DataSource = bsGenreList;
            LoadListGenre();
            string tenTL = dgvTheLoai.Rows[0].Cells["TenTheLoai"].Value.ToString();
            dgvDSPhim.DataSource = ChiTietPhimBLL.Instance.GetListMoiveDetailByGenreName(tenTL);
            CustomizedgvDSPhim();
            CustomizedgvTheLoai();
            BindingGenre();
            this.SizeChanged += frmTheloai_SizeChanged;
            SetColumnWidthsInPercentagedgvDSPhim();
            SetColumnWidthsInPercentagedgvTheLoai();
        }

        private void frmTheloai_SizeChanged(object sender, EventArgs e)
        {
            if (dgvDSPhim.Columns.Count > 0)
            {
                SetColumnWidthsInPercentagedgvDSPhim();
            }
            if (dgvTheLoai.Columns.Count > 0)
            {
                SetColumnWidthsInPercentagedgvTheLoai();
            }
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string tenTL = dgvTheLoai.Rows[e.RowIndex].Cells["TenTheLoai"].Value.ToString();
                dgvDSPhim.DataSource = ChiTietPhimBLL.Instance.GetListMoiveDetailByGenreName(tenTL);
            }
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThemmoi.Visible = false;
            btnHuy.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThemmoi.Visible = true;
            btnHuy.Visible = true;
            txtTenTheLoai.Clear();
            txtTenTheLoai.Focus();
            txtMaTheLoai.Text = TheLoaiBLL.Instance.GetNextMaTL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTheLoai.Text))
            {
                MessageBox.Show("Tên thể loại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTheLoai.Focus();
            }
            else
            {
                if (TheLoaiBLL.Instance.UpdateGenre(txtMaTheLoai.Text, txtTenTheLoai.Text))
                {
                    MessageBox.Show("Đã chỉnh sửa thể loại phim thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListGenre();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thể loại phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thể loại phim này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (TheLoaiBLL.Instance.DaleteGenre(txtMaTheLoai.Text))
                {
                    MessageBox.Show("Đã xoá thể loại phim thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListGenre();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTheLoai.Text))
            {
                MessageBox.Show("Tên thể loại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
            }
            else
            {
                if (TheLoaiBLL.Instance.InsertGenre(txtTenTheLoai.Text))
                {
                    MessageBox.Show("Đã thêm thể loại phim thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListGenre();
                    btnThem.Visible = true;
                    btnSua.Visible = true;
                    btnXoa.Visible = true;
                    btnThemmoi.Visible = false;
                    btnHuy.Visible = false;
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm thể loại phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThemmoi.Visible = false;
            btnHuy.Visible = false;
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<TheLoaiDAL> list = TheLoaiBLL.Instance.GetListGenre();
            rptTheloai r = new rptTheloai();
            r.SetDataSource(list);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaTL");
            DataColumn col2 = new DataColumn("TenTheLoai");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);

            foreach (DataGridViewRow dgvRow in dgvTheLoai.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaTL"].Value;
                row[1] = dgvRow.Cells["TenTheLoai"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFileGenre(dataTable, "Thể loại", "DANH SÁCH THỂ LOẠI");
        }

        public void LoadListGenre()
        {
            bsGenreList.DataSource = TheLoaiBLL.Instance.GetListGenre();
        }

        private void CustomizedgvDSPhim()
        {
            dgvDSPhim.EnableHeadersVisualStyles = false;
            dgvDSPhim.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvDSPhim.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDSPhim.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDSPhim.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSPhim.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDSPhim.RowTemplate.Height = 30;

            dgvDSPhim.Columns["MaPhim"].HeaderText = "Mã phim";
            dgvDSPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvDSPhim.Columns["BieuTuongPL"].HeaderText = "Phân loại";
            dgvDSPhim.Columns["QuocGia"].HeaderText = "Quốc gia";
            dgvDSPhim.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgvDSPhim.Columns["NgayKhoiChieu"].HeaderText = "Ngày khởi chiếu";
            dgvDSPhim.Columns["TheLoaiPhim"].HeaderText = "Thể loại";

            dgvDSPhim.Columns["MaPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSPhim.Columns["ThoiLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSPhim.Columns["NgayKhoiChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDSPhim.Columns["MaPL"].Visible = false;
            dgvDSPhim.Columns["DaoDien"].Visible = false;
            dgvDSPhim.Columns["MoTa"].Visible = false;
            dgvDSPhim.Columns["Poster"].Visible = false;
            dgvDSPhim.Columns["Trailer"].Visible = false;
        }

        private void CustomizedgvTheLoai()
        {
            dgvTheLoai.EnableHeadersVisualStyles = false;
            dgvTheLoai.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvTheLoai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTheLoai.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTheLoai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTheLoai.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTheLoai.RowTemplate.Height = 30;

            dgvTheLoai.Columns["MaTL"].HeaderText = "Mã thể loại";
            dgvTheLoai.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
            dgvTheLoai.Columns["MaTL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetColumnWidthsInPercentagedgvDSPhim()
        {
            int totalWidth = dgvDSPhim.Width;

            dgvDSPhim.Columns["MaPhim"].Width = (int)(0.1 * totalWidth);
            dgvDSPhim.Columns["TenPhim"].Width = (int)(0.25 * totalWidth);
            dgvDSPhim.Columns["BieuTuongPL"].Width = (int)(0.1 * totalWidth);
            dgvDSPhim.Columns["QuocGia"].Width = (int)(0.1 * totalWidth);
            dgvDSPhim.Columns["ThoiLuong"].Width = (int)(0.1 * totalWidth);
            dgvDSPhim.Columns["NgayKhoiChieu"].Width = (int)(0.15 * totalWidth);
            dgvDSPhim.Columns["TheLoaiPhim"].Width = (int)(0.2 * totalWidth);

            dgvDSPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void SetColumnWidthsInPercentagedgvTheLoai()
        {
            int totalWidth = dgvTheLoai.Width;

            dgvTheLoai.Columns["MaTL"].Width = (int)(0.4 * totalWidth);
            dgvTheLoai.Columns["TenTheLoai"].Width = (int)(0.58 * totalWidth);

            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void BindingGenre()
        {
            txtMaTheLoai.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "MaTL", true, DataSourceUpdateMode.Never));
            txtTenTheLoai.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
        }

        public void ExportFileGenre(DataTable dataTable, string sheetName, string title)
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "B1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "13";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã thể loại";
            cl1.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên thể loại";
            cl2.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "B3");
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

        public void ExportFileMovie(DataTable dataTable, string sheetName, string title, string tenTheLoai)
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

            Microsoft.Office.Interop.Excel.Range cDate = oSheet.get_Range("G2", "H2");
            cDate.MergeCells = true;
            cDate.Value2 = "Thể loại: " + tenTheLoai;
            cDate.Font.Name = "Times New Roman";
            cDate.Font.Size = "11";
            cDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A4", "A4");
            cl1.Value2 = "Mã phim";
            cl1.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B4", "B4");
            cl2.Value2 = "Tên phim";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C4", "C4");
            cl3.Value2 = "Phân loại";
            cl3.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D4", "D4");
            cl4.Value2 = "Đạo diễn";
            cl4.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E4", "E4");
            cl5.Value2 = "Quốc gia";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F4", "F4");
            cl6.Value2 = "Thời lượng (phút)";
            cl6.ColumnWidth = 17;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G4", "G4");
            cl7.Value2 = "Ngày khời chiếu";
            cl7.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H4", "H4");
            cl8.Value2 = "Thể loại";
            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "H4");
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

            int rowStart = 5;
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
    }
}
