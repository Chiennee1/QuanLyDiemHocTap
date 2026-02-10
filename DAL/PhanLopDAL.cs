using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class PhanLopDAL
    {
        public static DataTable GetHocSinhByLop(int maLop, int maHocKy)
        {
            string query = @"SELECT pl.*, hs.HoTen, hs.NgaySinh, hs.GioiTinh
                            FROM PhanLop pl
                            INNER JOIN HocSinh hs ON pl.MaHS = hs.MaHS
                            WHERE pl.MaLop = @MaLop AND pl.MaHocKy = @MaHocKy AND hs.TrangThai = 1
                            ORDER BY hs.HoTen";
            return DataProvider.ExecuteQuery(query, new object[] { maLop, maHocKy });
        }

        public static int InsertPhanLop(int maHS, int maLop, int maHocKy)
        {
            // Kiểm tra xem học sinh đã có trong lớp chưa
            string checkQuery = "SELECT COUNT(*) FROM PhanLop WHERE MaHS = @MaHS AND MaLop = @MaLop AND MaHocKy = @MaHocKy";
            int count = Convert.ToInt32(DataProvider.ExecuteScalar(checkQuery, new object[] { maHS, maLop, maHocKy }));

            if (count > 0)
                return 0; // Đã tồn tại

            string query = "INSERT INTO PhanLop (MaHS, MaLop, MaHocKy) VALUES ( @MaHS , @MaLop , @MaHocKy )";
            return DataProvider.ExecuteNonQuery(query, new object[] { maHS, maLop, maHocKy });
        }

        public static int DeletePhanLop(int maPhanLop)
        {
            string query = "DELETE FROM PhanLop WHERE MaPhanLop = @MaPhanLop";
            return DataProvider.ExecuteNonQuery(query, new object[] { maPhanLop });
        }

        public static int DeleteHocSinhKhoiLop(int maHS, int maLop, int maHocKy)
        {
            string query = "DELETE FROM PhanLop WHERE MaHS = @MaHS AND MaLop = @MaLop AND MaHocKy = @MaHocKy";
            return DataProvider.ExecuteNonQuery(query, new object[] { maHS, maLop, maHocKy });
        }
    }
}
