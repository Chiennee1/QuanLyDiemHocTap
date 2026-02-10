using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DTO
{
    public class KetQuaHocTapDTO
    {
        public int MaKetQua { get; set; }
        public int MaHS { get; set; }
        public int MaHocKy { get; set; }
        public decimal DiemTrungBinh { get; set; }
        public int MaHanhKiem { get; set; }
        public int MaXepLoai { get; set; }
        public string GhiChu { get; set; }

        public string TenHS { get; set; }
        public string TenHocKy { get; set; }
        public string TenHanhKiem { get; set; }
        public string TenXepLoai { get; set; }
    }
}
