using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class PhanCongDAL
    {
        public static DataTable GetAllPhanCong()
        {
            string query = @"SELECT pc.*, gv.HoTen AS TenGV, l.TenLop, mh.TenMonHoc, hk.TenHocKy
                            FROM PhanCong pc
                            INNER JOIN GiaoVien gv ON pc.MaGV = gv.MaGV
                            INNER JOIN Lop l ON pc.MaLop = l.MaLop
                            INNER JOIN MonHoc mh ON pc.MaMonHoc = mh.MaMonHoc
                            INNER JOIN HocKy hk ON pc.MaHocKy = hk.MaHocKy
                            ORDER BY l.TenLop, mh.TenMonHoc";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetPhanCongByGiaoVien(int maGV)
        {
            string query = @"SELECT pc.*, l.TenLop, mh.TenMonHoc, hk.TenHocKy
                            FROM PhanCong pc
                            INNER JOIN Lop l ON pc.MaLop = l.MaLop
                            INNER JOIN MonHoc mh ON pc.MaMonHoc = mh.MaMonHoc
                            INNER JOIN HocKy hk ON pc.MaHocKy = hk.MaHocKy
                            WHERE pc.MaGV = @MaGV";
            return DataProvider.ExecuteQuery(query, new object[] { maGV });
        }

        public static DataTable GetPhanCongByLop(int maLop, int maHocKy)
        {
            string query = @"SELECT pc.*, gv.HoTen AS TenGV, mh.TenMonHoc
                            FROM PhanCong pc
                            INNER JOIN GiaoVien gv ON pc.MaGV = gv.MaGV
                            INNER JOIN MonHoc mh ON pc.MaMonHoc = mh.MaMonHoc
                            WHERE pc.MaLop = @MaLop AND pc.MaHocKy = @MaHocKy";
            return DataProvider.ExecuteQuery(query, new object[] { maLop, maHocKy });
        }

        public static int InsertPhanCong(int maGV, int maLop, int maMonHoc, int maHocKy)
        {
            // Kiểm tra trùng
            string checkQuery = "SELECT COUNT(*) FROM PhanCong WHERE MaGV = @MaGV AND MaLop = @MaLop AND MaMonHoc = @MaMonHoc AND MaHocKy = @MaHocKy";
            int count = System.Convert.ToInt32(DataProvider.ExecuteScalar(checkQuery, new object[] { maGV, maLop, maMonHoc, maHocKy }));

            if (count > 0)
                return 0;

            string query = "INSERT INTO PhanCong (MaGV, MaLop, MaMonHoc, MaHocKy) VALUES ( @MaGV , @MaLop , @MaMonHoc , @MaHocKy )";
            return DataProvider.ExecuteNonQuery(query, new object[] { maGV, maLop, maMonHoc, maHocKy });
        }

        public static int DeletePhanCong(int maPhanCong)
        {
            string query = "DELETE FROM PhanCong WHERE MaPhanCong = @MaPhanCong";
            return DataProvider.ExecuteNonQuery(query, new object[] { maPhanCong });
        }
    }
}
