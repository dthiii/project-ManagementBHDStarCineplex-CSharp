using qlPhim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlPhim.BLL
{
    public class PhongBLL
    {
        private static PhongBLL instance;

        public static int RoomWidth = 300;
        public static int RoomHeight = 70;

        public static PhongBLL Instance
        {
            get => instance == null ? instance = new PhongBLL() : instance;
            private set => instance = value;
        }

        private PhongBLL() { }

        public List<PhongDAL> GetRoomList()
        {
            List<PhongDAL> list = new List<PhongDAL>();
            string query = "SELECT * FROM PhongChieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhongDAL room = new PhongDAL(item);
                list.Add(room);
            }
            return list;
        }
    }
}
