using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class SuatChieuBLL
    {
        private static SuatChieuBLL instance;

        public static SuatChieuBLL Instance
        {
            get => instance == null ? instance = new SuatChieuBLL() : instance;
            private set => instance = value;
        }

        private SuatChieuBLL() { }

        public string GetNextShowtimesID()
        {
            string query = "SELECT 'SC' + RIGHT('000' + CAST(MAX(RIGHT(MaSC, 3)) + 1 AS VARCHAR(3)), 3) FROM SuatChieu";
            string showtimesID = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return showtimesID;
        }

        public List<SuatChieuDAL> GetShowtimesByShowtimesID(string showtimesID)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE MaSC = N'{showtimesID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDate(DateTime date)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string query = String.Format("SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{0}' ORDER BY ThoiGian ASC", ngayChieu);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateAndRoomID(DateTime date, string maPhong)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string query = String.Format("SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{0}' AND MaPhong = N'{1}' ORDER BY ThoiGian ASC", ngayChieu, maPhong);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateAndMovieID(DateTime date, string movieID)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{ngayChieu}' AND MaPhim = N'{movieID}' ORDER BY ThoiGian ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateAndMovieTime(DateTime date, DateTime start, DateTime finish)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string tuGio = start.ToString("HH:mm");
            string denGio = finish.ToString("HH:mm");
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{ngayChieu}' AND CONVERT(TIME, ThoiGian) BETWEEN '{tuGio}' AND '{denGio}' ORDER BY ThoiGian ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateAndMovieIDMovieTime(DateTime date, string movieID, DateTime start, DateTime finish)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string tuGio = start.ToString("HH:mm");
            string denGio = finish.ToString("HH:mm");
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{ngayChieu}' AND MaPhim = N'{movieID}' AND CONVERT(TIME, ThoiGian) BETWEEN '{tuGio}' AND '{denGio}' ORDER BY ThoiGian ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateRoomIDAndMovieID(DateTime date, string maPhong, string movieID)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{ngayChieu}' AND MaPhong = N'{maPhong}' AND MaPhim = N'{movieID}' ORDER BY ThoiGian ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateRoomIDAndMovieTime(DateTime date, string maPhong, DateTime start, DateTime finish)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string tuGio = start.ToString("HH:mm");
            string denGio = finish.ToString("HH:mm");
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{ngayChieu}' AND MaPhong = N'{maPhong}' AND CONVERT(TIME, ThoiGian) BETWEEN '{tuGio}' AND '{denGio}' ORDER BY ThoiGian ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateRoomIDAndMovieIDMovieTime(DateTime date, string maPhong, string movieID, DateTime start, DateTime finish)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string tuGio = start.ToString("HH:mm");
            string denGio = finish.ToString("HH:mm");
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{ngayChieu}' AND MaPhong = N'{maPhong}' AND MaPhim = N'{movieID}' AND CONVERT(TIME, ThoiGian) BETWEEN '{tuGio}' AND '{denGio}' ORDER BY ThoiGian ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<SuatChieuDAL> GetShowtimesByDateAndMovieName(DateTime date, string movieName)
        {
            List<SuatChieuDAL> list = new List<SuatChieuDAL>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string query = $"SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{ngayChieu}' AND TenPhim LIKE N'%{movieName}%' ORDER BY ThoiGian ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SuatChieuDAL showtimes = new SuatChieuDAL(item);
                list.Add(showtimes);
            }
            return list;
        }

        public bool InsertShowtimes(string maPhong, string maPhim, DateTime thoiGian)
        {
            try
            {
                string query = "INSERT INTO SuatChieu(MaSC, MaPhong, MaPhim, ThoiGian) VALUES (dbo.f_AutoMaSC(), @maPhong , @maPhim , @thoiGian )";
                object[] parameters = new object[]
                {
                    maPhong,
                    maPhim,
                    thoiGian
                };
                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool UpdateShowtimes(string maSC, string maPhong, string maPhim, DateTime thoiGian)
        {
            try
            {
                string query = "UPDATE SuatChieu SET MaPhong = @maPhong , MaPhim = @maPhim , ThoiGian = @thoiGian WHERE MaSC = @maSC";
                object[] parameters = new object[]
                {
                    maPhong,
                    maPhim,
                    thoiGian,
                    maSC
                };
                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool DeleteShowtimes(string maSC)
        {
            string query = string.Format("DELETE SuatChieu WHERE MaSC = N'{0}'", maSC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
