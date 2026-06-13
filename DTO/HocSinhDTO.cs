using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocTap.DTO
{
    public class HocSinhDTO
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgayNhapHoc { get; set; }
        public bool TrangThai { get; set; }
        public HocSinhDTO() { }
        public HocSinhDTO(int maHS, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai)
        {
            MaHS = maHS;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
          
        }
    }

    }
// HocSinhDTO a = new HocSinhDTO();
