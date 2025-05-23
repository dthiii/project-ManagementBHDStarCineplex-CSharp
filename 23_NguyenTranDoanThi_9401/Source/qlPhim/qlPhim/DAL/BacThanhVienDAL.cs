﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.DAL
{
    public class BacThanhVienDAL
    {
        private string maBacTV;
        private string tenBacTV;
        private double chietKhau;

        public string MaBacTV { get => maBacTV; set => maBacTV = value; }
        public string TenBacTV { get => tenBacTV; set => tenBacTV = value; }
        public double ChietKhau { get => chietKhau; set => chietKhau = value; }

        public BacThanhVienDAL(string maBacTV, string tenBacTV, double chietKhau)
        {
            this.maBacTV = maBacTV;
            this.tenBacTV = tenBacTV;
            this.chietKhau = chietKhau;
        }

        public BacThanhVienDAL(DataRow row)
        {
            this.maBacTV = row["maBacTV"].ToString();
            this.tenBacTV = row["tenBacTV"].ToString();
            this.chietKhau = Convert.ToInt32(row["chietKhau"]);
        }
    }
}
