using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class KhoiDAL
    {
        public static DataTable GetAllKhoi()
        {
            string query = "SELECT * FROM Khoi ORDER BY KhoiSo";
            return DataProvider.ExecuteQuery(query);
        }
    }
}
