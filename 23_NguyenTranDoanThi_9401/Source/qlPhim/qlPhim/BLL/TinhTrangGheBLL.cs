using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class TinhTrangGheBLL
    {
        private static TinhTrangGheBLL instance;
        public static int SeatWidth = 50;
        public static int SeatHeight = 50;

        public static TinhTrangGheBLL Instance
        {
            get => instance == null ? instance = new TinhTrangGheBLL() : instance;
            private set => instance = value;
        }

        private TinhTrangGheBLL() { }

        public List<TinhTrangGheDAL> GetListSeatDetailByShowtimesID(string maSC)
        {
            List<TinhTrangGheDAL> list = new List<TinhTrangGheDAL>();
            string query = string.Format("SELECT ctsc.*, g.MaLoaiGhe, Gia FROM ChiTietSuatChieu ctsc INNER JOIN Ghe g ON ctsc.MaGhe = g.MaGhe INNER JOIN LoaiGhe lg ON g.MaLoaiGhe = lg.MaLoaiGhe WHERE MaSC = N'{0}'", maSC);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TinhTrangGheDAL seatDetail = new TinhTrangGheDAL(item);
                list.Add(seatDetail);
            }
            return list;
        }
    }
}
