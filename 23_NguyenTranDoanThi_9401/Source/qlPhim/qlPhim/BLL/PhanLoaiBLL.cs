using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class PhanLoaiBLL
    {
        private static PhanLoaiBLL instance;

        public static PhanLoaiBLL Instance
        {
            get => instance == null ? instance = new PhanLoaiBLL() : instance;
            private set => instance = value;
        }

        private PhanLoaiBLL() { }

        public List<PhanLoaiDAL> GetListMovieRatingSystem()
        {
            List<PhanLoaiDAL> list = new List<PhanLoaiDAL>();
            string query = "SELECT * FROM PhanLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhanLoaiDAL movieRatingSystem = new PhanLoaiDAL(item);
                list.Add(movieRatingSystem);
            }
            return list;
        }

        public List<PhanLoaiDAL> GetListMovieRatingSystemByID(string id)
        {
            List<PhanLoaiDAL> list = new List<PhanLoaiDAL>();
            string query = $"SELECT * FROM PhanLoai WHERE MaPL = N'{id}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhanLoaiDAL movieRatingSystem = new PhanLoaiDAL(item);
                list.Add(movieRatingSystem);
            }
            return list;
        }
    }
}
