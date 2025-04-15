using qlPhim.BLL;
using qlPhim.DAL;
using qlPhim.UI.Admin.BapNuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.Phim.BapNuoc
{
    public partial class frmBapnuoc : Form
    {
        BindingSource bsProductList = new BindingSource();

        public frmBapnuoc()
        {
            InitializeComponent();
        }

        private void frmBapnuoc_Load(object sender, EventArgs e)
        {
            LoadListProduct();
            dgvSanPham.DataSource = bsProductList;
            BindingGenre();
            LoadProductType();
            CustomizeDataGridView();
            SetColumnWidthsInPercentage();
            this.SizeChanged += frmBapnuoc_SizeChanged;
        }

        private void frmBapnuoc_SizeChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.Columns.Count > 0)
            {
                SetColumnWidthsInPercentage();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThemmoi.Visible = true;
            btnHuy.Visible = true;
            ClearTextbox();
            txtTenSP.Focus();
            txtMaSP.Text = SanPhamBLL.Instance.GetNextMaSP();
            LoadProductType();
            picHinhSP.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            if (UpdateProductToDatabase())
            {
                MessageBox.Show("Đã chỉnh sửa sản phẩm phim thành công.", "Thông báo", MessageBoxButtons.OK);
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa sản phẩm.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (SanPhamBLL.Instance.DeleteProduct(txtMaSP.Text))
                {
                    MessageBox.Show("Đã xoá thể sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListProduct();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa sản phẩm.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            if (InsertProductToDatabase())
            {
                MessageBox.Show("Đã thêm sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK);
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThemmoi.Visible = false;
            btnHuy.Visible = false;
            ClearTextbox();
            txtMaSP.Clear();
            picHinhSP.Image = null;
            LoadProductType();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        string image = "";
        private void btnTaiHinh_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = ofd.FileName.ToString();
                picHinhSP.ImageLocation = image;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdoTenSP.Checked)
            {
                if (!string.IsNullOrEmpty(txtNhapTenSP.Text))
                {
                    bsProductList.DataSource = SanPhamBLL.Instance.GetListProductByProductName(txtNhapTenSP.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNhapTenSP.Focus();
                }
            }
            else
            {
                if (!int.TryParse(txtTu.Text, out int fromPrice) || fromPrice < 0)
                {
                    MessageBox.Show("Vui lòng nhập khoảng giá bán của sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTu.Focus();
                    return;
                }
                if (!int.TryParse(txtTu.Text, out int toPrice) || toPrice < 0)
                {
                    MessageBox.Show("Vui lòng nhập khoảng giá bán của sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDen.Focus();
                    return;
                }
                bsProductList.DataSource = SanPhamBLL.Instance.GetListProductByPrice(Convert.ToInt32(txtTu.Text), Convert.ToInt32(txtDen.Text));
            }
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            LoadListProduct();
            txtNhapTenSP.Clear();
            txtTu.Clear();
            txtDen.Clear();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThemmoi.Visible = false;
            btnHuy.Visible = false;

            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                string maLoaiSP = dgvSanPham.Rows[e.RowIndex].Cells["MaLoaiSP"].Value?.ToString();
                if (!string.IsNullOrEmpty(maLoaiSP))
                {
                    foreach (LoaiSanPhamDAL item in cboLoaiSP.Items)
                    {
                        if (item.MaLoaiSP == maLoaiSP)
                        {
                            cboLoaiSP.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void rdoTenSP_CheckedChanged(object sender, EventArgs e)
        {
            txtTu.Clear();
            txtDen.Clear();
        }

        private void rdoGia_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTenSP.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<SanPhamDAL> list = SanPhamBLL.Instance.GetListProduct();
            rptBapNuoc r = new rptBapNuoc();
            r.SetDataSource(list);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaSP");
            DataColumn col2 = new DataColumn("TenSP");
            DataColumn col3 = new DataColumn("GiaBan");
            DataColumn col4 = new DataColumn("SoLuongTon");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);

            foreach (DataGridViewRow dgvRow in dgvSanPham.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaSP"].Value;
                row[1] = dgvRow.Cells["TenSP"].Value;
                row[2] = dgvRow.Cells["GiaBan"].Value;
                row[3] = dgvRow.Cells["SoLuongTon"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFile(dataTable, "Sản phẩm", "DANH SÁCH SẢN PHẨM");
        }

        void LoadListProduct()
        {
            bsProductList.DataSource = SanPhamBLL.Instance.GetListProduct();
        }

        void LoadProductType()
        {
            cboLoaiSP.DataSource = LoaiSanPhamBLL.Instance.GetListProductType();
            cboLoaiSP.DisplayMember = "TenLoaiSP";
        }

        private void BindingGenre()
        {
            txtMaSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            txtTenSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtGia.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
            txtSoLuongTon.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "SoLuongTon", true, DataSourceUpdateMode.Never));
            picHinhSP.DataBindings.Add(new Binding("Image", dgvSanPham.DataSource, "HinhAnh", true, DataSourceUpdateMode.Never));

        }


        private void CustomizeDataGridView()
        {
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSanPham.RowTemplate.Height = 30;

            dgvSanPham.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["GiaBan"].HeaderText = "Đơn giá";
            dgvSanPham.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";

            dgvSanPham.Columns["MaSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSanPham.Columns["MaLoaiSP"].Visible = false;
            dgvSanPham.Columns["HinhAnh"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvSanPham.Width;

            dgvSanPham.Columns["MaSP"].Width = (int)(0.2 * totalWidth);
            dgvSanPham.Columns["TenSP"].Width = (int)(0.4 * totalWidth);
            dgvSanPham.Columns["GiaBan"].Width = (int)(0.2 * totalWidth);
            dgvSanPham.Columns["SoLuongTon"].Width = (int)(0.2 * totalWidth);

            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        void ClearTextbox()
        {
            txtTenSP.Clear();
            txtGia.Clear();
            txtSoLuongTon.Clear();
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
                return false;
            }
            if (!int.TryParse(txtGia.Text, out int thoiLuong) || thoiLuong < 0)
            {
                MessageBox.Show("Đơn giá của sản phẩm phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGia.Focus();
                return false;
            }
            if (!int.TryParse(txtSoLuongTon.Text, out int soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn của sản phẩm phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongTon.Focus();
                return false;
            }
            return true;
        }

        private bool InsertProductToDatabase()
        {
            string productName = txtTenSP.Text.Trim();
            LoaiSanPhamDAL productType = (LoaiSanPhamDAL)cboLoaiSP.SelectedItem;
            string productTypeID = productType.MaLoaiSP;
            int price = Convert.ToInt32(txtGia.Text);
            int quantityStock = Convert.ToInt32(txtSoLuongTon.Text);
            byte[] poster = GetPosterData();

            return SanPhamBLL.Instance.InsertProduct(productName, productTypeID, price, quantityStock, poster);
        }

        private bool UpdateProductToDatabase()
        {
            string productID = txtMaSP.Text.Trim();
            string productName = txtTenSP.Text.Trim();
            LoaiSanPhamDAL productType = (LoaiSanPhamDAL)cboLoaiSP.SelectedItem;
            string productTypeID = productType.MaLoaiSP;
            int price = Convert.ToInt32(txtGia.Text);
            int quantityStock = Convert.ToInt32(txtSoLuongTon.Text);
            byte[] poster = GetPosterData();

            return SanPhamBLL.Instance.UpdateProduct(productID, productName, productTypeID, price, quantityStock, poster);
        }

        private byte[] GetPosterData()
        {
            byte[] productImg = new byte[0];
            if (!string.IsNullOrEmpty(image))
            {
                using (FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        productImg = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            return productImg;
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");
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
            cl3.Value2 = "Đơn giá";
            cl3.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số lượng tồn";
            cl4.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");
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
    }
}
