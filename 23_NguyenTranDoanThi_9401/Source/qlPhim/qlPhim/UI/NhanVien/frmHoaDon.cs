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

namespace qlPhim.UI.NhanVien
{
    public partial class frmHoaDon : Form
    {
        NhanVienDAL employee;
        KhachHangDAL customer;

        private Dictionary<string, int> productList = new Dictionary<string, int>();
        private List<string> seatList = new List<string>();
        private string showtimesID;
        private double totalMovie = 0;
        private double totalProduct = 0;

        private double total = 0;
        private double cusDiscountPercent = 0;
        private double cusDiscount = 0;
        private double pay = 0;

        public frmHoaDon()
        {
            InitializeComponent();

            employee = frmHomeNV.employee;

            seatList = frmChonGhe.selectedSeats;
            showtimesID = frmChonGhe.maSC;
            totalMovie = frmChonGhe.totalAmount;
            productList = frmBapnuoc.productList;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadTotalPay();

            if (seatList.Count > 0)
            {
                LoadShowtimesInfo();
                if (productList.Count == 0)
                {
                    pnlProduct.Visible = false;
                    pnlMovie.Location = new Point(200, 22);
                    pnlKhachHang.Location = new Point(670, 22);
                    pnlTongTien.Location = new Point(670, 422);
                    btnTaoHD.Location = new Point(882, 635);
                }
            }
            else
            {
                if (productList.Count >= 0)
                {
                    pnlMovie.Visible = false;
                    pnlProduct.Location = new Point(200, 22);
                    pnlKhachHang.Location = new Point(670, 22);
                    pnlTongTien.Location = new Point(670, 422);
                    btnTaoHD.Location = new Point(882, 635);
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDienThoai.Text))
            {
                ShowCustomerInfo();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoKH.Text))
            {
                MessageBox.Show("Vui lòng nhập họ của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoKH.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }

            if (InsertCustomerToDatabase())
            {
                MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowCustomerInfo();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            pnlAddCustomer.Visible = false;
            pnlCustomerInfo.Visible = false;
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(Application.OpenForms["frmBapnuoc"] == null || Application.OpenForms["frmBapnuoc"].IsDisposed))
            {
                Application.OpenForms["frmBapnuoc"].Show();
                Application.OpenForms["frmBapnuoc"].Focus();
            }
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChietKhau.Text))
            {
                cusDiscountPercent = 0;
            }
            else
            {
                string chietKhau = txtChietKhau.Text.Replace("%", "");
                cusDiscountPercent = int.Parse(chietKhau);
            }
            LoadTotalPay();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (InsertBillToDatabase())
            {
                maHD = HoaDonBLL.Instance.GetMaHD(customer.MaKH, employee.MaNV, ngayTao);

                if (seatList.Count > 0)
                {
                    if (InsertTicketToDatabase())
                    {
                        if (productList.Count > 0)
                        {
                            if (InsertProductBillToDatabase())
                            {
                                PrintBill();
                            }
                        }
                        else
                        {
                            PrintBill();
                        }
                    }
                }
                else
                {
                    if (productList.Count > 0)
                    {
                        if (InsertProductBillToDatabase())
                        {
                            PrintBill();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình tạo hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadShowtimesInfo()
        {
            SuatChieuDAL showtimes = SuatChieuBLL.Instance.GetShowtimesByShowtimesID(showtimesID)[0];
            txtTenPhim.Text = showtimes.TenPhim;
            txtNgayChieu.Text = showtimes.ThoiGianBD.ToString("dd/MM/yyyy");
            txtGioChieu.Text = showtimes.ThoiGianBD.ToString("HH:mm") + " ~ " + showtimes.ThoiGianKT.ToString("HH:mm");
            txtPhong.Text = showtimes.TenPhong;
            txtGhe.Text = string.Join(", ", seatList);
            txtTienVe.Text = string.Format("{0:N0} đ", totalMovie);
        }

        private void LoadProducts()
        {
            foreach (KeyValuePair<string, int> pair in productList)
            {
                string productID = pair.Key;
                int quantity = pair.Value;

                SanPhamDAL product = SanPhamBLL.Instance.GetListProductByProductID(productID)[0];

                CreatePanelProduct(product.TenSP, quantity, product.GiaBan);
            }
            txtTienBapNuoc.Text = string.Format("{0:N0} đ", totalProduct);
        }

        private void CreatePanelProduct(string productName, int quantity, int price)
        {
            Panel pnlProducts = new Panel();
            pnlProducts.Size = new System.Drawing.Size(267, 60);
            flpSanPham.Controls.Add(pnlProducts);

            TextBox txtProductName = new TextBox();
            txtProductName.Size = new System.Drawing.Size(247, 23);
            txtProductName.Location = new System.Drawing.Point(9, 3);
            txtProductName.Font = new System.Drawing.Font(flpSanPham.Font, FontStyle.Bold);
            txtProductName.BackColor = Color.White;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.TextAlign = HorizontalAlignment.Left;
            txtProductName.Enabled = false;
            pnlProducts.Controls.Add(txtProductName);

            TextBox txtPriceQuantity = new TextBox();
            txtPriceQuantity.Size = new System.Drawing.Size(94, 23);
            txtPriceQuantity.Location = new System.Drawing.Point(9, 32);
            txtPriceQuantity.BackColor = Color.White;
            txtPriceQuantity.BorderStyle = BorderStyle.None;
            txtPriceQuantity.TextAlign = HorizontalAlignment.Left;
            txtPriceQuantity.Enabled = false;
            pnlProducts.Controls.Add(txtPriceQuantity);

            TextBox txtTotalAmount = new TextBox();
            txtTotalAmount.Size = new System.Drawing.Size(125, 23);
            txtTotalAmount.Location = new System.Drawing.Point(131, 32);
            txtTotalAmount.BackColor = Color.White;
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            txtTotalAmount.Enabled = false;
            pnlProducts.Controls.Add(txtTotalAmount);

            txtProductName.Text = productName;
            txtPriceQuantity.Text = string.Format("{0} x {1:N0} đ", quantity, price);
            txtTotalAmount.Text = string.Format("{0:N0} đ", price * quantity);

            totalProduct += (price * quantity);
        }

        private bool InsertCustomerToDatabase()
        {
            string gioiTinh;
            if (rdoNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                gioiTinh = "Khác";
            }

            return KhachHangBLL.Instance.InsertCustomer(txtHoKH.Text, txtTenKH.Text, gioiTinh, txtDienThoai.Text);
        }

        private void ShowCustomerInfo()
        {
            List<KhachHangDAL> customerList = KhachHangBLL.Instance.GetListCustomerByPhoneNumber(txtDienThoai.Text);
            if (customerList != null && customerList.Count > 0)
            {
                pnlCustomerInfo.Visible = true;
                pnlAddCustomer.Visible = false;
                txtTenKH.Clear();
                txtHoKH.Clear();

                customer = customerList[0];
                txtHoTenKH.Text = customer.HoKH + " " + customer.TenKH;
                txtDiemTichLuy.Text = customer.DiemTichLuy.ToString();

                List<BacThanhVienDAL> customerTypeList = BacThanhVienBLL.Instance.GetListCustomerTypeByCustomerTypeID(customer.MaBacTV);
                if (customerTypeList != null && customerTypeList.Count > 0)
                {
                    cusDiscountPercent = customerTypeList[0].ChietKhau;
                    txtChietKhau.Text = cusDiscountPercent.ToString() + "%";
                }
                btnTaoHD.Visible = true;
            }
            else
            {
                DialogResult result = MessageBox.Show($"Không tìm thấy khách hàng có số điện thoại {txtDienThoai.Text}.\r\n\r\nBạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    pnlCustomerInfo.Visible = false;
                    txtHoTenKH.Clear();
                    txtDiemTichLuy.Clear();
                    txtChietKhau.Clear();
                    pnlAddCustomer.Visible = true;
                    txtHoKH.Focus();
                }
                else
                {
                    pnlCustomerInfo.Visible = false;
                    txtHoTenKH.Clear();
                    txtDiemTichLuy.Clear();
                    txtChietKhau.Clear();
                    pnlAddCustomer.Visible = false;
                    txtTenKH.Clear();
                    txtHoKH.Clear();
                    txtDienThoai.Focus();
                }
            }
            LoadTotalPay();
        }

        private void LoadTotalPay()
        {
            total = totalMovie + totalProduct;
            cusDiscount = total * cusDiscountPercent / 100;
            pay = total - cusDiscount;

            txtTongTien.Text = string.Format("{0:N0} đ", total);
            txtKhuyenMai.Text = string.Format("{0:N0} đ", cusDiscount);
            txtTongThu.Text = string.Format("{0:N0} đ", pay);
        }

        string maHD;
        DateTime ngayTao;
        private bool InsertBillToDatabase()
        {
            ngayTao = DateTime.Now;
            return HoaDonBLL.Instance.InsertBill(customer.MaKH, employee.MaNV, ngayTao);
        }

        private bool InsertTicketToDatabase()
        {
            bool success = true;
            foreach (string seat in seatList)
            {
                bool insertResult = VeBLL.Instance.InsertTicketToBill(maHD, seat, showtimesID);
                if (!insertResult)
                {
                    success = false;
                }
            }
            return success;
        }

        private bool InsertProductBillToDatabase()
        {
            bool success = true;
            foreach (KeyValuePair<string, int> pair in productList)
            {
                string maSP = pair.Key;
                int soLuong = pair.Value;
                bool insertResult = HoaDonBapnuocBLL.Instance.InsertProductToBill(maHD, maSP, soLuong);
                if (!insertResult)
                {
                    success = false;
                }
            }
            return success;
        }

        private void PrintBill()
        {
            MessageBox.Show("Tạo hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Form form in Application.OpenForms)
            {
                if (form != Application.OpenForms["frmLogin"] && form.Visible == false)
                {
                    form.Close();
                }
            }

            DataTable data = DataProvider.Instance.ExecuteQuery($"EXEC dbo.sp_HoaDon_Ve N'{maHD}'");
            rptHoaDon r = new rptHoaDon();
            r.SetDataSource(data);
            frmReport f = new frmReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }
    }
}
