using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.DAL
{
    internal class VeDAL
    {
        private string maVe;
        private string maHD;
        private string maGhe;
        private string maSC;

        public string MaVe { get => maVe; set => maVe = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaGhe { get => maGhe; set => maGhe = value; }
        public string MaSC { get => maSC; set => maSC = value; }

        public VeDAL(string maVe, string maHD, string maGhe, string maSC)
        {
            this.maVe = maVe;
            this.maHD = maHD;
            this.maGhe = maGhe;
            this.maSC = maSC;
        }

        public VeDAL(DataRow row)
        {
            this.maVe = row["MaVe"].ToString();
            this.maHD = row["MaHD"].ToString();
            this.maGhe = row["MaGhe"].ToString();
            this.maSC = row["MaSC"].ToString();
        }
    }
}
