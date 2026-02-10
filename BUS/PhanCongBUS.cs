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
    public class PhanCongBUS
    {
        public static DataTable GetAllPhanCong()
        {
            return PhanCongDAL.GetAllPhanCong();
        }

        public static DataTable GetPhanCongByGiaoVien(int maGV)
        {
            return PhanCongDAL.GetPhanCongByGiaoVien(maGV);
        }

        public static DataTable GetPhanCongByLop(int maLop, int maHocKy)
        {
            return PhanCongDAL.GetPhanCongByLop(maLop, maHocKy);
        }

        public static bool ThemPhanCong(PhanCongDTO pc, out string error)
        {
            error = "";
            int result = PhanCongDAL.InsertPhanCong(pc.MaGV, pc.MaLop, pc.MaMonHoc, pc.MaHocKy);

            if (result == 0)
            {
                error = "Phân công đã tồn tại!";
                return false;
            }

            return true;
        }

        public static bool XoaPhanCong(int maPhanCong, out string error)
        {
            error = "";
            int result = PhanCongDAL.DeletePhanCong(maPhanCong);
            if (result == 0)
            {
                error = "Xóa phân công thất bại!";
            }
            return result > 0;
        }
    }
}
