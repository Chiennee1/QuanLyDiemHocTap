using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DTO
{
    public class PhanLopDTO
    {
        public int MaPhanLop { get; set; }
        public int MaHS { get; set; }
        public int MaLop { get; set; }
        public int MaHocKy { get; set; }
        public DateTime NgayPhanLop { get; set; }

        public string TenHS { get; set; }
        public string TenLop { get; set; }
        public string TenHocKy { get; set; }
    }
}
