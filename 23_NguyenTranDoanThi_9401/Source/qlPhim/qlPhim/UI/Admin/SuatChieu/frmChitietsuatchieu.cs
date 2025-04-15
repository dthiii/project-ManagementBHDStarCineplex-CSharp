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

namespace qlPhim.UI.Admin.SuatChieu
{
    public partial class frmChitietsuatchieu : Form
    {
        public frmChitietsuatchieu()
        {
            InitializeComponent();

            LoadRoom();
            LoadMovie();
            btnLuu.Location = new Point(200, 674);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cboPhong.Enabled = true;
            if (int.Parse(lblGheDaDat.Text) == 0)
            {
                cboTenPhim.Enabled = true;
                dtpNgayChieu.Enabled = true;
                dtpGioBD.Enabled = true;
            }
            btnLuu.Visible = true;
            btnSua.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (UpdateShowtimeToDatabase())
            {
                frmSuatchieu f = Application.OpenForms.OfType<frmSuatchieu>().FirstOrDefault();
                if (f != null)
                {
                    f.ShowShowtimes();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin suất chiếu thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                string message = $"Khoảng thời gian từ {dtpGioBD.Value.ToString("HH:mm")} đến {txtGioKT.Text} đã có phim chiếu tại {cboPhong.Text}";
                MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPhong.Text = tenPhong;
                cboTenPhim.Text = tenPhim;
                dtpNgayChieu.Value = ngayChieu;
                dtpGioBD.Value = gioChieu;
            }
            cboPhong.Enabled = false;
            cboTenPhim.Enabled = false;
            dtpNgayChieu.Enabled = false;
            dtpGioBD.Enabled = false;
            btnLuu.Visible = false;
            btnSua.Visible = true;
        }

        private void dtpGioBD_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dtpGioBD.Value.AddMinutes(thoiLuong);
            txtGioKT.Text = time.ToString("HH:mm");
        }

        int thoiLuong = 0;
        string maSC;
        string tenPhong;
        string tenPhim;
        DateTime ngayChieu;
        DateTime gioChieu;

        public void LoadData(DataGridViewRow selectedRow)
        {
            thoiLuong = int.Parse(selectedRow.Cells["ThoiLuong"].Value?.ToString());

            maSC = selectedRow.Cells["MaSC"].Value?.ToString();
            txtMaSC.Text = maSC;
            LoadSeat(maSC);

            foreach (PhongDAL item in cboPhong.Items)
            {
                if (item.MaPhong == selectedRow.Cells["MaPhong"].Value.ToString())
                {
                    cboPhong.SelectedItem = item;
                    tenPhong = item.TenPhong;
                    break;
                }
            }
            foreach (PhimDAL item in cboTenPhim.Items)
            {
                if (item.MaPhim == selectedRow.Cells["MaPhim"].Value.ToString())
                {
                    cboTenPhim.SelectedItem = item;
                    tenPhim = item.TenPhim;
                    break;
                }
            }
            ngayChieu = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString());
            dtpNgayChieu.Value = ngayChieu;
            gioChieu = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString());
            dtpGioBD.Value = gioChieu;
            txtGioKT.Text = DateTime.Parse(selectedRow.Cells["ThoiGianKT"].Value?.ToString()).ToString("HH:mm");

            lblGheTrong.Text = selectedRow.Cells["SoGheTrong"].Value?.ToString();
            lblTongGhe.Text = selectedRow.Cells["TongSoGhe"].Value?.ToString();
            int soGheDaDat = int.Parse(lblTongGhe.Text) - int.Parse(lblGheTrong.Text);
            lblGheDaDat.Text = soGheDaDat.ToString();
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

        private void LoadSeat(string maSC)
        {
            List<TinhTrangGheDAL> seatList = TinhTrangGheBLL.Instance.GetListSeatDetailByShowtimesID(maSC);

            foreach (TinhTrangGheDAL seat in seatList)
            {
                Button btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                switch (seat.MaLoaiGhe)
                {
                    case "GDOI":
                        btn.Width = 166;
                        btn.Height = 80;
                        break;
                    default:
                        btn.Width = 80;
                        btn.Height = 80;
                        break;
                }

                btn.Text = seat.MaGhe;

                switch (seat.TinhTrang)
                {
                    case "Trống":
                        {
                            switch (seat.MaLoaiGhe)
                            {
                                case "GTHG":
                                    btn.BackColor = Color.FromArgb(0, 110, 230);
                                    break;
                                case "GVIP":
                                    btn.BackColor = Color.FromArgb(231, 41, 41);
                                    break;
                                default:
                                    btn.BackColor = Color.FromArgb(255, 113, 205);
                                    break;
                            }
                        }
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(199, 200, 204);
                        btn.Enabled = false;
                        switch (seat.MaLoaiGhe)
                        {
                            case "GTHG":
                                btn.FlatAppearance.BorderSize = 1;
                                btn.FlatAppearance.BorderColor = Color.FromArgb(0, 110, 230);
                                break;
                            case "GVIP":
                                btn.FlatAppearance.BorderSize = 1;
                                btn.FlatAppearance.BorderColor = Color.FromArgb(231, 41, 41);
                                break;
                            default:
                                btn.FlatAppearance.BorderSize = 1;
                                btn.FlatAppearance.BorderColor = Color.FromArgb(255, 113, 205);
                                break;
                        }
                        break;
                }

                flpGhe.Controls.Add(btn);
            }
        }

        private bool UpdateShowtimeToDatabase()
        {
            string maSC = txtMaSC.Text;
            PhongDAL room = (PhongDAL)cboPhong.SelectedItem;
            string maPhong = room.MaPhong;
            PhimDAL movie = (PhimDAL)cboTenPhim.SelectedItem;
            string maPhim = movie.MaPhim;
            string ngayChieu = dtpNgayChieu.Value.ToString("dd/MM/yyyy");
            string gioBD = dtpGioBD.Value.ToString("HH:mm:ss");
            DateTime ngayGioChieu = DateTime.ParseExact(ngayChieu + " " + gioBD, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            return SuatChieuBLL.Instance.UpdateShowtimes(maSC, maPhong, maPhim, ngayGioChieu);
        }
    }
}
