using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class LoaiDiemDAL
    {
        public static DataTable GetAllLoaiDiem()
        {
            string query = "SELECT * FROM LoaiDiem ORDER BY HeSo, TenLoaiDiem";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetLoaiDiemByHeSo(int heSo)
        {
            string query = "SELECT * FROM LoaiDiem WHERE HeSo = @HeSo";
            return DataProvider.ExecuteQuery(query, new object[] { heSo });
        }
    }

}
