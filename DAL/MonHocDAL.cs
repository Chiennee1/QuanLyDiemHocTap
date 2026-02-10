using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class MonHocDAL
    {
        public static DataTable GetAllMonHoc()
        {
            string query = @"SELECT mh.*, k.TenKhoi FROM MonHoc mh
                            INNER JOIN Khoi k ON mh.MaKhoi = k.MaKhoi
                            WHERE mh.TrangThai = 1 ORDER BY k.KhoiSo, mh.TenMonHoc";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetMonHocByKhoi(int maKhoi)
        {
            string query = @"SELECT mh.*, k.TenKhoi FROM MonHoc mh
                            INNER JOIN Khoi k ON mh.MaKhoi = k.MaKhoi
                            WHERE mh.MaKhoi = @MaKhoi AND mh.TrangThai = 1";
            return DataProvider.ExecuteQuery(query, new object[] { maKhoi });
        }

        public static int InsertMonHoc(string tenMonHoc, int maKhoi, int soTietLT, int soTietTH, int heSo)
        {
            string query = "INSERT INTO MonHoc (TenMonHoc, MaKhoi, SoTietLyThuyet, SoTietThucHanh, HeSo) " +
                          "VALUES ( @TenMonHoc , @MaKhoi , @SoTietLT , @SoTietTH , @HeSo )";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenMonHoc, maKhoi, soTietLT, soTietTH, heSo });
        }

        public static int UpdateMonHoc(int maMonHoc, string tenMonHoc, int maKhoi, int soTietLT, int soTietTH, int heSo)
        {
            string query = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc , MaKhoi = @MaKhoi , SoTietLyThuyet = @SoTietLT , " +
                          "SoTietThucHanh = @SoTietTH , HeSo = @HeSo WHERE MaMonHoc = @MaMonHoc";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenMonHoc, maKhoi, soTietLT, soTietTH, heSo, maMonHoc });
        }

        public static int DeleteMonHoc(int maMonHoc)
        {
            string query = "UPDATE MonHoc SET TrangThai = 0 WHERE MaMonHoc = @MaMonHoc";
            return DataProvider.ExecuteNonQuery(query, new object[] { maMonHoc });
        }
    }
}
