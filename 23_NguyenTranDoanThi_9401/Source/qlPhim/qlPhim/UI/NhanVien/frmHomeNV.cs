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
    public partial class frmHomeNV : Form
    {
        public static NhanVienDAL employee;

        qlPhim.UI.NhanVien.frmSuatchieu suatchieu;
        qlPhim.UI.NhanVien.frmBapnuoc bapnuoc;

        public frmHomeNV(NhanVienDAL e)
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            employee = e;
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
            OpenChildForm(new qlPhim.UI.NhanVien.frmSuatchieu());
        }

        private void Phim_FormClosed(object sender, FormClosedEventArgs e)
        {
            suatchieu = null;
        }

        private void btnBap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new qlPhim.UI.NhanVien.frmBapnuoc());
        }

        private void Bapnuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            bapnuoc = null;
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
            childForm.MinimumSize = new Size(0, 0);
            childForm.MaximumSize = new Size(0, 0);
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
