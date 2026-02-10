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
    public class HocKyBUS
    {
        public static DataTable GetAllHocKy()
        {
            return HocKyDAL.GetAllHocKy();
        }

        public static DataTable GetHocKyByNamHoc(int maNamHoc)
        {
            return HocKyDAL.GetHocKyByNamHoc(maNamHoc);
        }

        public static bool ThemHocKy(HocKyDTO hk, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(hk.TenHocKy))
            {
                error = "Tên học kỳ không được để trống!";
                return false;
            }

            int result = HocKyDAL.InsertHocKy(hk.MaNamHoc, hk.TenHocKy, hk.HocKySo);
            return result > 0;
        }
    }

    // BUS/KhoiBUS.cs
    public class KhoiBUS
    {
        public static DataTable GetAllKhoi()
        {
            return KhoiDAL.GetAllKhoi();
        }
    }
    // BUS/HanhKiemBUS.cs
    public class HanhKiemBUS
    {
        public static DataTable GetAllHanhKiem()
        {
            return HanhKiemDAL.GetAllHanhKiem();
        }
    }

    // BUS/XepLoaiHocLucBUS.cs
    public class XepLoaiHocLucBUS
    {
        public static DataTable GetAllXepLoai()
        {
            return XepLoaiHocLucDAL.GetAllXepLoai();
        }
    }

}
