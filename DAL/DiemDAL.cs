using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class DiemDAL
    {
        public static DataTable GetAllDiem()
        {
            string query = @"SELECT d.*, hs.HoTen AS TenHS, mh.TenMonHoc, ld.TenLoaiDiem, ld.HeSo
                            FROM Diem d
                            INNER JOIN HocSinh hs ON d.MaHS = hs.MaHS
                            INNER JOIN MonHoc mh ON d.MaMonHoc = mh.MaMonHoc
                            INNER JOIN LoaiDiem ld ON d.MaLoaiDiem = ld.MaLoaiDiem
                            ORDER BY d.NgayNhap DESC";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetDiemByHocSinh(int maHS, int maHocKy)
        {
            string query = @"SELECT d.*, mh.TenMonHoc, ld.TenLoaiDiem, ld.HeSo
                            FROM Diem d
                            INNER JOIN MonHoc mh ON d.MaMonHoc = mh.MaMonHoc
                            INNER JOIN LoaiDiem ld ON d.MaLoaiDiem = ld.MaLoaiDiem
                            WHERE d.MaHS = @MaHS AND d.MaHocKy = @MaHocKy
                            ORDER BY mh.TenMonHoc, ld.HeSo";
            return DataProvider.ExecuteQuery(query, new object[] { maHS, maHocKy });
        }

        public static DataTable GetDiemByMonHoc(int maHS, int maMonHoc, int maHocKy)
        {
            string query = @"SELECT d.*, ld.TenLoaiDiem, ld.HeSo
                            FROM Diem d
                            INNER JOIN LoaiDiem ld ON d.MaLoaiDiem = ld.MaLoaiDiem
                            WHERE d.MaHS = @MaHS AND d.MaMonHoc = @MaMonHoc AND d.MaHocKy = @MaHocKy
                            ORDER BY ld.HeSo, d.NgayNhap";
            return DataProvider.ExecuteQuery(query, new object[] { maHS, maMonHoc, maHocKy });
        }

        public static DataTable GetDiemLopMonHoc(int maLop, int maMonHoc, int maHocKy)
        {
            string query = @"SELECT hs.MaHS, hs.HoTen, d.MaDiem, d.DiemSo, d.MaLoaiDiem, ld.TenLoaiDiem, ld.HeSo
                            FROM HocSinh hs
                            INNER JOIN PhanLop pl ON hs.MaHS = pl.MaHS
                            LEFT JOIN Diem d ON hs.MaHS = d.MaHS AND d.MaMonHoc = @MaMonHoc AND d.MaHocKy = @MaHocKy
                            LEFT JOIN LoaiDiem ld ON d.MaLoaiDiem = ld.MaLoaiDiem
                            WHERE pl.MaLop = @MaLop AND pl.MaHocKy = @MaHocKy AND hs.TrangThai = 1
                            ORDER BY hs.HoTen, ld.HeSo";
            return DataProvider.ExecuteQuery(query, new object[] { maMonHoc, maHocKy, maLop });
        }

        public static int InsertDiem(int maHS, int maMonHoc, int maHocKy, int maLoaiDiem, decimal diemSo, string ghiChu)
        {
            string query = "INSERT INTO Diem (MaHS, MaMonHoc, MaHocKy, MaLoaiDiem, DiemSo, GhiChu) " +
                          "VALUES ( @MaHS , @MaMonHoc , @MaHocKy , @MaLoaiDiem , @DiemSo , @GhiChu )";
            return DataProvider.ExecuteNonQuery(query, new object[] { maHS, maMonHoc, maHocKy, maLoaiDiem, diemSo, ghiChu ?? "" });
        }

        public static int UpdateDiem(int maDiem, decimal diemSo, string ghiChu)
        {
            string query = "UPDATE Diem SET DiemSo = @DiemSo , GhiChu = @GhiChu WHERE MaDiem = @MaDiem";
            return DataProvider.ExecuteNonQuery(query, new object[] { diemSo, ghiChu ?? "", maDiem });
        }

        public static int DeleteDiem(int maDiem)
        {
            string query = "DELETE FROM Diem WHERE MaDiem = @MaDiem";
            return DataProvider.ExecuteNonQuery(query, new object[] { maDiem });
        }

        public static object TinhDiemTrungBinhMon(int maHS, int maMonHoc, int maHocKy)
        {
            string query = @"SELECT SUM(d.DiemSo * ld.HeSo) / NULLIF(SUM(ld.HeSo), 0) AS DiemTB
                            FROM Diem d
                            INNER JOIN LoaiDiem ld ON d.MaLoaiDiem = ld.MaLoaiDiem
                            WHERE d.MaHS = @MaHS AND d.MaMonHoc = @MaMonHoc AND d.MaHocKy = @MaHocKy";
            return DataProvider.ExecuteScalar(query, new object[] { maHS, maMonHoc, maHocKy });
        }
    }
}
