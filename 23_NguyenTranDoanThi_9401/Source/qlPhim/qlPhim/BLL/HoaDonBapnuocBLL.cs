using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class HoaDonBapnuocBLL
    {
        private static HoaDonBapnuocBLL instance;

        public static HoaDonBapnuocBLL Instance
        {
            get => instance == null ? instance = new HoaDonBapnuocBLL() : instance;
            private set => instance = value;
        }

        private HoaDonBapnuocBLL() { }

        public bool InsertProductToBill(string maHD, string maSP, int soLuong)
        {
            string query = "INSERT INTO HoaDonBapNuoc(MaHDBN, MaHD, MaSP, SoLuong) VALUES (dbo.f_AutoMaHDBN(), @maHD , @maSP , @soLuong )";
            object[] parameters = new object[]
            {
                maHD,
                maSP,
                soLuong
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
