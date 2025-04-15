using qlPhim.BLL;
using qlPhim.DAL;
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

namespace qlPhim.UI.NhanVien
{
    public partial class frmBapnuoc : Form
    {
        public static Dictionary<string, int> productList = new Dictionary<string, int>();
        private List<string> seatList = new List<string>();

        public frmBapnuoc()
        {
            InitializeComponent();

            seatList = frmChonGhe.selectedSeats;
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPhamDAL prod = (SanPhamDAL)cboTenSP.SelectedItem;
            string productID = prod.MaSP;

            List<SanPhamDAL> productList = SanPhamBLL.Instance.GetListProductByProductID(productID);
            if (productList != null && productList.Count > 0)
            {
                SanPhamDAL product = productList[0];
                txtSoLuongTon.Text = product.SoLuongTon.ToString();
                txtGia.Text = product.GiaBan.ToString();

                if (product.HinhAnh != null)
                {
                    byte[] posterData = (byte[])product.HinhAnh;
                    using (MemoryStream ms = new MemoryStream(posterData))
                    {
                        picHinhSP.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picHinhSP.Image = null;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsValidQuantity())
            {
                return;
            }

            SanPhamDAL sanPham = (SanPhamDAL)cboTenSP.SelectedItem;
            int soLuong = int.Parse(txtSoLuong.Text);
            int donGia = int.Parse(txtGia.Text);
            int thanhTien = int.Parse(txtSoLuong.Text) * int.Parse(txtGia.Text);

            dgvSanPham.Rows.Add(sanPham.MaSP, sanPham.TenSP, donGia, soLuong, thanhTien);
            CalculateTotalPrice();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSanPham.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvSanPham.Rows.RemoveAt(rowIndex);
                    CalculateTotalPrice();
                }
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            SaveProductList();
            if (seatList.Count > 0)
            {
                this.Hide();
                frmHoaDon f = new frmHoaDon();
                f.Text = "Thông tin hóa đơn";
                f.ShowDialog();
            }
            else
            {
                if (productList.Count > 0)
                {
                    frmHoaDon f = new frmHoaDon();
                    f.Text = "Thông tin hóa đơn";
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmBapnuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(Application.OpenForms["fEShowtimesDetail"] == null || Application.OpenForms["fEShowtimesDetail"].IsDisposed))
            {
                Application.OpenForms["fEShowtimesDetail"].Show();
                Application.OpenForms["fEShowtimesDetail"].Focus();
                productList = new Dictionary<string, int>();
            }
        }

        private void frmBapnuoc_Load(object sender, EventArgs e)
        {
            LoadProduct();
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

        void LoadProduct()
        {
            cboTenSP.Items.Clear();
            List<SanPhamDAL> list = SanPhamBLL.Instance.GetListProduct();
            cboTenSP.DataSource = list;
            cboTenSP.DisplayMember = "TenSP";
        }

        private void CustomizeDataGridView()
        {
            AddColumnDataGridView("MaSP", "Mã sản phẩm");
            AddColumnDataGridView("TenSP", "Sản phẩm");
            AddColumnDataGridView("GiaBan", "Đơn giá");
            AddColumnDataGridView("SoLuong", "Số lượng");
            AddColumnDataGridView("ThanhTien", "Thành tiền");

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "";
            dgvSanPham.Columns.Add(deleteImageColumn);

            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dgvSanPham.RowTemplate.Height = 30;

            dgvSanPham.Columns["TenSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSanPham.Columns["MaSP"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvSanPham.Width;
            dgvSanPham.Columns["TenSP"].Width = (int)(0.3 * totalWidth);
            dgvSanPham.Columns["GiaBan"].Width = (int)(0.2 * totalWidth);
            dgvSanPham.Columns["SoLuong"].Width = (int)(0.2 * totalWidth);
            dgvSanPham.Columns["ThanhTien"].Width = (int)(0.25 * totalWidth);
            dgvSanPham.Columns["DeleteColumn"].Width = (int)(0.05 * totalWidth);
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void AddColumnDataGridView(string colName, string colHeader)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = colName;
            column.HeaderText = colHeader;
            dgvSanPham.Columns.Add(column);
        }

        private bool IsValidQuantity()
        {
            if (!string.IsNullOrEmpty(txtSoLuong.Text))
            {
                if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong > 0)
                {
                    if (soLuong <= int.Parse(txtSoLuongTon.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng nhập vào phải nhỏ hơn hoặc bằng số lượng tồn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoLuong.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return false;
            }
        }

        private void CalculateTotalPrice()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (!row.IsNewRow)
                {
                    double thanhTien = Convert.ToDouble(row.Cells["ThanhTien"].Value);
                    tongTien += thanhTien;
                }
            }

            txtTongTien.Text = string.Format("{0:N0} đ", tongTien);
        }

        private void SaveProductList()
        {
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (!row.IsNewRow && row.Cells["MaSP"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    string maSanPham = row.Cells["MaSP"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    productList[maSanPham] = soLuong;
                }
            }
        }
    }
}
