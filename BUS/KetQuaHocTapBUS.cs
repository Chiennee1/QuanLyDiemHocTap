using QuanLyDiemHocTap.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.BUS
{
    public class KetQuaHocTapBUS
    {
        public static DataTable GetKetQuaByHocSinh(int maHS, int maHocKy)
        {
            return KetQuaHocTapDAL.GetKetQuaByHocSinh(maHS, maHocKy);
        }

        public static DataTable GetKetQuaByLop(int maLop, int maHocKy)
        {
            return KetQuaHocTapDAL.GetKetQuaByLop(maLop, maHocKy);
        }

        public static decimal TinhDiemTrungBinhHocKy(int maHS, int maHocKy)
        {
            object result = KetQuaHocTapDAL.TinhDiemTrungBinhHocKy(maHS, maHocKy);
            if (result != null && result != DBNull.Value)
            {
                return Math.Round(Convert.ToDecimal(result), 2);
            }
            return 0;
        }

        public static int XacDinhXepLoai(decimal diemTB)
        {
            DataTable dt = XepLoaiHocLucDAL.GetXepLoaiByDiem(diemTB);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MaXepLoai"]);
            }
            return 4; // Mặc định là Yếu
        }

        public static bool LuuKetQua(int maHS, int maHocKy, decimal diemTB, int maHanhKiem, int maXepLoai, string ghiChu, out string error)
        {
            error = "";

            if (diemTB < 0 || diemTB > 10)
            {
                error = "Điểm trung bình không hợp lệ!";
                return false;
            }

            int result = KetQuaHocTapDAL.InsertOrUpdateKetQua(maHS, maHocKy, diemTB, maHanhKiem, maXepLoai, ghiChu);
            return result > 0;
        }

        public static bool TongKetHocKy(int maHS, int maHocKy, int maHanhKiem, out string error)
        {
            error = "";

            // Tính điểm trung bình
            decimal diemTB = TinhDiemTrungBinhHocKy(maHS, maHocKy);

            if (diemTB == 0)
            {
                error = "Học sinh chưa có điểm để tổng kết!";
                return false;
            }

            // Xác định xếp loại
            int maXepLoai = XacDinhXepLoai(diemTB);

            // Lưu kết quả
            return LuuKetQua(maHS, maHocKy, diemTB, maHanhKiem, maXepLoai, "", out error);
        }
    }
}
