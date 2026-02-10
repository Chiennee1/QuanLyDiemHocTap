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
    public class DiemBUS
    {
        public static DataTable GetAllDiem()
        {
            return DiemDAL.GetAllDiem();
        }

        public static DataTable GetDiemByHocSinh(int maHS, int maHocKy)
        {
            return DiemDAL.GetDiemByHocSinh(maHS, maHocKy);
        }

        public static DataTable GetDiemByMonHoc(int maHS, int maMonHoc, int maHocKy)
        {
            return DiemDAL.GetDiemByMonHoc(maHS, maMonHoc, maHocKy);
        }

        public static DataTable GetDiemLopMonHoc(int maLop, int maMonHoc, int maHocKy)
        {
            return DiemDAL.GetDiemLopMonHoc(maLop, maMonHoc, maHocKy);
        }

        public static bool ThemDiem(DiemDTO diem, out string error)
        {
            error = "";

            if (diem.DiemSo < 0 || diem.DiemSo > 10)
            {
                error = "Điểm phải trong khoảng 0-10!";
                return false;
            }

            int result = DiemDAL.InsertDiem(diem.MaHS, diem.MaMonHoc, diem.MaHocKy,
                                           diem.MaLoaiDiem, diem.DiemSo, diem.GhiChu);
            return result > 0;
        }

        public static bool SuaDiem(int maDiem, decimal diemSo, string ghiChu, out string error)
        {
            error = "";

            if (diemSo < 0 || diemSo > 10)
            {
                error = "Điểm phải trong khoảng 0-10!";
                return false;
            }

            int result = DiemDAL.UpdateDiem(maDiem, diemSo, ghiChu);
            return result > 0;
        }

        public static bool XoaDiem(int maDiem, out string error)
        {
            error = "";
            int result = DiemDAL.DeleteDiem(maDiem);
            if (result == 0)
            {
                error = "Xóa điểm thất bại!";
            }
            return result > 0;
        }

        public static decimal TinhDiemTrungBinhMon(int maHS, int maMonHoc, int maHocKy)
        {
            object result = DiemDAL.TinhDiemTrungBinhMon(maHS, maMonHoc, maHocKy);
            if (result != null && result != DBNull.Value)
            {
                return Math.Round(Convert.ToDecimal(result), 2);
            }
            return 0;
        }
    }
}
