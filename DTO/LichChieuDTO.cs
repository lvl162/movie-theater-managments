using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuDTO
    {
        public int MaLichChieu { get; set; }
        public int MaPhong { get; set; }
        public int MaPhim { get; set; }
        public DateTime NgayGioChieu { get; set; }
        public string RowVersion { get; set; }
        public string TenPhim { get; set; }
        public string TenPhong { get; set; }
        public string PhimMoTa { get; set; }
        public string GioChieuAndPhong
        {
            get
            {
                return "TG: " + NgayGioChieu.ToString() + " Phong: " + TenPhong;
            }
        }
        public string NgayChieu
        {
            get { return NgayGioChieu.Date.ToString("dd/MM/yyyy"); }
        }
        public string GioChieu
        {
            get { return NgayGioChieu.ToString("hh:mm tt"); }
        }
    }
}
