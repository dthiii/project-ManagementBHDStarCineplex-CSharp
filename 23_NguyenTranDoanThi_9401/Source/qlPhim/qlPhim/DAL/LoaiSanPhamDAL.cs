using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.DAL
{
    public class LoaiSanPhamDAL
    {
        private string maLoaiSP;
        private string tenLoaiSP;

        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string TenLoaiSP { get => tenLoaiSP; set => tenLoaiSP = value; }

        public LoaiSanPhamDAL(string maLoaiSP, string tenLoaiSP)
        {
            this.maLoaiSP = maLoaiSP;
            this.tenLoaiSP = tenLoaiSP;
        }

        public LoaiSanPhamDAL(DataRow row)
        {
            this.maLoaiSP = row["MaLoaiSP"].ToString();
            this.tenLoaiSP = row["TenLoaiSP"].ToString();
        }
    }
}
