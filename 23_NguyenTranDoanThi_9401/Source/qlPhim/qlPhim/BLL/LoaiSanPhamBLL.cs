using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class LoaiSanPhamBLL
    {
        private static LoaiSanPhamBLL instance;

        public static LoaiSanPhamBLL Instance
        {
            get => instance == null ? instance = new LoaiSanPhamBLL() : instance;
            private set => instance = value;
        }

        private LoaiSanPhamBLL() { }

        public List<LoaiSanPhamDAL> GetListProductType()
        {
            List<LoaiSanPhamDAL> list = new List<LoaiSanPhamDAL>();
            string query = "SELECT * FROM LoaiSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiSanPhamDAL productType = new LoaiSanPhamDAL(item);
                list.Add(productType);
            }
            return list;
        }

        public LoaiSanPhamDAL GetProductTypeByID(string productTypeID)
        {
            LoaiSanPhamDAL productType = null;
            string query = $"SELECT * FROM LoaiSanPham WHERE MaLoaiSP = N'{productTypeID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                productType = new LoaiSanPhamDAL(item);
                return productType;
            }
            return productType;
        }
    }
}
