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

namespace qlPhim.UI.NhanVien
{
    public partial class frmChonGhe : Form
    {
        private Dictionary<string, bool> seatStatus = new Dictionary<string, bool>();
        public static List<string> selectedSeats = new List<string>();
        public static string maSC;
        public static double totalAmount = 0;

        public frmChonGhe()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count > 0)
            {
                this.Hide();
                frmBapnuoc f = new frmBapnuoc();
                f.Text = "Bắp - Nước";
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmChonGhe_FormClosing(object sender, FormClosingEventArgs e)
        {
            seatStatus = new Dictionary<string, bool>();
            selectedSeats = new List<string>();
            maSC = null;
            totalAmount = 0;
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            maSC = selectedRow.Cells["MaSC"].Value?.ToString();
            LoadSeat(maSC);

            string tenPhim = selectedRow.Cells["TenPhim"].Value?.ToString();
            string tenPhong = selectedRow.Cells["TenPhong"].Value?.ToString();
            string ngayChieu = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString()).ToString("dd/MM/yyyy");
            string gioBD = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString()).ToString("HH:mm");
            string gioKT = DateTime.Parse(selectedRow.Cells["ThoiGianKT"].Value?.ToString()).ToString("HH:mm");

            txtTenPhim.Text = tenPhim;
            txtPhong.Text = tenPhong;
            txtNgayChieu.Text = ngayChieu;
            txtGio.Text = $"{gioBD} ~ {gioKT}";
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
                            seatStatus[seat.MaGhe] = false;
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

                            btn.Click += (sender, e) =>
                            {
                                Button clickedButton = sender as Button;
                                string seatName = clickedButton.Text;
                                if (seatStatus[seatName])
                                {
                                    selectedSeats.Remove(seatName);
                                    totalAmount -= seat.GiaGhe;
                                }
                                else
                                {
                                    selectedSeats.Add(seatName);
                                    totalAmount += seat.GiaGhe;
                                }
                                txtGhe.Text = string.Join(", ", selectedSeats);
                                seatStatus[seatName] = !seatStatus[seatName];
                                UpdateSeatColor(clickedButton, seat);
                                txtTongTien.Text = string.Format("{0:N0} đ", totalAmount);
                            };
                        }
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(199, 200, 204);
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
                        btn.Click += (sender, e) =>
                        {
                            MessageBox.Show("Ghế này đã được đặt! Vui lòng chọn ghế khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                        break;
                }
                flpGhe.Controls.Add(btn);
            }
        }

        private void UpdateSeatColor(Button button, TinhTrangGheDAL seat)
        {
            if (seatStatus[seat.MaGhe])
            {
                button.BackColor = Color.Yellow;
            }
            else
            {
                switch (seat.MaLoaiGhe)
                {
                    case "GTHG":
                        button.BackColor = Color.FromArgb(0, 110, 230);
                        break;
                    case "GVIP":
                        button.BackColor = Color.FromArgb(231, 41, 41);
                        break;
                    default:
                        button.BackColor = Color.FromArgb(255, 113, 205);
                        break;
                }
            }
        }
    }
}
