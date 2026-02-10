using QuanLyDiemHocTap.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.BUS
{
    public class PhanLopBUS
    {
        public static DataTable GetHocSinhByLop(int maLop, int maHocKy)
        {
            return PhanLopDAL.GetHocSinhByLop(maLop, maHocKy);
        }

        public static bool ThemHocSinhVaoLop(int maHS, int maLop, int maHocKy, out string error)
        {
            error = "";
            int result = PhanLopDAL.InsertPhanLop(maHS, maLop, maHocKy);

            if (result == 0)
            {
                error = "Học sinh đã có trong lớp này!";
                return false;
            }

            return true;
        }

        public static bool XoaHocSinhKhoiLop(int maHS, int maLop, int maHocKy, out string error)
        {
            error = "";
            int result = PhanLopDAL.DeleteHocSinhKhoiLop(maHS, maLop, maHocKy);

            if (result == 0)
            {
                error = "Xóa học sinh khỏi lớp thất bại!";
            }

            return result > 0;
        }
    }
}
