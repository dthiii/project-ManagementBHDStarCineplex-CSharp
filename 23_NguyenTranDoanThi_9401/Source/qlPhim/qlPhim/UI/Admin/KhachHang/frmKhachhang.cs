﻿using qlPhim.BLL;
using qlPhim.DAL;
using qlPhim.UI.Admin.KhachHang;
using qlPhim.UI.Admin.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.Phim
{
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            LoadListCustomerType();
            LoadListCustomer();
            CustomizeDataGridView();
            SetColumnWidthsInPercentage();
            this.SizeChanged += frmKhachhang_SizeChanged;
        }

        private void frmKhachhang_SizeChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.Columns.Count > 0)
            {
                SetColumnWidthsInPercentage();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == dgvKhachHang.Columns["EditColumn"].Index)
            {
                frmThemkhachhang f = new frmThemkhachhang();
                f.Text = "Thông tin khách hàng";
                f.LoadData(dgvKhachHang.Rows[e.RowIndex]);
                f.ShowDialog();
            }

            if (e.ColumnIndex == dgvKhachHang.Columns["DeleteColumn"].Index)
            {
                if (MessageBox.Show("Bạn muốn xóa khách hàng này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string maKH = dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                    if (KhachHangBLL.Instance.DeleteCustomer(maKH))
                    {
                        MessageBox.Show("Đã xóa khách hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                        LoadListCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvKhachHang.Columns[e.ColumnIndex].Name;
            if (e.RowIndex == -1 || columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                return;
            }
            DataGridViewRow selectedRow = dgvKhachHang.CurrentRow;
            frmThemkhachhang f = new frmThemkhachhang();
            f.Text = "Thông tin khách hàng";
            f.LoadData(selectedRow);
            f.ShowDialog();
        }

        private void cboBacThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            BacThanhVienDAL customerType = (BacThanhVienDAL)cboBacThanhVien.SelectedItem;
            dgvKhachHang.DataSource = KhachHangBLL.Instance.GetListCustomerByCustomerTypeID(customerType.MaBacTV);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemkhachhang f = new frmThemkhachhang();
            f.Text = "Thêm khách hàng mới";
            f.ShowDialog();
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text))
            {
                dgvKhachHang.DataSource = KhachHangBLL.Instance.GetListCustomerByCustomerName(txtTenKH.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<KhachHangDAL> list = KhachHangBLL.Instance.GetListCustomer();
            rptKhachHang r = new rptKhachHang();
            r.SetDataSource(list);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaKH");
            DataColumn col2 = new DataColumn("HoKH");
            DataColumn col3 = new DataColumn("TenKH");
            DataColumn col4 = new DataColumn("NgaySinh");
            DataColumn col5 = new DataColumn("GioiTinh");
            DataColumn col6 = new DataColumn("NgayDangKy");
            DataColumn col7 = new DataColumn("DiemTichLuy");
            DataColumn col8 = new DataColumn("MaBacTV");
            DataColumn col9 = new DataColumn("DienThoai");
            DataColumn col10 = new DataColumn("Email");
            DataColumn col11 = new DataColumn("DiaChi");

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
            dataTable.Columns.Add(col11);

            foreach (DataGridViewRow dgvRow in dgvKhachHang.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaKH"].Value;
                row[1] = dgvRow.Cells["HoKH"].Value;
                row[2] = dgvRow.Cells["TenKH"].Value;
                row[3] = ((DateTime)dgvRow.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
                row[4] = dgvRow.Cells["GioiTinh"].Value;
                row[5] = ((DateTime)dgvRow.Cells["NgayDangKy"].Value).ToString("dd/MM/yyyy");
                row[6] = dgvRow.Cells["DiemTichLuy"].Value;
                row[7] = dgvRow.Cells["MaBacTV"].Value;
                row[8] = dgvRow.Cells["DienThoai"].Value;
                row[9] = dgvRow.Cells["Email"].Value;
                row[10] = dgvRow.Cells["DiaChi"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFile(dataTable, "Khách hàng", "DANH SÁCH KHÁCH HÀNG");
        }

        public void LoadListCustomer()
        {
            dgvKhachHang.DataSource = KhachHangBLL.Instance.GetListCustomer();
        }

        void LoadListCustomerType()
        {
            cboBacThanhVien.DataSource = BacThanhVienBLL.Instance.GetListCustomerType();
            cboBacThanhVien.DisplayMember = "TenBacTV";
        }

        private void CustomizeDataGridView()
        {
            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
            editImageColumn.Name = "EditColumn";
            editImageColumn.HeaderText = "Chỉnh sửa";
            editImageColumn.Image = Properties.Resources.edit;
            dgvKhachHang.Columns.Add(editImageColumn);

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "Xóa";
            deleteImageColumn.Image = Properties.Resources.delete;
            dgvKhachHang.Columns.Add(deleteImageColumn);

            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvKhachHang.RowTemplate.Height = 30;

            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns["HoKH"].HeaderText = "Họ khách hàng";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvKhachHang.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvKhachHang.Columns["NgayDangKy"].HeaderText = "Ngày đăng ký";
            dgvKhachHang.Columns["MaBacTV"].HeaderText = "Bậc thành viên";
            dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện thoại";

            dgvKhachHang.Columns["MaKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.Columns["TenKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.Columns["NgaySinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.Columns["NgayDangKy"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.Columns["MaBacTV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.Columns["DienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvKhachHang.Columns["DiemTichLuy"].Visible = false;
            dgvKhachHang.Columns["Email"].Visible = false;
            dgvKhachHang.Columns["DiaChi"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvKhachHang.Width;

            dgvKhachHang.Columns["MaKH"].Width = (int)(0.1 * totalWidth);
            dgvKhachHang.Columns["HoKH"].Width = (int)(0.18 * totalWidth);
            dgvKhachHang.Columns["TenKH"].Width = (int)(0.09 * totalWidth);
            dgvKhachHang.Columns["NgaySinh"].Width = (int)(0.1 * totalWidth);
            dgvKhachHang.Columns["GioiTinh"].Width = (int)(0.07 * totalWidth);
            dgvKhachHang.Columns["NgayDangKy"].Width = (int)(0.1 * totalWidth);
            dgvKhachHang.Columns["MaBacTV"].Width = (int)(0.1 * totalWidth);
            dgvKhachHang.Columns["DienThoai"].Width = (int)(0.15 * totalWidth);
            dgvKhachHang.Columns["EditColumn"].Width = (int)(0.055 * totalWidth);
            dgvKhachHang.Columns["DeleteColumn"].Width = (int)(0.055 * totalWidth);

            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã khách hàng";
            cl1.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ khách hàng";
            cl2.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tên khách hàng";
            cl3.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày sinh";
            cl4.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Giới tính";
            cl5.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Ngày đăng ký";
            cl6.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Điểm tích lũy";
            cl7.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Mã bậc TV";
            cl8.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Điện thoại";
            cl9.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Email";
            cl10.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Địa chỉ";
            cl11.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "K3");
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
