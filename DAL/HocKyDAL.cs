using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class HocKyDAL
    {
        public static DataTable GetAllHocKy()
        {
            string query = @"SELECT hk.*, nh.TenNamHoc 
                            FROM HocKy hk
                            INNER JOIN NamHoc nh ON hk.MaNamHoc = nh.MaNamHoc
                            ORDER BY nh.NgayBatDau DESC, hk.HocKySo";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetHocKyByNamHoc(int maNamHoc)
        {
            string query = "SELECT * FROM HocKy WHERE MaNamHoc = @MaNamHoc ORDER BY HocKySo";
            return DataProvider.ExecuteQuery(query, new object[] { maNamHoc });
        }

        public static int InsertHocKy(int maNamHoc, string tenHocKy, int hocKySo)
        {
            string query = "INSERT INTO HocKy (MaNamHoc, TenHocKy, HocKySo) VALUES ( @MaNamHoc , @TenHocKy , @HocKySo )";
            return DataProvider.ExecuteNonQuery(query, new object[] { maNamHoc, tenHocKy, hocKySo });
        }
    }
}
