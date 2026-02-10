using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class LopDAL
    {
        public static DataTable GetAllLop()
        {
            string query = @"SELECT l.*, k.TenKhoi, nh.TenNamHoc, gv.HoTen AS TenGVCN 
                            FROM Lop l
                            INNER JOIN Khoi k ON l.MaKhoi = k.MaKhoi
                            INNER JOIN NamHoc nh ON l.MaNamHoc = nh.MaNamHoc
                            LEFT JOIN GiaoVien gv ON l.MaGVCN = gv.MaGV
                            ORDER BY k.KhoiSo, l.TenLop";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetLopByKhoi(int maKhoi)
        {
            string query = @"SELECT l.*, k.TenKhoi, nh.TenNamHoc, gv.HoTen AS TenGVCN 
                            FROM Lop l
                            INNER JOIN Khoi k ON l.MaKhoi = k.MaKhoi
                            INNER JOIN NamHoc nh ON l.MaNamHoc = nh.MaNamHoc
                            LEFT JOIN GiaoVien gv ON l.MaGVCN = gv.MaGV
                            WHERE l.MaKhoi = @MaKhoi";
            return DataProvider.ExecuteQuery(query, new object[] { maKhoi });
        }

        public static int InsertLop(string tenLop, int maKhoi, int maNamHoc, int? maGVCN)
        {
            string query = "INSERT INTO Lop (TenLop, MaKhoi, MaNamHoc, MaGVCN) VALUES ( @TenLop , @MaKhoi , @MaNamHoc , @MaGVCN )";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenLop, maKhoi, maNamHoc, maGVCN ?? (object)DBNull.Value });
        }

        public static int UpdateLop(int maLop, string tenLop, int maKhoi, int maNamHoc, int? maGVCN)
        {
            string query = "UPDATE Lop SET TenLop = @TenLop , MaKhoi = @MaKhoi , MaNamHoc = @MaNamHoc , MaGVCN = @MaGVCN WHERE MaLop = @MaLop";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenLop, maKhoi, maNamHoc, maGVCN ?? (object)DBNull.Value, maLop });
        }

        public static int DeleteLop(int maLop)
        {
            string query = "DELETE FROM Lop WHERE MaLop = @MaLop";
            return DataProvider.ExecuteNonQuery(query, new object[] { maLop });
        }
    }
}
