using DAL;
using System;
using System.Data;

namespace QuanLyDiemHocTap.DAL
{
    public class GiaoVienDAL
    {
        public static DataTable GetAllGiaoVien()
        {
            string query = "SELECT * FROM GiaoVien WHERE TrangThai = 1 ORDER BY HoTen";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetGiaoVienByMa(int maGV)
        {
            string query = "SELECT * FROM GiaoVien WHERE MaGV = @MaGV";
            return DataProvider.ExecuteQuery(query, new object[] { maGV });
        }

        public static int InsertGiaoVien(string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email, string chuyenMon)
        {
            string query = "INSERT INTO GiaoVien (HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, Email, ChuyenMon) " +
                          "VALUES ( @HoTen , @NgaySinh , @GioiTinh , @DiaChi , @DienThoai , @Email , @ChuyenMon )";
            return DataProvider.ExecuteNonQuery(query, new object[] { hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, email, chuyenMon });
        }

        public static int UpdateGiaoVien(int maGV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email, string chuyenMon)
        {
            string query = "UPDATE GiaoVien SET HoTen = @HoTen , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , " +
                          "DiaChi = @DiaChi , DienThoai = @DienThoai , Email = @Email , ChuyenMon = @ChuyenMon WHERE MaGV = @MaGV";
            return DataProvider.ExecuteNonQuery(query, new object[] { hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, email, chuyenMon, maGV });
        }

        public static int DeleteGiaoVien(int maGV)
        {
            string query = "UPDATE GiaoVien SET TrangThai = 0 WHERE MaGV = @MaGV";
            return DataProvider.ExecuteNonQuery(query, new object[] { maGV });
        }
    }
}