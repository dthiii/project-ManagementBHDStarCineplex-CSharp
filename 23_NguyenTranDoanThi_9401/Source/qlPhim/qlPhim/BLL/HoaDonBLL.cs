using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class HoaDonBLL
    {
        private static HoaDonBLL instance;

        public static HoaDonBLL Instance
        {
            get => instance == null ? instance = new HoaDonBLL() : instance;
            private set => instance = value;
        }

        private HoaDonBLL() { }

        public string GetMaHD(string maKH, string maNV, DateTime ngayTao)
        {
            string query = "SELECT MaHD FROM HoaDon WHERE MaKH = @maKH AND MaNV = @maNV AND NgayTao = @ngayTao ";
            object[] parameters = new object[]
            {
                maKH,
                maNV,
                ngayTao
            };
            string maHD = DataProvider.Instance.ExecuteScalar(query, parameters)?.ToString();
            return maHD;
        }

        public bool InsertBill(string maKH, string maNV, DateTime ngayTao)
        {
            string query = "INSERT INTO HoaDon(MaHD, MaKH, MaNV, NgayTao) VALUES (dbo.f_AutoMaHD(), @maKH , @maNV , @ngayTao )";
            object[] parameters = new object[]
            {
                maKH,
                maNV,
                ngayTao
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
