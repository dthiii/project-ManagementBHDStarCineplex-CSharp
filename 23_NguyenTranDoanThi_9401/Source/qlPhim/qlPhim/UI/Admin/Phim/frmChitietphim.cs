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

namespace qlPhim.UI.Admin.Phim
{
    public partial class frmChitietphim : Form
    {
        public frmChitietphim()
        {
            InitializeComponent();
        }

        string trailerURL = "";
        public void LoadData(DataGridViewRow selectedRow)
        {
            lblMaPhim.Text = selectedRow.Cells["MaPhim"].Value?.ToString();
            lblTenPhim.Text = selectedRow.Cells["TenPhim"].Value?.ToString().ToUpper();
            txtQuocGia.Text = selectedRow.Cells["QuocGia"].Value?.ToString();
            txtThoiLuong.Text = selectedRow.Cells["ThoiLuong"].Value?.ToString();
            txtDaoDien.Text = selectedRow.Cells["DaoDien"].Value?.ToString();
            txtTheLoai.Text = selectedRow.Cells["TheLoaiPhim"].Value?.ToString();
            txtNoiDung.Text = selectedRow.Cells["MoTa"].Value?.ToString();
            txtNgayChieu.Text = DateTime.Parse(selectedRow.Cells["NgayKhoiChieu"].Value?.ToString()).ToString("dd/MM/yyyy");
            trailerURL = selectedRow.Cells["Trailer"].Value?.ToString();

            if (selectedRow.Cells["BieuTuongPL"].Value != null)
            {
                byte[] bieuTuongPL = (byte[])selectedRow.Cells["BieuTuongPL"].Value;
                using (MemoryStream ms = new MemoryStream(bieuTuongPL))
                {
                    picPhanLoai.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picPhanLoai.Image = null;
            }

            if (selectedRow.Cells["Poster"].Value != null)
            {
                byte[] posterData = (byte[])selectedRow.Cells["Poster"].Value;
                using (MemoryStream ms = new MemoryStream(posterData))
                {
                    picPoster.Image = Image.FromStream(ms);
                }
            }
        }

        private void frmChitietphim_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(trailerURL))
            {
                btnTrailer.Visible = false;
            }
            else
            {
                btnTrailer.Enabled = true;
            }
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            frmTrailer f = new frmTrailer(trailerURL);
            f.ShowDialog();
        }

        private void btnTrailer_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnTrailer_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
