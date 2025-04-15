﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    internal class VeBLL
    {
        private static VeBLL instance;

        public static VeBLL Instance
        {
            get => instance == null ? instance = new VeBLL() : instance;
            private set => instance = value;
        }

        private VeBLL() { }

        public bool InsertTicketToBill(string maHD, string maGhe, string maSC)
        {
            string query = "INSERT INTO Ve(MaVe, MaHD, MaGhe, MaSC) VALUES (dbo.f_AutoMaVe(), @maHD , @maGhe , @maSC )";
            object[] parameters = new object[]
            {
                maHD,
                maGhe,
                maSC
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
