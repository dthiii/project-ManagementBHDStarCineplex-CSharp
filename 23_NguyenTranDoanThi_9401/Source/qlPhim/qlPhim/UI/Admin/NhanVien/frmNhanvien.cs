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

namespace qlPhim.UI.Admin.NhanVien
{
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            LoadListEmployee();
            CustomizeDataGridView();
            this.SizeChanged += frmNhanvien_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void frmNhanvien_SizeChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.Columns.Count > 0)
            {
                SetColumnWidthsInPercentage();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == dgvNhanVien.Columns["EditColumn"].Index)
            {
                frmThemNhanvien f = new frmThemNhanvien();
                f.Text = "Thông tin nhân viên";
                f.LoadData(dgvNhanVien.Rows[e.RowIndex]);
                f.ShowDialog();
            }

            if (e.ColumnIndex == dgvNhanVien.Columns["DeleteColumn"].Index)
            {
                if (MessageBox.Show("Bạn muốn xóa nhân viên này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string maNV = dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                    if (NhanVienBLL.Instance.DeleteEmployee(maNV))
                    {
                        MessageBox.Show("Đã xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK);
                        LoadListEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa nhân viên.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvNhanVien.Columns[e.ColumnIndex].Name;
            if (e.RowIndex == -1 || columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                return;
            }
            DataGridViewRow selectedRow = dgvNhanVien.CurrentRow;
            frmThemNhanvien f = new frmThemNhanvien();
            f.Text = "Thông tin nhân viên";
            f.LoadData(selectedRow);
            f.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                if (rdoMaNV.Checked)
                {
                    dgvNhanVien.DataSource = NhanVienBLL.Instance.GetListEmployeelByEmployeeID(txtTimkiem.Text);
                }
                else
                {
                    dgvNhanVien.DataSource = NhanVienBLL.Instance.GetListEmployeelByEmployeeName(txtTimkiem.Text);
                }
            }
            else
            {
                LoadListEmployee();
            }
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            txtTimkiem.Clear();
            LoadListEmployee();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanvien f = new frmThemNhanvien();
            f.Text = "Thêm nhân viên mới";
            f.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaNV");
            DataColumn col2 = new DataColumn("HoNV");
            DataColumn col3 = new DataColumn("TenNV");
            DataColumn col4 = new DataColumn("NgaySinh");
            DataColumn col5 = new DataColumn("GioiTinh");
            DataColumn col6 = new DataColumn("NgayVaoLam");
            DataColumn col7 = new DataColumn("MaCV");
            DataColumn col8 = new DataColumn("DienThoai");
            DataColumn col9 = new DataColumn("Email");
            DataColumn col10 = new DataColumn("DiaChi");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);

            foreach (DataGridViewRow dgvRow in dgvNhanVien.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaNV"].Value;
                row[1] = dgvRow.Cells["HoNV"].Value;
                row[2] = dgvRow.Cells["TenNV"].Value;
                row[3] = ((DateTime)dgvRow.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
                row[4] = dgvRow.Cells["GioiTinh"].Value;
                row[5] = ((DateTime)dgvRow.Cells["NgayVaoLam"].Value).ToString("dd/MM/yyyy");
                row[6] = dgvRow.Cells["MaCV"].Value;
                row[7] = dgvRow.Cells["DienThoai"].Value;
                row[8] = dgvRow.Cells["Email"].Value;
                row[9] = dgvRow.Cells["DiaChi"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFile(dataTable, "Nhân viên", "DANH SÁCH NHÂN VIÊN");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<NhanVienDAL> list = NhanVienBLL.Instance.GetListEmployee();
            rptNhanvien r = new rptNhanvien();
            r.SetDataSource(list);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        public void LoadListEmployee()
        {
            dgvNhanVien.DataSource = NhanVienBLL.Instance.GetListEmployee();
        }

        private void CustomizeDataGridView()
        {
            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
            editImageColumn.Name = "EditColumn";
            editImageColumn.HeaderText = "Chỉnh sửa";
            editImageColumn.Image = Properties.Resources.edit;
            dgvNhanVien.Columns.Add(editImageColumn);

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "Xóa";
            deleteImageColumn.Image = Properties.Resources.delete;
            dgvNhanVien.Columns.Add(deleteImageColumn);

            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNhanVien.RowTemplate.Height = 30;

            dgvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["HoNV"].HeaderText = "Họ nhân viên";
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày vào làm";
            dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";

            dgvNhanVien.Columns["MaNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns["TenNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns["NgayVaoLam"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns["DienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNhanVien.Columns["MaCV"].Visible = false;
            dgvNhanVien.Columns["Email"].Visible = false;
            dgvNhanVien.Columns["DiaChi"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvNhanVien.Width;

            dgvNhanVien.Columns["MaNV"].Width = (int)(0.1 * totalWidth);
            dgvNhanVien.Columns["HoNV"].Width = (int)(0.2 * totalWidth);
            dgvNhanVien.Columns["TenNV"].Width = (int)(0.1 * totalWidth);
            dgvNhanVien.Columns["NgaySinh"].Width = (int)(0.1 * totalWidth);
            dgvNhanVien.Columns["GioiTinh"].Width = (int)(0.1 * totalWidth);
            dgvNhanVien.Columns["NgayVaoLam"].Width = (int)(0.15 * totalWidth);
            dgvNhanVien.Columns["DienThoai"].Width = (int)(0.15 * totalWidth);
            dgvNhanVien.Columns["EditColumn"].Width = (int)(0.055 * totalWidth);
            dgvNhanVien.Columns["DeleteColumn"].Width = (int)(0.055 * totalWidth);

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã nhân viên";
            cl1.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ nhân viên";
            cl2.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tên nhân viên";
            cl3.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày sinh";
            cl4.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Giới tính";
            cl5.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Ngày vào làm";
            cl6.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Mã chức vụ";
            cl7.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Điện thoại";
            cl8.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Email";
            cl9.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Địa chỉ";
            cl10.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");
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
            Microsoft.Office.Interop.Excel.Range c03 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 2];
            Microsoft.Office.Interop.Excel.Range cN3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 2];
            oSheet.get_Range(c03, cN3).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            Microsoft.Office.Interop.Excel.Range c0N1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colEnd - 1];
            Microsoft.Office.Interop.Excel.Range cNN1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd - 1];
            oSheet.get_Range(c0N1, cNN1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            Microsoft.Office.Interop.Excel.Range c0N = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colEnd];
            Microsoft.Office.Interop.Excel.Range cNN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            oSheet.get_Range(c0N, cNN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }
    }
}
