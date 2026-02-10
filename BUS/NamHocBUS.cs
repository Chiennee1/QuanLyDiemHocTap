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
    public class NamHocBUS
    {
        public static DataTable GetAllNamHoc()
        {
            return NamHocDAL.GetAllNamHoc();
        }

        public static DataTable GetNamHocHienTai()
        {
            return NamHocDAL.GetNamHocHienTai();
        }

        public static bool ThemNamHoc(NamHocDTO nh, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(nh.TenNamHoc))
            {
                error = "Tên năm học không được để trống!";
                return false;
            }

            if (nh.NgayBatDau >= nh.NgayKetThuc)
            {
                error = "Ngày kết thúc phải sau ngày bắt đầu!";
                return false;
            }

            int result = NamHocDAL.InsertNamHoc(nh.TenNamHoc, nh.NgayBatDau, nh.NgayKetThuc);
            return result > 0;
        }

        public static bool SuaNamHoc(NamHocDTO nh, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(nh.TenNamHoc))
            {
                error = "Tên năm học không được để trống!";
                return false;
            }

            if (nh.NgayBatDau >= nh.NgayKetThuc)
            {
                error = "Ngày kết thúc phải sau ngày bắt đầu!";
                return false;
            }

            int result = NamHocDAL.UpdateNamHoc(nh.MaNamHoc, nh.TenNamHoc, nh.NgayBatDau, nh.NgayKetThuc);
            return result > 0;
        }
    }
}
