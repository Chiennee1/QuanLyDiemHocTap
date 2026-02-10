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
    public class GiaoVienBUS
    {
        public static DataTable GetAllGiaoVien()
        {
            return GiaoVienDAL.GetAllGiaoVien();
        }

        public static GiaoVienDTO GetGiaoVienByMa(int maGV)
        {
            DataTable dt = GiaoVienDAL.GetGiaoVienByMa(maGV);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new GiaoVienDTO
                {
                    MaGV = Convert.ToInt32(row["MaGV"]),
                    HoTen = row["HoTen"].ToString(),
                    NgaySinh = row["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(row["NgaySinh"]) : DateTime.Now,
                    GioiTinh = row["GioiTinh"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    DienThoai = row["DienThoai"].ToString(),
                    Email = row["Email"].ToString(),
                    ChuyenMon = row["ChuyenMon"].ToString(),
                    TrangThai = Convert.ToBoolean(row["TrangThai"])
                };
            }
            return null;
        }

        public static bool ThemGiaoVien(GiaoVienDTO gv, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(gv.HoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            int result = GiaoVienDAL.InsertGiaoVien(gv.HoTen, gv.NgaySinh, gv.GioiTinh,
                                                    gv.DiaChi, gv.DienThoai, gv.Email, gv.ChuyenMon);
            return result > 0;
        }

        public static bool SuaGiaoVien(GiaoVienDTO gv, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(gv.HoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            int result = GiaoVienDAL.UpdateGiaoVien(gv.MaGV, gv.HoTen, gv.NgaySinh, gv.GioiTinh,
                                                    gv.DiaChi, gv.DienThoai, gv.Email, gv.ChuyenMon);
            return result > 0;
        }

        public static bool XoaGiaoVien(int maGV, out string error)
        {
            error = "";
            int result = GiaoVienDAL.DeleteGiaoVien(maGV);
            if (result == 0)
            {
                error = "Xóa giáo viên thất bại!";
            }
            return result > 0;
        }
    }
}
