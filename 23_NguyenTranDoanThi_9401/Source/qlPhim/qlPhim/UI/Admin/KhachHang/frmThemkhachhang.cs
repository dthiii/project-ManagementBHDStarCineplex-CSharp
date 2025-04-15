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

namespace qlPhim.UI.Admin.KhachHang
{
    public partial class frmThemkhachhang : Form
    {
        public frmThemkhachhang()
        {
            InitializeComponent();

            btnThem.Visible = true;
            btnLuu.Visible = false;
            cboBacThanhVien.Enabled = false;
            txtDiemTichLuy.Enabled = false;
            txtMaKH.Text = KhachHangBLL.Instance.GetNextMaKH();
            LoadListCustomerType();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (InsertCustomerToDatabase())
            {
                frmKhachhang f = Application.OpenForms.OfType<frmKhachhang>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListCustomer();
                }
                MessageBox.Show("Đã thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng vào CSDL.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (UpdateCustomerToDatabase())
            {
                frmKhachhang f = Application.OpenForms.OfType<frmKhachhang>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListCustomer();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thông tin khách hàng.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadListCustomerType()
        {
            cboBacThanhVien.DataSource = BacThanhVienBLL.Instance.GetListCustomerType();
            cboBacThanhVien.DisplayMember = "TenBacTV";
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            btnThem.Visible = false;
            btnLuu.Visible = true;
            cboBacThanhVien.Enabled = true;
            string maKH = selectedRow.Cells["MaKH"].Value?.ToString();
            txtMaKH.Text = maKH;
            txtHoKH.Text = selectedRow.Cells["HoKH"].Value?.ToString();
            txtTenKH.Text = selectedRow.Cells["TenKH"].Value?.ToString();
            txtDiemTichLuy.Text = selectedRow.Cells["DiemTichLuy"].Value?.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            txtDienThoai.Text = selectedRow.Cells["DienThoai"].Value?.ToString();
            txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
            dtpNgaySinh.Value = DateTime.Parse(selectedRow.Cells["NgaySinh"].Value?.ToString());
            foreach (BacThanhVienDAL item in cboBacThanhVien.Items)
            {
                if (item.MaBacTV == selectedRow.Cells["MaBacTV"].Value.ToString())
                {
                    cboBacThanhVien.SelectedItem = item;
                    break;
                }
            }
            string gioiTinh = selectedRow.Cells["GioiTinh"].Value?.ToString();
            switch (gioiTinh)
            {
                case "Nam":
                    rdoNam.Checked = true;
                    break;
                case "Nữ":
                    rdoNu.Checked = true;
                    break;
                default:
                    rdoKhac.Checked = true;
                    break;
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtHoKH.Text))
            {
                MessageBox.Show("Họ khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return false;
            }
            return true;
        }

        private bool InsertCustomerToDatabase()
        {
            string hoKH = txtHoKH.Text;
            string tenKH = txtTenKH.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            DateTime ngayDangKy = DateTime.Now;
            int diemTichLuy = !string.IsNullOrEmpty(txtDiemTichLuy.Text.Trim()) ? Convert.ToInt32(txtDiemTichLuy.Text) : 0;
            string dienThoai = txtDienThoai.Text;
            string email = !string.IsNullOrEmpty(txtEmail.Text.Trim()) ? txtEmail.Text.Trim() : null;
            string diaChi = !string.IsNullOrEmpty(txtDiaChi.Text.Trim()) ? txtDiaChi.Text.Trim() : null;

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

            BacThanhVienDAL bacTV = (BacThanhVienDAL)cboBacThanhVien.SelectedItem;
            string maBacTV = bacTV.MaBacTV;

            return KhachHangBLL.Instance.InsertCustomer(hoKH, tenKH, ngaySinh, gioiTinh, ngayDangKy, diemTichLuy, maBacTV, dienThoai, email, diaChi);
        }

        private bool UpdateCustomerToDatabase()
        {
            string maKH = txtMaKH.Text;
            string hoKH = txtHoKH.Text;
            string tenKH = txtTenKH.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            int diemTichLuy = !string.IsNullOrEmpty(txtDiemTichLuy.Text.Trim()) ? Convert.ToInt32(txtDiemTichLuy.Text) : 0;
            string dienThoai = txtDienThoai.Text;
            string email = !string.IsNullOrEmpty(txtEmail.Text.Trim()) ? txtEmail.Text.Trim() : null;
            string diaChi = !string.IsNullOrEmpty(txtDiaChi.Text.Trim()) ? txtDiaChi.Text.Trim() : null;

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

            BacThanhVienDAL bacTV = (BacThanhVienDAL)cboBacThanhVien.SelectedItem;
            string maBacTV = bacTV.MaBacTV;

            return KhachHangBLL.Instance.UpdateCustomer(maKH, hoKH, tenKH, ngaySinh, gioiTinh, diemTichLuy, maBacTV, dienThoai, email, diaChi);
        }
    }
}
