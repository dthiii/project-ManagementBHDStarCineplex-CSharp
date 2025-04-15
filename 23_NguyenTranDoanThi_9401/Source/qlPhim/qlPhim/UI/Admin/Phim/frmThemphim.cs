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

namespace qlPhim.UI.Admin.Phim
{
    public partial class frmThemphim : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string image = "";

        public frmThemphim()
        {
            InitializeComponent();

            btnThem.Visible = true;
            btnLuu.Visible = false;
            txtMaPhim.Text = PhimBLL.Instance.GetNextMaPhim();
            LoadGenre();
            LoadMovieRatingSystem();
            btnLuu.Location = new Point(762, 638);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (InsertMovieToDatabase() && InsertGenreMovieToDatabase())
            {
                frmPhim fMovie = Application.OpenForms.OfType<frmPhim>().FirstOrDefault();
                if (fMovie != null)
                {
                    fMovie.LoadListMovie();
                }
                MessageBox.Show("Đã thêm phim thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm phim vào CSDL.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (UpdateMovieToDatabase() && UpdateGenreMovieToDatabase())
            {
                frmPhim fMovie = Application.OpenForms.OfType<frmPhim>().FirstOrDefault();
                if (fMovie != null)
                {
                    fMovie.LoadListMovie();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin phim thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thông tin phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = ofd.FileName.ToString();
                picPoster.ImageLocation = image;
            }
        }

        void LoadGenre()
        {
            clbTheLoai.Items.Clear();
            List<TheLoaiDAL> listGenre = TheLoaiBLL.Instance.GetListGenre();
            foreach (TheLoaiDAL genre in listGenre)
            {
                clbTheLoai.Items.Add(genre.TenTheLoai);
            }
        }

        void LoadMovieRatingSystem()
        {
            cboPhanLoai.Items.Clear();
            List<PhanLoaiDAL> listMovieRatingSystem = PhanLoaiBLL.Instance.GetListMovieRatingSystem();
            cboPhanLoai.DataSource = listMovieRatingSystem;
            cboPhanLoai.DisplayMember = "MaPL";
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            btnThem.Visible = false;
            btnLuu.Visible = true;
            string maPhim = selectedRow.Cells["MaPhim"].Value?.ToString();
            CheckGenreInCheckListBox(maPhim);
            txtMaPhim.Text = maPhim;
            txtTenPhim.Text = selectedRow.Cells["TenPhim"].Value?.ToString();
            txtQuocGia.Text = selectedRow.Cells["QuocGia"].Value?.ToString();
            txtThoiLuong.Text = selectedRow.Cells["ThoiLuong"].Value?.ToString();
            txtDaoDien.Text = selectedRow.Cells["DaoDien"].Value?.ToString();
            txtNoiDung.Text = selectedRow.Cells["MoTa"].Value?.ToString();
            dtpNgayChieu.Value = DateTime.Parse(selectedRow.Cells["NgayKhoiChieu"].Value?.ToString());
            txtTrailer.Text = selectedRow.Cells["Trailer"].Value?.ToString();

            foreach (PhanLoaiDAL item in cboPhanLoai.Items)
            {
                if (item.MaPL == selectedRow.Cells["MaPL"].Value.ToString())
                {
                    cboPhanLoai.SelectedItem = item;
                    break;
                }
            }

            if (selectedRow.Cells["Poster"].Value != null)
            {
                byte[] posterData = (byte[])selectedRow.Cells["Poster"].Value;
                using (MemoryStream ms = new MemoryStream(posterData))
                {
                    picPoster.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }

        void CheckGenreInCheckListBox(string maPhim)
        {
            List<TheLoaiPhimDAL> genreMovies = TheLoaiPhimBLL.Instance.GetListGenreMovieByMovieID(maPhim);
            for (int i = 0; i < clbTheLoai.Items.Count; i++)
            {
                string genreName = clbTheLoai.Items[i].ToString();
                foreach (TheLoaiPhimDAL genreMovie in genreMovies)
                {
                    List<TheLoaiDAL> genreList = TheLoaiBLL.Instance.GetListGenreByGenreID(genreMovie.MaTL);
                    foreach (TheLoaiDAL genre in genreList)
                    {
                        if (genreName == genre.TenTheLoai)
                        {
                            clbTheLoai.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenPhim.Text))
            {
                MessageBox.Show("Tên phim không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPhim.Focus();
                return false;
            }
            if (!int.TryParse(txtThoiLuong.Text, out int thoiLuong) || thoiLuong <= 0)
            {
                MessageBox.Show("Thời lượng phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThoiLuong.Focus();
                return false;
            }
            if (!IsAtLeastOneItemChecked(clbTheLoai))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một thể loại phim.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsAtLeastOneItemChecked(CheckedListBox checkListBox)
        {
            bool atLeastOneChecked = false;
            foreach (object item in checkListBox.Items)
            {
                if (checkListBox.CheckedItems.Contains(item))
                {
                    atLeastOneChecked = true;
                    break;
                }
            }
            return atLeastOneChecked;
        }

        private bool InsertMovieToDatabase()
        {
            string tenPhim = txtTenPhim.Text.Trim();
            string maPL = cboPhanLoai.Text;
            string daoDien = !string.IsNullOrEmpty(txtDaoDien.Text.Trim()) ? txtDaoDien.Text.Trim() : null;
            string quocGia = !string.IsNullOrEmpty(txtQuocGia.Text.Trim()) ? txtQuocGia.Text.Trim() : null;
            int thoiLuong = int.Parse(txtThoiLuong.Text);
            DateTime ngayKhoiChieu = dtpNgayChieu.Value;
            string trailer = !string.IsNullOrEmpty(txtTrailer.Text.Trim()) ? txtTrailer.Text.Trim() : null;
            string moTa = !string.IsNullOrEmpty(txtNoiDung.Text.Trim()) ? txtNoiDung.Text.Trim() : null;
            byte[] poster = GetPosterData();

            return PhimBLL.Instance.InsertMovie(tenPhim, maPL, daoDien, quocGia, thoiLuong, ngayKhoiChieu, poster, trailer, moTa);
        }

        private byte[] GetPosterData()
        {
            byte[] poster = new byte[0];
            if (!string.IsNullOrEmpty(image))
            {
                using (FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        poster = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            return poster;
        }

        private byte[] GetCurrentPoster(string maPhim)
        {
            byte[] poster = PhimBLL.Instance.GetPosterByMovieID(maPhim);
            return poster ?? new byte[0];
        }

        private bool InsertGenreMovieToDatabase()
        {
            string maPhim = txtMaPhim.Text;
            List<string> selectedGenreIDs = GetSelectedGenreIDs();
            foreach (string genreID in selectedGenreIDs)
            {
                if (!TheLoaiPhimBLL.Instance.InsertGenreMovie(maPhim, genreID))
                {
                    return false;
                }
            }
            return true;
        }

        private List<string> GetSelectedGenreIDs()
        {
            List<string> selectedGenreIDs = new List<string>();
            foreach (int index in clbTheLoai.CheckedIndices)
            {
                string maTL = GetMaTLFromIndex(index);
                selectedGenreIDs.Add(maTL);
            }
            return selectedGenreIDs;
        }

        private string GetMaTLFromIndex(int index)
        {
            List<TheLoaiDAL> listGenre = TheLoaiBLL.Instance.GetListGenre();
            if (index >= 0 && index < listGenre.Count)
            {
                return listGenre[index].MaTL;
            }
            return null;
        }

        private bool UpdateMovieToDatabase()
        {
            string maPhim = txtMaPhim.Text.Trim();
            string tenPhim = txtTenPhim.Text.Trim();
            string maPL = cboPhanLoai.Text;
            string daoDien = !string.IsNullOrEmpty(txtDaoDien.Text.Trim()) ? txtDaoDien.Text.Trim() : null;
            string quocGia = !string.IsNullOrEmpty(txtQuocGia.Text.Trim()) ? txtQuocGia.Text.Trim() : null;
            int thoiLuong = int.Parse(txtThoiLuong.Text);
            DateTime ngayKhoiChieu = dtpNgayChieu.Value;
            string trailer = !string.IsNullOrEmpty(txtTrailer.Text.Trim()) ? txtTrailer.Text.Trim() : null;
            string moTa = !string.IsNullOrEmpty(txtNoiDung.Text.Trim()) ? txtNoiDung.Text.Trim() : null;
            byte[] poster = string.IsNullOrEmpty(image) ? GetCurrentPoster(maPhim) : GetPosterData();

            return PhimBLL.Instance.UpdateMovie(maPhim, tenPhim, maPL, daoDien, quocGia, thoiLuong, ngayKhoiChieu, poster, trailer, moTa);
        }

        private bool UpdateGenreMovieToDatabase()
        {
            string movieID = txtMaPhim.Text;
            if (TheLoaiPhimBLL.Instance.DeleteGenreMovie(movieID))
            {
                List<string> selectedGenreIDs = GetSelectedGenreIDs();
                foreach (string genreID in selectedGenreIDs)
                {
                    if (!TheLoaiPhimBLL.Instance.InsertGenreMovie(movieID, genreID))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
