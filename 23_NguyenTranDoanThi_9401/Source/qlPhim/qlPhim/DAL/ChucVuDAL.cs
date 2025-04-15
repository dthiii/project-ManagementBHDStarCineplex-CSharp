using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.DAL
{
    public class ChucVuDAL
    {
        private string maCV;
        private string tenCV;

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }

        public ChucVuDAL(string maCV, string tenCV)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
        }

        public ChucVuDAL(DataRow row)
        {
            this.maCV = row["MaCV"].ToString();
            this.tenCV = row["TenCV"].ToString();
        }
    }
}
