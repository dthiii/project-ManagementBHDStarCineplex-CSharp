using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;

        public static NhanVienBLL Instance
        {
            get => instance == null ? instance = new NhanVienBLL() : instance;
            private set => instance = value;
        }

        private NhanVienBLL() { }

        public string GetNextMaNV()
        {
            string query = "SELECT dbo.f_AutoMaNV()";
            string maKH = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return maKH;
        }

        public List<NhanVienDAL> GetListEmployee()
        {
            List<NhanVienDAL> list = new List<NhanVienDAL>();
            string query = "SELECT * FROM NhanVien WHERE MaNV != N'ADMIN' AND MaNV != N'NV000'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVienDAL employee = new NhanVienDAL(item);
                list.Add(employee);
            }
            return list;
        }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM NhanVien WHERE Email = @userName AND MatKhau = @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        public List<NhanVienDAL> GetEmployeeByAccount(string userName, string passWord)
        {
            List<NhanVienDAL> list = new List<NhanVienDAL>();
            string query = "SELECT * FROM NhanVien WHERE Email = @userName AND MatKhau = @passWord";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            foreach (DataRow item in data.Rows)
            {
                NhanVienDAL employee = new NhanVienDAL(item);
                list.Add(employee);
            }
            return list;
        }

        public bool InsertEmployee(string hoNV, string tenNV, DateTime ngaySinh, string gioiTinh, DateTime ngayVaoLam, string maCV, string dienThoai, string email, string diaChi)
        {
            string query = "INSERT INTO NhanVien(MaNV, HoNV, TenNV, NgaySinh, GioiTinh, NgayVaoLam, MaCV, DienThoai, Email, MatKhau, DiaChi)  " +
                "VALUES (dbo.f_AutoMaNV(), @hoNV , @tenNV , @ngaySinh , @gioiTinh , @ngayVaoLam , @maCV , @dienThoai , @email , '123456', @diaChi )";
            object[] parameters = new object[]
            {
                hoNV,
                tenNV,
                (object)ngaySinh ?? DBNull.Value,
                (object)gioiTinh ?? DBNull.Value,
                (object)ngayVaoLam ?? DBNull.Value,
                maCV,
                dienThoai,
                (object)email ?? DBNull.Value,
                (object)diaChi ?? DBNull.Value
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateEmployee(string maNV, string hoNV, string tenNV, DateTime ngaySinh, string gioiTinh, DateTime ngayVaoLam, string maCV, string dienThoai, string email, string diaChi)
        {
            string query = "UPDATE NhanVien SET HoNV = @hoNV , TenNV = @tenNV , NgaySinh = @ngaySinh , GioiTinh = @gioiTinh , NgayVaoLam = @ngayVaoLam , MaCV = @maCV , DienThoai = @dienThoai , Email = @email , DiaChi = @diaChi WHERE MaNV = @maNV";
            object[] parameters = new object[]
            {
                hoNV,
                tenNV,
                (object)ngaySinh ?? DBNull.Value,
                (object)gioiTinh ?? DBNull.Value,
                (object)ngayVaoLam ?? DBNull.Value,
                maCV,
                dienThoai,
                (object)email ?? DBNull.Value,
                (object)diaChi ?? DBNull.Value,
                maNV
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool DeleteEmployee(string maNV)
        {
            string query = string.Format("DELETE NhanVien WHERE MaNV = N'{0}'", maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<NhanVienDAL> GetListEmployeelByEmployeeID(string employeeID)
        {
            List<NhanVienDAL> list = new List<NhanVienDAL>();
            string query = $"SELECT * FROM NhanVien WHERE MaNV != N'ADMIN' AND MaNV != N'NV000' AND MaNV = N'{employeeID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVienDAL employee = new NhanVienDAL(item);
                list.Add(employee);
            }
            return list;
        }

        public List<NhanVienDAL> GetListEmployeelByEmployeeName(string employeeName)
        {
            List<NhanVienDAL> list = new List<NhanVienDAL>();
            string query = $"SELECT * FROM NhanVien WHERE MaNV != N'ADMIN' AND MaNV != N'NV000' AND HoNV + ' ' + TenNV LIKE N'%{employeeName}%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVienDAL employee = new NhanVienDAL(item);
                list.Add(employee);
            }
            return list;
        }
    }
}
