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

            int result = TaiKhoanDAL.DoiMatKhau(maTaiKhoan, matKhauMoi);
            return result > 0;
        }
    }

}
