using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DTO
{
    public class DiemDTO
    {
        public int MaDiem { get; set; }
        public int MaHS { get; set; }
        public int MaMonHoc { get; set; }
        public int MaHocKy { get; set; }
        public int MaLoaiDiem { get; set; }
        public decimal DiemSo { get; set; }
        public DateTime NgayNhap { get; set; }
        public string GhiChu { get; set; }

        // Thuộc tính bổ sung cho hiển thị
        public string TenHS { get; set; }
        public string TenMonHoc { get; set; }
        public string TenLoaiDiem { get; set; }
        public int HeSo { get; set; }
    }
}
