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
    public class HocSinhBUS
    {
        public static DataTable GetAllHocSinh()
        {
            return HocSinhDAL.GetAllHocSinh();
        }

        public static HocSinhDTO GetHocSinhByMa(int maHS)
        {
            DataTable dt = HocSinhDAL.GetHocSinhByMa(maHS);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new HocSinhDTO
                {
                    MaHS = Convert.ToInt32(row["MaHS"]),
                    HoTen = row["HoTen"].ToString(),
                    NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                    GioiTinh = row["GioiTinh"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    DienThoai = row["DienThoai"].ToString(),
                    Email = row["Email"].ToString(),
                    NgayNhapHoc = Convert.ToDateTime(row["NgayNhapHoc"]),
                    TrangThai = Convert.ToBoolean(row["TrangThai"])
                };
            }
            return null;
        }

        public static DataTable SearchHocSinh(string keyword)
        {
            return HocSinhDAL.SearchHocSinh(keyword);
        }

        public static bool ThemHocSinh(HocSinhDTO hs, out string error)
        {
            error = "";

            // Validate
            if (string.IsNullOrWhiteSpace(hs.HoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            if (hs.NgaySinh >= DateTime.Now)
            {
                error = "Ngày sinh không hợp lệ!";
                return false;
            }

            int result = HocSinhDAL.InsertHocSinh(hs.HoTen, hs.NgaySinh, hs.GioiTinh,
                                                  hs.DiaChi, hs.DienThoai, hs.Email);
            return result > 0;
        }

        public static bool SuaHocSinh(HocSinhDTO hs, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(hs.HoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            if (hs.NgaySinh >= DateTime.Now)
            {
                error = "Ngày sinh không hợp lệ!";
                return false;
            }

            int result = HocSinhDAL.UpdateHocSinh(hs.MaHS, hs.HoTen, hs.NgaySinh, hs.GioiTinh,
                                                  hs.DiaChi, hs.DienThoai, hs.Email);
            return result > 0;
        }

        public static bool XoaHocSinh(int maHS, out string error)
        {
            error = "";
            int result = HocSinhDAL.DeleteHocSinh(maHS);
            if (result == 0)
            {
                error = "Xóa học sinh thất bại!";
            }
            return result > 0;
        }

        public static DataTable GetHocSinhByLop(int maLop, int maHocKy)
        {
            return HocSinhDAL.GetHocSinhByLop(maLop, maHocKy);
        }
    }
}
