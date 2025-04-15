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
    public partial class frmThemNhanvien : Form
    {
        public frmThemNhanvien()
        {
            InitializeComponent();

            btnThem.Visible = true;
            btnLuu.Visible = false;
            txtMaNV.Text = NhanVienBLL.Instance.GetNextMaNV();
            LoadListEmployeeType();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (InsertEmployeeToDatabase())
            {
                frmNhanvien f = Application.OpenForms.OfType<frmNhanvien>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListEmployee();
                }
                MessageBox.Show("Đã thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm nhân viên vào CSDL.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (UpdateEmployeeToDatabase())
            {
                frmNhanvien f = Application.OpenForms.OfType<frmNhanvien>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListEmployee();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thông tin nhân viên.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadListEmployeeType()
        {
            cboChucVu.DataSource = ChucVuBLL.Instance.GetListEmployeeType();
            cboChucVu.DisplayMember = "TenCV";
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            btnThem.Visible = false;
            btnLuu.Visible = true;
            string maNV = selectedRow.Cells["MaNV"].Value?.ToString();
            txtMaNV.Text = maNV;
            txtHoNV.Text = selectedRow.Cells["HoNV"].Value?.ToString();
            txtTenNV.Text = selectedRow.Cells["TenNV"].Value?.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            txtDienThoai.Text = selectedRow.Cells["DienThoai"].Value?.ToString();
            txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
            dtpNgaySinh.Value = DateTime.Parse(selectedRow.Cells["NgaySinh"].Value?.ToString());
            dtpNgayVaoLam.Value = DateTime.Parse(selectedRow.Cells["NgayVaoLam"].Value?.ToString());
            foreach (ChucVuDAL item in cboChucVu.Items)
            {
                if (item.MaCV == selectedRow.Cells["MaCV"].Value.ToString())
                {
                    cboChucVu.SelectedItem = item;
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
            if (string.IsNullOrWhiteSpace(txtHoNV.Text))
            {
                MessageBox.Show("Họ nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoNV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return false;
            }
            return true;
        }

        private bool InsertEmployeeToDatabase()
        {
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            DateTime ngayVaoLam = dtpNgayVaoLam.Value;
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

            ChucVuDAL chucVu = (ChucVuDAL)cboChucVu.SelectedItem;
            string maCV = chucVu.MaCV;

            return NhanVienBLL.Instance.InsertEmployee(hoNV, tenNV, ngaySinh, gioiTinh, ngayVaoLam, maCV, dienThoai, email, diaChi);
        }

        private bool UpdateEmployeeToDatabase()
        {
            string maNV = txtMaNV.Text;
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            DateTime ngayVaoLam = dtpNgayVaoLam.Value;
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

            ChucVuDAL chucVu = (ChucVuDAL)cboChucVu.SelectedItem;
            string maCV = chucVu.MaCV;

            return NhanVienBLL.Instance.UpdateEmployee(maNV, hoNV, tenNV, ngaySinh, gioiTinh, ngayVaoLam, maCV, dienThoai, email, diaChi);
        }
    }
}
