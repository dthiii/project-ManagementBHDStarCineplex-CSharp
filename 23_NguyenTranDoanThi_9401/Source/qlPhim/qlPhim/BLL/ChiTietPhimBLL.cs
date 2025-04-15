using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class ChiTietPhimBLL
    {
        private static ChiTietPhimBLL instance;

        public static ChiTietPhimBLL Instance
        {
            get => instance == null ? instance = new ChiTietPhimBLL() : instance;
            private set => instance = value;
        }

        private ChiTietPhimBLL() { }

        public List<ChiTietPhimDAL> GetListMoiveDetail()
        {
            List<ChiTietPhimDAL> list = new List<ChiTietPhimDAL>();
            string query = "SELECT * FROM vwDanhSachPhim";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChiTietPhimDAL movie = new ChiTietPhimDAL(item);
                list.Add(movie);
            }
            return list;
        }

        public List<ChiTietPhimDAL> GetListMoiveDetailByMovieID(string movieID)
        {
            List<ChiTietPhimDAL> list = new List<ChiTietPhimDAL>();
            string query = $"SELECT * FROM vwDanhSachPhim WHERE MaPhim = N'{movieID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChiTietPhimDAL movie = new ChiTietPhimDAL(item);
                list.Add(movie);
            }
            return list;
        }

        public List<ChiTietPhimDAL> GetListMoiveDetailByMovieName(string movieName)
        {
            List<ChiTietPhimDAL> list = new List<ChiTietPhimDAL>();
            string query = $"SELECT * FROM vwDanhSachPhim WHERE TenPhim LIKE N'%{movieName}%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChiTietPhimDAL movie = new ChiTietPhimDAL(item);
                list.Add(movie);
            }
            return list;
        }

        public List<ChiTietPhimDAL> GetListMoiveDetailByGenreName(string genreName)
        {
            List<ChiTietPhimDAL> list = new List<ChiTietPhimDAL>();
            string query = $"SELECT * FROM vwDanhSachPhim WHERE TheLoaiPhim LIKE N'%{genreName}%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChiTietPhimDAL movie = new ChiTietPhimDAL(item);
                list.Add(movie);
            }
            return list;
        }
    }
}
