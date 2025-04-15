using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.DAL
{
    public class HoaDonBapnuocDAL
    {
        private string maHDBN;
        private string maHD;
        private string maSP;
        private int soLuong;

        public string MaHDBN { get => maHDBN; set => maHDBN = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public HoaDonBapnuocDAL(string maHDBN, string maHD, string maSP, int soLuong)
        {
            this.maHDBN = maHDBN;
            this.maHD = maHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
        }

        public HoaDonBapnuocDAL(DataRow row)
        {
            this.maHDBN = row["MaHDBN"].ToString();
            this.maHD = row["MaHD"].ToString();
            this.maSP = row["MaSP"].ToString();
            this.soLuong = Convert.ToInt32(row["SoLuong"]);
        }
    }
}
