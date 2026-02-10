using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DTO
{
    public class MonHocDTO
    {
        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int MaKhoi { get; set; }
        public int SoTietLyThuyet { get; set; }
        public int SoTietThucHanh { get; set; }
        public int HeSo { get; set; }
        public bool TrangThai { get; set; }
        public string TenKhoi { get; set; }
    }
}
