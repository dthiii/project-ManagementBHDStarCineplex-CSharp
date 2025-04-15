using qlPhim.BLL;
using qlPhim.DAL;
using qlPhim.UI.Admin;
using qlPhim.UI.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlPhim.UI
{
    public partial class frmLogin : Form
    {
        NhanVienDAL employee;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbl_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;
            string passWord = txtMatKhau.Text;
            if (Login(userName, passWord))
            {
                EmployeeAccount(userName, passWord);
                switch (employee.MaCV)
                {
                    case "QL":
                        {
                            frmHome f = new frmHome(employee);
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            break;
                        }
                    case "NV":
                        {
                            frmHomeNV f = new frmHomeNV(employee);
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
            }
        }

        bool Login(string userName, string passWord)
        {
            return NhanVienBLL.Instance.Login(userName, passWord);
        }

        void EmployeeAccount(string userName, string passWord)
        {
            List<NhanVienDAL> employees = NhanVienBLL.Instance.GetEmployeeByAccount(userName, passWord);
            if (employees != null && employees.Count > 0)
            {
                employee = employees[0];
            }
        }

    }
}
