using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DAL
{
    public class KetQuaHocTapDAL
    {
        public static DataTable GetKetQuaByHocSinh(int maHS, int maHocKy)
        {
            string query = @"SELECT kq.*, hs.HoTen AS TenHS, hk.TenHocKy, 
                            hkm.TenHanhKiem, xl.TenXepLoai
                            FROM KetQuaHocTap kq
                            INNER JOIN HocSinh hs ON kq.MaHS = hs.MaHS
                            INNER JOIN HocKy hk ON kq.MaHocKy = hk.MaHocKy
                            LEFT JOIN HanhKiem hkm ON kq.MaHanhKiem = hkm.MaHanhKiem
                            LEFT JOIN XepLoaiHocLuc xl ON kq.MaXepLoai = xl.MaXepLoai
                            WHERE kq.MaHS = @MaHS AND kq.MaHocKy = @MaHocKy";
            return DataProvider.ExecuteQuery(query, new object[] { maHS, maHocKy });
        }

        public static DataTable GetKetQuaByLop(int maLop, int maHocKy)
        {
            string query = @"SELECT hs.MaHS, hs.HoTen, kq.DiemTrungBinh, 
                            hkm.TenHanhKiem, xl.TenXepLoai
                            FROM HocSinh hs
                            INNER JOIN PhanLop pl ON hs.MaHS = pl.MaHS
                            LEFT JOIN KetQuaHocTap kq ON hs.MaHS = kq.MaHS AND kq.MaHocKy = @MaHocKy
                            LEFT JOIN HanhKiem hkm ON kq.MaHanhKiem = hkm.MaHanhKiem
                            LEFT JOIN XepLoaiHocLuc xl ON kq.MaXepLoai = xl.MaXepLoai
                            WHERE pl.MaLop = @MaLop AND pl.MaHocKy = @MaHocKy AND hs.TrangThai = 1
                            ORDER BY kq.DiemTrungBinh DESC, hs.HoTen";
            return DataProvider.ExecuteQuery(query, new object[] { maHocKy, maLop, maHocKy });
        }

        public static int InsertOrUpdateKetQua(int maHS, int maHocKy, decimal diemTB, int maHanhKiem, int maXepLoai, string ghiChu)
        {
            // Kiểm tra xem đã có kết quả chưa
            string checkQuery = "SELECT COUNT(*) FROM KetQuaHocTap WHERE MaHS = @MaHS AND MaHocKy = @MaHocKy";
            int count = Convert.ToInt32(DataProvider.ExecuteScalar(checkQuery, new object[] { maHS, maHocKy }));

            if (count > 0)
            {
                string query = "UPDATE KetQuaHocTap SET DiemTrungBinh = @DiemTB , MaHanhKiem = @MaHanhKiem , " +
                              "MaXepLoai = @MaXepLoai , GhiChu = @GhiChu WHERE MaHS = @MaHS AND MaHocKy = @MaHocKy";
                return DataProvider.ExecuteNonQuery(query, new object[] { diemTB, maHanhKiem, maXepLoai, ghiChu ?? "", maHS, maHocKy });
            }
            else
            {
                string query = "INSERT INTO KetQuaHocTap (MaHS, MaHocKy, DiemTrungBinh, MaHanhKiem, MaXepLoai, GhiChu) " +
                              "VALUES ( @MaHS , @MaHocKy , @DiemTB , @MaHanhKiem , @MaXepLoai , @GhiChu )";
                return DataProvider.ExecuteNonQuery(query, new object[] { maHS, maHocKy, diemTB, maHanhKiem, maXepLoai, ghiChu ?? "" });
            }
        }

        public static object TinhDiemTrungBinhHocKy(int maHS, int maHocKy)
        {
            string query = @"WITH DiemTBMon AS (
                                SELECT d.MaMonHoc,
                                    SUM(d.DiemSo * ld.HeSo) / NULLIF(SUM(ld.HeSo), 0) AS DiemTB
                                FROM Diem d
                                INNER JOIN LoaiDiem ld ON d.MaLoaiDiem = ld.MaLoaiDiem
                                WHERE d.MaHS = @MaHS AND d.MaHocKy = @MaHocKy
                                GROUP BY d.MaMonHoc
                            )
                            SELECT AVG(DiemTB) FROM DiemTBMon";
            return DataProvider.ExecuteScalar(query, new object[] { maHS, maHocKy });
        }
    }
}
