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

namespace qlPhim.UI.Admin.SuatChieu
{
    public partial class frmSuatchieu : Form
    {
        public frmSuatchieu()
        {
            InitializeComponent();

            LoadMovie();
            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            dtpDen.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }

        private void frmSuatchieu_Load(object sender, EventArgs e)
        {
            LoadRoom();
            CustomizeDataGridView();
            this.SizeChanged += frmSuatchieu_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void frmSuatchieu_SizeChanged(object sender, EventArgs e)
        {
            if (dgvSuatchieu.Columns.Count > 0)
            {
                SetColumnWidthsInPercentage();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            foreach (Control control in flpPhong.Controls)
            {
                if (control is RadioButton && control != radioButton)
                {
                    RadioButton radioBtn = (RadioButton)control;
                    radioBtn.ForeColor = Color.Black;

                }
            }

            ShowShowtimes();

            if (radioButton == rdbAllRoom && radioButton.Checked)
            {
                dgvSuatchieu.Columns["TenPhong"].Visible = true;
                SetColumnWidthsInPercentage();
            }
            else
            {
                dgvSuatchieu.Columns["TenPhong"].Visible = false;
                SetColumnWidthsInPercentage();
            }
        }

        private void dgvPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == dgvSuatchieu.Columns["EditColumn"].Index)
            {
                frmChitietsuatchieu f = new frmChitietsuatchieu();
                f.Text = "Thông tin suất chiếu";
                f.LoadData(dgvSuatchieu.Rows[e.RowIndex]);
                f.ShowDialog();
            }

            if (e.ColumnIndex == dgvSuatchieu.Columns["DeleteColumn"].Index)
            {
                if (MessageBox.Show("Bạn muốn xóa suất chiếu này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string maSC = dgvSuatchieu.Rows[e.RowIndex].Cells["MaSC"].Value.ToString();
                    if (SuatChieuBLL.Instance.DeleteShowtimes(maSC))
                    {
                        MessageBox.Show("Đã xóa suất chiếu thành công.", "Thông báo", MessageBoxButtons.OK);
                        ShowShowtimes();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa suất chiếu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChitietsuatchieu f = new frmChitietsuatchieu();
            f.Text = "Thông tin suất chiếu";
            f.LoadData(dgvSuatchieu.Rows[e.RowIndex]);
            f.ShowDialog();
        }

        private void dgvPhim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSuatchieu.Columns[e.ColumnIndex].ValueType == typeof(DateTime))
            {
                if (e.Value != null)
                {
                    DateTime time = (DateTime)e.Value;
                    e.Value = time.ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }

            if (dgvSuatchieu.Columns[e.ColumnIndex].Name == "SoGheDaDat")
            {
                int soGheTrong = Convert.ToInt32(dgvSuatchieu.Rows[e.RowIndex].Cells["SoGheTrong"].Value);
                int tongSoGhe = Convert.ToInt32(dgvSuatchieu.Rows[e.RowIndex].Cells["TongSoGhe"].Value);
                string soGheDaDat = $"{tongSoGhe - soGheTrong} / {tongSoGhe}";
                e.Value = soGheDaDat;
                e.FormattingApplied = true;
                dgvSuatchieu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = soGheDaDat;
            }
        }

        private void dptNgay_ValueChanged(object sender, EventArgs e)
        {
            ShowShowtimes();
        }

        private void btnTimphim_Click(object sender, EventArgs e)
        {
            ShowShowtimes();
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            ckTenphim.Checked = false;
            ckGio.Checked = false;
            ShowShowtimes();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemsuatchieu f = new frmThemsuatchieu();
            f.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<SuatChieuDAL> list = SuatChieuBLL.Instance.GetShowtimesByDate(dptNgay.Value);
            rptSuatchieu r = new rptSuatchieu();
            r.SetDataSource(list);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaSC");
            DataColumn col2 = new DataColumn("TenPhong");
            DataColumn col3 = new DataColumn("TenPhim");
            DataColumn col4 = new DataColumn("ThoiGianBD");
            DataColumn col5 = new DataColumn("ThoiGianKT");
            DataColumn col6 = new DataColumn("SoGheDaDat");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);

            foreach (DataGridViewRow dgvRow in dgvSuatchieu.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaSC"].Value;
                row[1] = dgvRow.Cells["TenPhong"].Value;
                row[2] = dgvRow.Cells["TenPhim"].Value;
                row[3] = Convert.ToDateTime(dgvRow.Cells["ThoiGianBD"].Value).ToString("HH:mm");
                row[4] = Convert.ToDateTime(dgvRow.Cells["ThoiGianKT"].Value).ToString("HH:mm");
                row[5] = dgvRow.Cells["SoGheDaDat"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFile(dataTable, "Suất chiếu", "DANH SÁCH SUẤT CHIẾU", dptNgay.Value);
        }

        void LoadMovie()
        {
            cboTenPhim.Items.Clear();
            List<PhimDAL> listMovie = PhimBLL.Instance.GetMovieList();
            cboTenPhim.DataSource = listMovie;
            cboTenPhim.DisplayMember = "TenPhim";
        }

        RadioButton rdbAllRoom;
        void LoadRoom()
        {
            List<PhongDAL> roomList = PhongBLL.Instance.GetRoomList();

            rdbAllRoom = CreateRadioBtnRoom("Tất cả");
            rdbAllRoom.Padding = new Padding(16, 0, 0, 0);
            rdbAllRoom.CheckedChanged += RadioButton_CheckedChanged;
            rdbAllRoom.Checked = true;
            flpPhong.Controls.Add(rdbAllRoom);

            foreach (PhongDAL room in roomList)
            {
                RadioButton rdb = CreateRadioBtnRoom(room.TenPhong);
                rdb.Padding = new Padding(16, 0, 0, 0);
                rdb.CheckedChanged += RadioButton_CheckedChanged;
                rdb.Tag = room;
                flpPhong.Controls.Add(rdb);
            }
        }

        private RadioButton CreateRadioBtnRoom(string text)
        {
            RadioButton rdb = new RadioButton()
            {
                Width = PhongBLL.RoomWidth,
                Height = PhongBLL.RoomHeight,
                Text = text,
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.MiddleLeft,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Appearance = Appearance.Button,
                Checked = false
            };
            return rdb;
        }

        public void ShowShowtimes()
        {
            PhimDAL movie = (PhimDAL)cboTenPhim.SelectedItem;
            string maPhim = movie.MaPhim;
            DateTime tuGio = dtpTu.Value;
            DateTime denGio = dtpDen.Value;

            DateTime ngayChieu = dptNgay.Value;

            string maPhong = null;
            foreach (Control control in flpPhong.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    PhongDAL room = radioButton.Tag as PhongDAL;
                    if (room != null)
                    {
                        maPhong = room.MaPhong.ToString();
                    }
                    break;
                }
            }

            if (maPhong == null)
            {
                if (!ckTenphim.Checked && !ckGio.Checked)
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDate(ngayChieu);
                }
                else if (ckTenphim.Checked && !ckGio.Checked)
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateAndMovieID(ngayChieu, maPhim);
                }
                else if (!ckTenphim.Checked && ckGio.Checked)
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateAndMovieTime(ngayChieu, tuGio, denGio);
                }
                else
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateAndMovieIDMovieTime(ngayChieu, maPhim, tuGio, denGio);
                }
            }
            else
            {
                if (!ckTenphim.Checked && !ckGio.Checked)
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateAndRoomID(ngayChieu, maPhong);
                }
                else if (ckTenphim.Checked && !ckGio.Checked)
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateRoomIDAndMovieID(ngayChieu, maPhong, maPhim);
                }
                else if (!ckTenphim.Checked && ckGio.Checked)
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateRoomIDAndMovieTime(ngayChieu, maPhong, tuGio, denGio);
                }
                else
                {
                    dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateRoomIDAndMovieIDMovieTime(ngayChieu, maPhong, maPhim, tuGio, denGio);
                }
            }
        }

        private void CustomizeDataGridView()
        {
            DataGridViewTextBoxColumn soGheDaDatColumn = new DataGridViewTextBoxColumn();
            soGheDaDatColumn.Name = "SoGheDaDat";
            soGheDaDatColumn.HeaderText = "Số ghế đã đặt";
            dgvSuatchieu.Columns.Add(soGheDaDatColumn);

            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
            editImageColumn.Name = "EditColumn";
            editImageColumn.HeaderText = "Chỉnh sửa";
            editImageColumn.Image = Properties.Resources.edit;
            dgvSuatchieu.Columns.Add(editImageColumn);

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "Xóa";
            deleteImageColumn.Image = Properties.Resources.delete;
            dgvSuatchieu.Columns.Add(deleteImageColumn);

            dgvSuatchieu.EnableHeadersVisualStyles = false;
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSuatchieu.RowTemplate.Height = 30;

            dgvSuatchieu.Columns["MaSC"].HeaderText = "Mã suất chiếu";
            dgvSuatchieu.Columns["ThoiGianBD"].HeaderText = "Giờ bắt đầu";
            dgvSuatchieu.Columns["ThoiGianKT"].HeaderText = "Giờ kết thúc";
            dgvSuatchieu.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvSuatchieu.Columns["TenPhim"].HeaderText = "Tên phim";

            dgvSuatchieu.Columns["MaSC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.Columns["ThoiGianBD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.Columns["ThoiGianKT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.Columns["TenPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.Columns["SoGheDaDat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSuatchieu.Columns["MaPhong"].Visible = false;
            dgvSuatchieu.Columns["MaPhim"].Visible = false;
            dgvSuatchieu.Columns["ThoiLuong"].Visible = false;
            dgvSuatchieu.Columns["SoGheTrong"].Visible = false;
            dgvSuatchieu.Columns["TongSoGhe"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvSuatchieu.Width;
            if (dgvSuatchieu.Columns.Contains("EditColumn") && dgvSuatchieu.Columns.Contains("DeleteColumn") && dgvSuatchieu.Columns.Contains("SoGheDaDat"))
            {
                dgvSuatchieu.Columns["EditColumn"].Width = (int)(0.07 * totalWidth);
                dgvSuatchieu.Columns["DeleteColumn"].Width = (int)(0.07 * totalWidth);
                dgvSuatchieu.Columns["SoGheDaDat"].Width = (int)(0.13 * totalWidth);
            }
            if (dgvSuatchieu.Columns["TenPhong"].Visible is false)
            {
                dgvSuatchieu.Columns["MaSC"].Width = (int)(0.13 * totalWidth);
                dgvSuatchieu.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
                dgvSuatchieu.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
                dgvSuatchieu.Columns["TenPhim"].Width = (int)(0.3 * totalWidth);
            }
            else
            {
                dgvSuatchieu.Columns["MaSC"].Width = (int)(0.13 * totalWidth);
                dgvSuatchieu.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
                dgvSuatchieu.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
                dgvSuatchieu.Columns["TenPhong"].Width = (int)(0.1 * totalWidth);
                dgvSuatchieu.Columns["TenPhim"].Width = (int)(0.2 * totalWidth);
            }

            dgvSuatchieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title, DateTime date)
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cDate = oSheet.get_Range("E2", "F2");
            cDate.MergeCells = true;
            cDate.Value2 = "Ngày chiếu: " + date.ToString("dd/MM/yyyy");
            cDate.Font.Name = "Times New Roman";
            cDate.Font.Size = "11";
            cDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A4", "A4");
            cl1.Value2 = "Mã suất chiếu";
            cl1.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B4", "B4");
            cl2.Value2 = "Tên phòng";
            cl2.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C4", "C4");
            cl3.Value2 = "Tên phim";
            cl3.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D4", "D4");
            cl4.Value2 = "Giờ bắt đầu";
            cl4.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E4", "E4");
            cl5.Value2 = "Giờ kết thúc";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F4", "F4");
            cl6.Value2 = "Số ghế đã đặt";
            cl6.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "F4");
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

            Microsoft.Office.Interop.Excel.Range c03 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 2];
            Microsoft.Office.Interop.Excel.Range cN3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 2];
            oSheet.get_Range(c03, cN3).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }
    }
}
