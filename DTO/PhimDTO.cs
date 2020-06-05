using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhimDTO
    {

        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string TheLoai { get; set; }
        public string MoTa { get; set; }
        public DateTime? NgayKhoiChieu { get; set; }
    }
}
