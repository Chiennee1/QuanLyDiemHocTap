using QuanLyDiemHocTap.DAL;
using QuanLyDiemHocTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.BUS
{
    public class TaiKhoanBUS
    {
        public static TaiKhoanDTO DangNhap(string tenDangNhap, string matKhau)
        {
            DataTable dt = TaiKhoanDAL.DangNhap(tenDangNhap, matKhau);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TaiKhoanDTO
                {
                    MaTaiKhoan = Convert.ToInt32(row["MaTaiKhoan"]),
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString(),
                    MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"])
                };
            }
            return null;
        }

        public static bool DoiMatKhau(int maTaiKhoan, string matKhauCu, string matKhauMoi, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                error = "Mật khẩu mới không được để trống!";
                return false;
            }

            if (matKhauMoi.Length < 6)
            {
                error = "Mật khẩu phải có ít nhất 6 ký tự!";
                return false;
            }

            int result = TaiKhoanDAL.DoiMatKhau(maTaiKhoan, matKhauMoi);
            
            if (result <= 0)
            {
                error = "Đổi mật khẩu thất bại!";
                return false;
            }

            return true;
        }

        public static DataTable GetAllTaiKhoan()
        {
            return TaiKhoanDAL.GetAllTaiKhoan();
        }

        public static bool ThemTaiKhoan(string tenDangNhap, string matKhau, string loaiTaiKhoan, int maNguoiDung, out string error)
        {
            error = "";

            // Validate
            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                error = "Tên đăng nhập không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                error = "Mật khẩu không được để trống!";
                return false;
            }

            if (matKhau.Length < 6)
            {
                error = "Mật khẩu phải có ít nhất 6 ký tự!";
                return false;
            }

            // Kiểm tra tên đăng nhập đã tồn tại
            if (TaiKhoanDAL.KiemTraTenDangNhapTonTai(tenDangNhap))
            {
                error = "Tên đăng nhập đã tồn tại!";
                return false;
            }

            // Kiểm tra người dùng đã có tài khoản chưa
            if (loaiTaiKhoan != "Admin" && TaiKhoanDAL.KiemTraNguoiDungDaCo(loaiTaiKhoan, maNguoiDung))
            {
                error = "Người dùng này đã có tài khoản!";
                return false;
            }

            int result = TaiKhoanDAL.ThemTaiKhoan(tenDangNhap, matKhau, loaiTaiKhoan, maNguoiDung);
            
            if (result <= 0)
            {
                error = "Thêm tài khoản thất bại!";
                return false;
            }

            return true;
        }

        public static bool SuaTaiKhoan(int maTaiKhoan, string loaiTaiKhoan, int maNguoiDung, bool trangThai, out string error)
        {
            error = "";

            // Kiểm tra người dùng đã có tài khoản chưa (trừ tài khoản hiện tại)
            if (loaiTaiKhoan != "Admin" && TaiKhoanDAL.KiemTraNguoiDungDaCo(loaiTaiKhoan, maNguoiDung))
            {
                error = "Người dùng này đã có tài khoản khác!";
                return false;
            }

            int result = TaiKhoanDAL.SuaTaiKhoan(maTaiKhoan, loaiTaiKhoan, maNguoiDung, trangThai);
            
            if (result <= 0)
            {
                error = "Cập nhật tài khoản thất bại!";
                return false;
            }

            return true;
        }

        public static bool XoaTaiKhoan(int maTaiKhoan, out string error)
        {
            error = "";

            int result = TaiKhoanDAL.XoaTaiKhoan(maTaiKhoan);
            
            if (result <= 0)
            {
                error = "Xóa tài khoản thất bại!";
                return false;
            }

            return true;
        }

        public static DataTable SearchTaiKhoan(string keyword)
        {
            return TaiKhoanDAL.SearchTaiKhoan(keyword);
        }
    }
}
