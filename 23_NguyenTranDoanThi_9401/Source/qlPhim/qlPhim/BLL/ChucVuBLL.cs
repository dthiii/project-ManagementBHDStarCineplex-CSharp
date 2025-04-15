using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class ChucVuBLL
    {
        private static ChucVuBLL instance;

        public static ChucVuBLL Instance
        {
            get => instance == null ? instance = new ChucVuBLL() : instance;
            private set => instance = value;
        }

        private ChucVuBLL() { }

        public List<ChucVuDAL> GetListEmployeeType()
        {
            List<ChucVuDAL> list = new List<ChucVuDAL>();
            string query = "SELECT * FROM ChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChucVuDAL employeeType = new ChucVuDAL(item);
                list.Add(employeeType);
            }
            return list;
        }
    }
}
