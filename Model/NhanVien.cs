using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime NgaySua { get; set; }
        public virtual Login Login { get; set; }
    }
}
