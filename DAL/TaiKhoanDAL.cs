using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class TaiKhoanDAL
    {
        public static DataTable DangNhap(string tenDangNhap, string matKhau)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND TrangThai = 1";
            return DataProvider.ExecuteQuery(query, new object[] { tenDangNhap, matKhau });
        }

        public static int DoiMatKhau(int maTaiKhoan, string matKhauMoi)
        {
            string query = "UPDATE TaiKhoan SET MatKhau = @MatKhauMoi WHERE MaTaiKhoan = @MaTaiKhoan";
            return DataProvider.ExecuteNonQuery(query, new object[] { matKhauMoi, maTaiKhoan });
        }

        public static int ThemTaiKhoan(string tenDangNhap, string matKhau, string loaiTaiKhoan, int maNguoiDung)
        {
            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan, MaNguoiDung) " +
                          "VALUES ( @TenDangNhap , @MatKhau , @LoaiTaiKhoan , @MaNguoiDung )";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenDangNhap, matKhau, loaiTaiKhoan, maNguoiDung });
        }

        public static DataTable GetAllTaiKhoan()
        {
            string query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1 ORDER BY LoaiTaiKhoan, TenDangNhap";
            return DataProvider.ExecuteQuery(query);
        }
    }

}
