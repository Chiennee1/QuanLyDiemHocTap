using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class HocSinhDAL
    {
        public static DataTable GetAllHocSinh()
        {
            string query = "SELECT * FROM HocSinh WHERE TrangThai = 1 ORDER BY HoTen";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetHocSinhByMa(int maHS)
        {
            string query = "SELECT * FROM HocSinh WHERE MaHS = @MaHS";
            return DataProvider.ExecuteQuery(query, new object[] { maHS });
        }

        public static DataTable SearchHocSinh(string keyword)
        {
            string query = "SELECT * FROM HocSinh WHERE (HoTen LIKE N'%' + @keyword + '%' OR DienThoai LIKE '%' + @keyword + '%') AND TrangThai = 1";
            return DataProvider.ExecuteQuery(query, new object[] { keyword });
        }

        public static int InsertHocSinh(string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email)
        {
            string query = "INSERT INTO HocSinh (HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, Email) " +
                          "VALUES ( @HoTen , @NgaySinh , @GioiTinh , @DiaChi , @DienThoai , @Email)";
            return DataProvider.ExecuteNonQuery(query, new object[] { hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, email });
        }

        public static int UpdateHocSinh(int maHS, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email)
        {
            string query = "UPDATE HocSinh SET HoTen = @HoTen , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , " +
                          "DiaChi = @DiaChi , DienThoai = @DienThoai , Email = @Email WHERE MaHS = @MaHS";
            return DataProvider.ExecuteNonQuery(query, new object[] { hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, email, maHS });
        }

        public static int DeleteHocSinh(int maHS)
        {
            string query = "UPDATE HocSinh SET TrangThai = 0 WHERE MaHS = @MaHS";
            return DataProvider.ExecuteNonQuery(query, new object[] { maHS });
        }

        public static DataTable GetHocSinhByLop(int maLop, int maHocKy)
        {
            string query = @"SELECT hs.* FROM HocSinh hs
                            INNER JOIN PhanLop pl ON hs.MaHS = pl.MaHS
                            WHERE pl.MaLop = @MaLop AND pl.MaHocKy = @MaHocKy AND hs.TrangThai = 1";
            return DataProvider.ExecuteQuery(query, new object[] { maLop, maHocKy });
        }
    }
}
