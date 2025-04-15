using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.DAL
{
    public class TheLoaiDAL
    {
        private string maTL;
        private string tenTheLoai;

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public TheLoaiDAL(string maTL, string tenTheLoai)
        {
            this.maTL = maTL;
            this.tenTheLoai = tenTheLoai;
        }

        public TheLoaiDAL(DataRow row)
        {
            this.maTL = row["maTL"].ToString();
            this.tenTheLoai = row["tenTheLoai"].ToString();
        }
    }
}
