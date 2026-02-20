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
            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan, MaNguoiDung, TrangThai, NgayTao) " +
                          "VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan, @MaNguoiDung , 1, GETDATE())";
            return DataProvider.ExecuteNonQuery(query, new object[] { tenDangNhap, matKhau, loaiTaiKhoan, maNguoiDung });
        }

        public static DataTable GetAllTaiKhoan()
        {
            string query = @"SELECT tk.MaTaiKhoan, tk.TenDangNhap, tk.MatKhau, tk.LoaiTaiKhoan, 
                            tk.MaNguoiDung, tk.TrangThai, tk.NgayTao,
                            CASE 
                                WHEN tk.LoaiTaiKhoan = 'GiaoVien' THEN gv.HoTen
                                WHEN tk.LoaiTaiKhoan = 'HocSinh' THEN hs.HoTen
                                ELSE N'Admin'
                            END AS HoTen,
                            CASE 
                                WHEN tk.LoaiTaiKhoan = 'GiaoVien' THEN gv.Email
                                WHEN tk.LoaiTaiKhoan = 'HocSinh' THEN hs.Email
                                ELSE N'admin@school.edu.vn'
                            END AS Email
                            FROM TaiKhoan tk
                            LEFT JOIN GiaoVien gv ON tk.MaNguoiDung = gv.MaGV AND tk.LoaiTaiKhoan = 'GiaoVien'
                            LEFT JOIN HocSinh hs ON tk.MaNguoiDung = hs.MaHS AND tk.LoaiTaiKhoan = 'HocSinh'
                            WHERE tk.TrangThai = 1
                            ORDER BY tk.LoaiTaiKhoan, tk.TenDangNhap";
            return DataProvider.ExecuteQuery(query);
        }

        public static int SuaTaiKhoan(int maTaiKhoan, string loaiTaiKhoan, int maNguoiDung, bool trangThai)
        {
            string query = "UPDATE TaiKhoan SET LoaiTaiKhoan = @LoaiTaiKhoan , MaNguoiDung = @MaNguoiDung , " +
                          "TrangThai = @TrangThai WHERE MaTaiKhoan = @MaTaiKhoan";
            return DataProvider.ExecuteNonQuery(query, new object[] { loaiTaiKhoan, maNguoiDung, trangThai ? 1 : 0, maTaiKhoan });
        }

        public static int XoaTaiKhoan(int maTaiKhoan)
        {
            string query = "UPDATE TaiKhoan SET TrangThai = 0 WHERE MaTaiKhoan = @MaTaiKhoan";
            return DataProvider.ExecuteNonQuery(query, new object[] { maTaiKhoan });
        }

        public static DataTable SearchTaiKhoan(string keyword)
        {
            string query = @"SELECT tk.MaTaiKhoan, tk.TenDangNhap, tk.MatKhau, tk.LoaiTaiKhoan, 
                            tk.MaNguoiDung, tk.TrangThai, tk.NgayTao,
                            CASE 
                                WHEN tk.LoaiTaiKhoan = 'GiaoVien' THEN gv.HoTen
                                WHEN tk.LoaiTaiKhoan = 'HocSinh' THEN hs.HoTen
                                ELSE N'Admin'
                            END AS HoTen,
                            CASE 
                                WHEN tk.LoaiTaiKhoan = 'GiaoVien' THEN gv.Email
                                WHEN tk.LoaiTaiKhoan = 'HocSinh' THEN hs.Email
                                ELSE N'admin@school.edu.vn'
                            END AS Email
                            FROM TaiKhoan tk
                            LEFT JOIN GiaoVien gv ON tk.MaNguoiDung = gv.MaGV AND tk.LoaiTaiKhoan = 'GiaoVien'
                            LEFT JOIN HocSinh hs ON tk.MaNguoiDung = hs.MaHS AND tk.LoaiTaiKhoan = 'HocSinh'
                            WHERE tk.TrangThai = 1 
                            AND (tk.TenDangNhap LIKE N'%' + @Keyword + '%' 
                                OR gv.HoTen LIKE N'%' + @Keyword + '%'
                                OR hs.HoTen LIKE N'%' + @Keyword + '%'
                                OR tk.LoaiTaiKhoan LIKE N'%' + @Keyword + '%')
                            ORDER BY tk.LoaiTaiKhoan, tk.TenDangNhap";
            return DataProvider.ExecuteQuery(query, new object[] { keyword });
        }

        public static bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            DataTable dt = DataProvider.ExecuteQuery(query, new object[] { tenDangNhap });
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public static bool KiemTraNguoiDungDaCo(string loaiTaiKhoan, int maNguoiDung)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE LoaiTaiKhoan = @LoaiTaiKhoan AND MaNguoiDung = @MaNguoiDung AND TrangThai = 1";
            DataTable dt = DataProvider.ExecuteQuery(query, new object[] { loaiTaiKhoan, maNguoiDung });
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
    }
}
