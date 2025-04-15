using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class TheLoaiBLL
    {
        private static TheLoaiBLL instance;

        public static TheLoaiBLL Instance
        {
            get => instance == null ? instance = new TheLoaiBLL() : instance;
            private set => instance = value;
        }

        private TheLoaiBLL() { }

        public string GetNextMaTL()
        {
            string query = "SELECT 'TL' + RIGHT('000' + CAST(MAX(RIGHT(MaTL, 3)) + 1 AS VARCHAR(3)), 3) FROM TheLoai";
            string maTL = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return maTL;
        }

        public bool InsertGenre(string tenTheLoai)
        {
            string query = $"INSERT INTO TheLoai(MaTL, TenTheLoai) VALUES (dbo.f_AutoMaTL(), N'{tenTheLoai}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateGenre(string maTL, string tenTheLoai)
        {
            string query = $"UPDATE TheLoai SET TenTheLoai = N'{tenTheLoai}' WHERE MaTL = N'{maTL}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DaleteGenre(string maTL)
        {
            string query = $"DELETE TheLoai WHERE MaTL = N'{maTL}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<TheLoaiDAL> GetListGenre()
        {
            List<TheLoaiDAL> list = new List<TheLoaiDAL>();
            string query = "SELECT * FROM TheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheLoaiDAL genre = new TheLoaiDAL(item);
                list.Add(genre);
            }
            return list;
        }

        public List<TheLoaiDAL> GetListGenreByGenreID(string maTL)
        {
            List<TheLoaiDAL> list = new List<TheLoaiDAL>();
            string query = string.Format("SELECT * FROM TheLoai WHERE MaTL = '{0}'", maTL);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheLoaiDAL genre = new TheLoaiDAL(item);
                list.Add(genre);
            }
            return list;
        }
    }
}
