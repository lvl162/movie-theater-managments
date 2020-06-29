using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string RowVersion { get; set; }
        public string UserName { get; set; }
    }
}
