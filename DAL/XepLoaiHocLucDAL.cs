using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class XepLoaiHocLucDAL
    {
        public static DataTable GetAllXepLoai()
        {
            string query = "SELECT * FROM XepLoaiHocLuc ORDER BY DiemToiThieu DESC";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetXepLoaiByDiem(decimal diemTB)
        {
            string query = "SELECT * FROM XepLoaiHocLuc WHERE @DiemTB BETWEEN DiemToiThieu AND DiemToiDa";
            return DataProvider.ExecuteQuery(query, new object[] { diemTB });
        }
    }
}
