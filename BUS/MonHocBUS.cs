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
    public class MonHocBUS
    {
        public static DataTable GetAllMonHoc()
        {
            return MonHocDAL.GetAllMonHoc();
        }

        public static DataTable GetMonHocByKhoi(int maKhoi)
        {
            return MonHocDAL.GetMonHocByKhoi(maKhoi);
        }

        public static bool ThemMonHoc(MonHocDTO mh, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(mh.TenMonHoc))
            {
                error = "Tên môn học không được để trống!";
                return false;
            }

            int result = MonHocDAL.InsertMonHoc(mh.TenMonHoc, mh.MaKhoi, mh.SoTietLyThuyet,
                                                mh.SoTietThucHanh, mh.HeSo);
            return result > 0;
        }

        public static bool SuaMonHoc(MonHocDTO mh, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(mh.TenMonHoc))
            {
                error = "Tên môn học không được để trống!";
                return false;
            }

            int result = MonHocDAL.UpdateMonHoc(mh.MaMonHoc, mh.TenMonHoc, mh.MaKhoi,
                                                mh.SoTietLyThuyet, mh.SoTietThucHanh, mh.HeSo);
            return result > 0;
        }

        public static bool XoaMonHoc(int maMonHoc, out string error)
        {
            error = "";
            int result = MonHocDAL.DeleteMonHoc(maMonHoc);
            if (result == 0)
            {
                error = "Xóa môn học thất bại!";
            }
            return result > 0;
        }
    }
}
