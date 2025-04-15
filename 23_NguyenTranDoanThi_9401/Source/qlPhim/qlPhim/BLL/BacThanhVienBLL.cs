using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class BacThanhVienBLL
    {
        private static BacThanhVienBLL instance;

        public static BacThanhVienBLL Instance
        {
            get => instance == null ? instance = new BacThanhVienBLL() : instance;
            private set => instance = value;
        }

        private BacThanhVienBLL() { }

        public List<BacThanhVienDAL> GetListCustomerType()
        {
            List<BacThanhVienDAL> list = new List<BacThanhVienDAL>();
            string query = "SELECT * FROM BacThanhVien ORDER BY ChietKhau ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BacThanhVienDAL customerType = new BacThanhVienDAL(item);
                list.Add(customerType);
            }
            return list;
        }

        public List<BacThanhVienDAL> GetListCustomerTypeByCustomerTypeID(string id)
        {
            List<BacThanhVienDAL> list = new List<BacThanhVienDAL>();
            string query = $"SELECT * FROM BacThanhVien WHERE MaBacTV = N'{id}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BacThanhVienDAL customerType = new BacThanhVienDAL(item);
                list.Add(customerType);
            }
            return list;
        }
    }
}
