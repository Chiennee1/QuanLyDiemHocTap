using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DTO
{
    public class PhanCongDTO
    {
        public int MaPhanCong { get; set; }
        public int MaGV { get; set; }
        public int MaLop { get; set; }
        public int MaMonHoc { get; set; }
        public int MaHocKy { get; set; }

        public string TenGV { get; set; }
        public string TenLop { get; set; }
        public string TenMonHoc { get; set; }
        public string TenHocKy { get; set; }
    }
}
