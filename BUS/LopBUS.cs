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
    public class LopBUS
    {
        public static DataTable GetAllLop()
        {
            return LopDAL.GetAllLop();
        }

        public static DataTable GetLopByKhoi(int maKhoi)
        {
            return LopDAL.GetLopByKhoi(maKhoi);
        }

        public static bool ThemLop(LopDTO lop, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(lop.TenLop))
            {
                error = "Tên lớp không được để trống!";
                return false;
            }

            int result = LopDAL.InsertLop(lop.TenLop, lop.MaKhoi, lop.MaNamHoc, lop.MaGVCN);
            return result > 0;
        }

        public static bool SuaLop(LopDTO lop, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(lop.TenLop))
            {
                error = "Tên lớp không được để trống!";
                return false;
            }

            int result = LopDAL.UpdateLop(lop.MaLop, lop.TenLop, lop.MaKhoi, lop.MaNamHoc, lop.MaGVCN);
            return result > 0;
        }

        public static bool XoaLop(int maLop, out string error)
        {
            error = "";
            int result = LopDAL.DeleteLop(maLop);
            if (result == 0)
            {
                error = "Xóa lớp thất bại!";
            }
            return result > 0;
        }
    }
}
