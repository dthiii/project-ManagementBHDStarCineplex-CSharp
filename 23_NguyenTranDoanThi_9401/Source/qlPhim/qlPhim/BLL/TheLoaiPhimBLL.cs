using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class TheLoaiPhimBLL
    {
        private static TheLoaiPhimBLL instance;

        public static TheLoaiPhimBLL Instance
        {
            get => instance == null ? instance = new TheLoaiPhimBLL() : instance;
            private set => instance = value;
        }

        private TheLoaiPhimBLL() { }

        public List<TheLoaiPhimDAL> GetListGenreMovieByMovieID(string maPhim)
        {
            List<TheLoaiPhimDAL> list = new List<TheLoaiPhimDAL>();
            string query = string.Format("SELECT * FROM TheLoai_Phim WHERE MaPhim = '{0}'", maPhim);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheLoaiPhimDAL genreMovie = new TheLoaiPhimDAL(item);
                list.Add(genreMovie);
            }
            return list;
        }

        public bool InsertGenreMovie(string maPhim, string maTL)
        {
            string query = string.Format("INSERT INTO TheLoai_Phim (MaPhim, MaTL) VALUES (N'{0}', N'{1}')", maPhim, maTL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteGenreMovie(string maPhim)
        {
            string query = string.Format("DELETE TheLoai_Phim WHERE MaPhim = N'{0}'", maPhim);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
