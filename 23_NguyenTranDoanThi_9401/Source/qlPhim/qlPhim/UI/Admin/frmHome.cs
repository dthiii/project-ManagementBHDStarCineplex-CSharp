using qlPhim.DAL;
using qlPhim.UI.Admin.NhanVien;
using qlPhim.UI.Admin.Phim;
using qlPhim.UI.Admin.Phim.BapNuoc;
using qlPhim.UI.Admin.SuatChieu;
using qlPhim.UI.Admin.TheLoai;
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

namespace qlPhim.UI.Admin
{
    public partial class frmHome : Form
    {
        NhanVienDAL employee;

        frmPhim phim;
        frmTheloai theloai;
        frmSuatchieu suatchieu;
        frmBapnuoc bapnuoc;
        frmKhachhang khachhang;
        frmNhanvien nhanvien;
        frmThongke thongke;

        public frmHome(NhanVienDAL e)
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            this.employee = e;
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 66)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 250)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhim());
        }

        private void Phim_FormClosed(object sender, FormClosedEventArgs e)
        {
            phim = null;
        }

        private void btnTheloai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTheloai());
        }

        private void Theloai_FormClosed(object sender, FormClosedEventArgs e)
        {
            theloai = null;
        }

        private void btnSuatchieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSuatchieu());
        }

        private void Suatchieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            suatchieu = null;
        }

        private void btnBap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBapnuoc());
        }

        private void Bapnuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            bapnuoc = null;
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachhang());
        }

        private void Khachhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            khachhang = null;
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanvien());
        }

        private void Nhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            nhanvien = null;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongke());
        }

        private void Thongke_FormClosed(object sender, FormClosedEventArgs e)
        {
            thongke = null;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
