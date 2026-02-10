using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class NamHocDAL
    {
        public static DataTable GetAllNamHoc()
        {
            string query = "SELECT * FROM NamHoc ORDER BY NgayBatDau DESC";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetNamHocHienTai()
        {
            string query = "SELECT * FROM NamHoc WHERE TrangThai = 1";
            return DataProvider.ExecuteQuery(query);
        }

        public static int InsertNamHoc(string tenNamHoc, System.DateTime ngayBD, System.DateTime ngayKT)
        {
            string query = "INSERT INTO NamHoc (TenNamHoc, NgayBatDau, NgayKetThuc) VALUES ( @TenNamHoc , @NgayBD , @NgayKT )";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenNamHoc, ngayBD, ngayKT });
        }

        public static int UpdateNamHoc(int maNamHoc, string tenNamHoc, System.DateTime ngayBD, System.DateTime ngayKT)
        {
            string query = "UPDATE NamHoc SET TenNamHoc = @TenNamHoc , NgayBatDau = @NgayBD , NgayKetThuc = @NgayKT WHERE MaNamHoc = @MaNamHoc";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenNamHoc, ngayBD, ngayKT, maNamHoc });
        }
    }
}
