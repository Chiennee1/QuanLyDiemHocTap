using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class HanhKiemDAL
    {
        public static DataTable GetAllHanhKiem()
        {
            string query = "SELECT * FROM HanhKiem ORDER BY DiemToiThieu DESC";
            return DataProvider.ExecuteQuery(query);
        }
    }
}
