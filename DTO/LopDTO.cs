using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DTO
{
    public class LopDTO
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int MaKhoi { get; set; }
        public int MaNamHoc { get; set; }
        public int SiSo { get; set; }
        public int? MaGVCN { get; set; }
        public string TenKhoi { get; set; }
        public string TenNamHoc { get; set; }
        public string TenGVCN { get; set; }
    }
}
