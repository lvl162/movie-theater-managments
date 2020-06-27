using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatVeDTO
    {
        public int MaLichChieu { get; set; }
        public DateTime NgayGioChieu { get; set; }
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public int MaGhe { get; set; }
        public string TenGhe { get; set; }
        public string NguoiBan { get; set; }
        public DateTime ThoiGianBan { get; set; }
    }
}
