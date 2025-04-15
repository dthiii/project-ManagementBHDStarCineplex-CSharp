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

namespace qlPhim.UI.Admin.SuatChieu
{
    public partial class frmThemsuatchieu : Form
    {
        public frmThemsuatchieu()
        {
            InitializeComponent();

            LoadRoom();
            LoadMovie();
            txtMaSC.Text = SuatChieuBLL.Instance.GetNextShowtimesID();
            dtpGioChieu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
        }

        private void frmThemsuatchieu_Load(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        int thoiLuong = 0;

        private void cboTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            showtimesInfo();

            PhimDAL movie = (PhimDAL)cboTenPhim.SelectedItem;
            string maPhim = movie.MaPhim;
            List<ChiTietPhimDAL> movieList = ChiTietPhimBLL.Instance.GetListMoiveDetailByMovieID(maPhim);
            if (movieList != null && movieList.Count > 0)
            {
                ChiTietPhimDAL movieDetail = movieList[0];
                thoiLuong = movieDetail.ThoiLuong;
                if (movieDetail.Poster != null)
                {
                    byte[] posterData = (byte[])movieDetail.Poster;
                    using (MemoryStream ms = new MemoryStream(posterData))
                    {
                        picPoster.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picPoster.Image = null;
                }
            }
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        private void dtpGioChieu_ValueChanged(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (InsertShowtimeToDatabase())
            {
                frmSuatchieu f = Application.OpenForms.OfType<frmSuatchieu>().FirstOrDefault();
                if (f != null)
                {
                    f.ShowShowtimes();
                }
                MessageBox.Show("Đã thêm suất chiếu thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                string finish = dtpGioChieu.Value.AddMinutes(thoiLuong).ToString("HH:mm");
                string message = $"Khoảng thời gian từ {dtpGioChieu.Value.ToString("HH:mm")} đến {finish} đã có phim chiếu tại {cboPhong.Text}";
                MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadRoom()
        {
            cboPhong.Items.Clear();
            List<PhongDAL> listRoom = PhongBLL.Instance.GetRoomList();
            cboPhong.DataSource = listRoom;
            cboPhong.DisplayMember = "TenPhong";
        }

        void LoadMovie()
        {
            cboTenPhim.Items.Clear();
            List<PhimDAL> listMovie = PhimBLL.Instance.GetMovieList();
            cboTenPhim.DataSource = listMovie;
            cboTenPhim.DisplayMember = "TenPhim";
        }

        private bool InsertShowtimeToDatabase()
        {
            PhongDAL room = (PhongDAL)cboPhong.SelectedItem;
            string maPhong = room.MaPhong;
            PhimDAL movie = (PhimDAL)cboTenPhim.SelectedItem;
            string maPhim = movie.MaPhim;
            string ngayChieu = dtpNgayChieu.Value.ToString("dd/MM/yyyy");
            string gioBD = dtpGioChieu.Value.ToString("HH:mm:ss");
            DateTime ngayGioChieu = DateTime.ParseExact(ngayChieu + " " + gioBD, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            return SuatChieuBLL.Instance.InsertShowtimes(maPhong, maPhim, ngayGioChieu);
        }

        void showtimesInfo()
        {
            lblTenPhim.Text = cboTenPhim.Text;
            lblNgayChieu.Text = dtpNgayChieu.Value.ToString("dd/MM/yyyy");
            lblGioChieu.Text = dtpGioChieu.Value.ToString("HH:mm") + " ~ " + dtpGioChieu.Value.AddMinutes(thoiLuong).ToString("HH:mm");
            lblPhong.Text = cboPhong.Text;
        }
    }
}
