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
    public partial class frmSuatchieu : Form
    {
        private DataGridViewRow selectedRow;
        int soGheTrong = 0;

        public frmSuatchieu()
        {
            InitializeComponent();
        }

        private void frmSuatchieu_Load(object sender, EventArgs e)
        {
            LoadShowtimes();
            CustomizeDataGridView();
            SetColumnWidthsInPercentage();
            this.SizeChanged += frmSuatchieu_SizeChanged;
        }

        private void frmSuatchieu_SizeChanged(object sender, EventArgs e)
        {
            if (dgvSuatchieu.Columns.Count > 0)
            {
                SetColumnWidthsInPercentage();
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadShowtimes();
        }

        private void dgvSuatchieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSuatchieu.Columns[e.ColumnIndex].ValueType == typeof(DateTime))
            {
                if (e.Value != null)
                {
                    DateTime time = (DateTime)e.Value;
                    e.Value = time.ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }

            if (dgvSuatchieu.Columns[e.ColumnIndex].Name == "GheTrongTongGhe")
            {
                int soGheTrong = Convert.ToInt32(dgvSuatchieu.Rows[e.RowIndex].Cells["SoGheTrong"].Value);
                int tongSoGhe = Convert.ToInt32(dgvSuatchieu.Rows[e.RowIndex].Cells["TongSoGhe"].Value);
                string soGheDaDat = $"{soGheTrong} / {tongSoGhe}";
                e.Value = soGheDaDat;
                e.FormattingApplied = true;
                dgvSuatchieu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = soGheDaDat;
            }
        }

        private void dgvSuatchieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgvSuatchieu.Rows[e.RowIndex];
            soGheTrong = Convert.ToInt32(dgvSuatchieu.Rows[e.RowIndex].Cells["SoGheTrong"].Value);

            pnlMoiveInfo.Visible = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string gioBD = DateTime.Parse(dgvSuatchieu.Rows[e.RowIndex].Cells["ThoiGianBD"].Value?.ToString()).ToString("HH:mm");
                string gioKT = DateTime.Parse(dgvSuatchieu.Rows[e.RowIndex].Cells["ThoiGianKT"].Value?.ToString()).ToString("HH:mm");
                txtNgayGio.Text = $"{dtpNgayChieu.Value.ToString("dd/MM/yyyy")} {gioBD} ~ {gioKT}";

                string movieID = dgvSuatchieu.Rows[e.RowIndex].Cells["MaPhim"].Value.ToString();

                List<ChiTietPhimDAL> movieDetailsList = ChiTietPhimBLL.Instance.GetListMoiveDetailByMovieID(movieID);
                if (movieDetailsList != null && movieDetailsList.Count > 0)
                {
                    ChiTietPhimDAL movieDetail = movieDetailsList[0];
                    txtTenPhim.Text = movieDetail.TenPhim;
                    lblQuocGia.Text = movieDetail.QuocGia;
                    lblThoiLuong.Text = movieDetail.ThoiLuong.ToString() + " phút";
                    lblTheLoai.Text = movieDetail.TheLoaiPhim;

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

                    List<PhanLoaiDAL> phanLoaiList = PhanLoaiBLL.Instance.GetListMovieRatingSystemByID(movieDetail.MaPL);
                    if (phanLoaiList != null && phanLoaiList.Count > 0)
                    {
                        PhanLoaiDAL phanLoai = phanLoaiList[0];
                        lblPhanLoai.Text = phanLoai.TenPL;
                    }
                }
            }
        }

        private void dgvSuatchieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenShowtimesDetail(dgvSuatchieu.Rows[e.RowIndex]);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDateAndMovieName(dtpNgayChieu.Value, txtTimkiem.Text);
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            if (soGheTrong >= 0)
            {
                OpenShowtimesDetail(selectedRow);
            }
            else
            {
                MessageBox.Show("Suất chiếu này đã hết! Vui lòng chọn suất chiếu khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void LoadShowtimes()
        {
            DateTime ngayChieu = dtpNgayChieu.Value;
            dgvSuatchieu.DataSource = SuatChieuBLL.Instance.GetShowtimesByDate(ngayChieu);
        }

        private void CustomizeDataGridView()
        {
            DataGridViewTextBoxColumn gheTrongTongGheColumn = new DataGridViewTextBoxColumn();
            gheTrongTongGheColumn.Name = "GheTrongTongGhe";
            gheTrongTongGheColumn.HeaderText = "Số ghế trống";
            dgvSuatchieu.Columns.Add(gheTrongTongGheColumn);

            dgvSuatchieu.EnableHeadersVisualStyles = false;
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 190, 67);
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSuatchieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSuatchieu.RowTemplate.Height = 30;

            dgvSuatchieu.Columns["ThoiGianBD"].HeaderText = "Giờ bắt đầu";
            dgvSuatchieu.Columns["ThoiGianKT"].HeaderText = "Giờ kết thúc";
            dgvSuatchieu.Columns["TenPhong"].HeaderText = "Phòng chiếu";
            dgvSuatchieu.Columns["TenPhim"].HeaderText = "Tên phim";

            dgvSuatchieu.Columns["ThoiGianBD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.Columns["ThoiGianKT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.Columns["TenPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSuatchieu.Columns["GheTrongTongGhe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSuatchieu.Columns["MaSC"].Visible = false;
            dgvSuatchieu.Columns["MaPhong"].Visible = false;
            dgvSuatchieu.Columns["MaPhim"].Visible = false;
            dgvSuatchieu.Columns["ThoiLuong"].Visible = false;
            dgvSuatchieu.Columns["SoGheTrong"].Visible = false;
            dgvSuatchieu.Columns["TongSoGhe"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvSuatchieu.Width;
            if (dgvSuatchieu.Columns.Contains("GheTrongTongGhe"))
            {
                dgvSuatchieu.Columns["GheTrongTongGhe"].Width = (int)(0.2 * totalWidth);
            }
            dgvSuatchieu.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
            dgvSuatchieu.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
            dgvSuatchieu.Columns["TenPhong"].Width = (int)(0.15 * totalWidth);
            dgvSuatchieu.Columns["TenPhim"].Width = (int)(0.35 * totalWidth);
            dgvSuatchieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        private void OpenShowtimesDetail(DataGridViewRow selectedRow)
        {
            frmChonGhe f = new frmChonGhe();
            f.Text = "Chọn ghế";
            f.LoadData(selectedRow);
            f.ShowDialog();
        }

        private void frmSuatchieu_Resize(object sender, EventArgs e)
        {
            if (this.Width >= 1300)
            {
                txtTimkiem.Size = new Size(700, 35);
                btnTimkiem.Location = new Point(738, 85);
            }
            else
            {
                txtTimkiem.Size = new Size(347, 35);
                btnTimkiem.Location = new Point(385, 85);
            }
        }
    }
}
