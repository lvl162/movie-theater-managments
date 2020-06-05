using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("LichChieu")]
    public class LichChieu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLichChieu { get; set; }
        [ForeignKey("PhongChieu")]
        [Index("IX_PhongPhimNgayGio", 1, IsUnique = true)]
        public int MaPhong { get; set; }
        
        
        [ForeignKey("Phim")]
        [Index("IX_PhongPhimNgayGio", 2, IsUnique = true)]
        public int MaPhim { get; set; }

        [Index("IX_PhongPhimNgayGio", 3, IsUnique = true)]
        public DateTime NgayGioChieu { get; set; }
        public virtual PhongChieu PhongChieu { get; set; }
        public virtual Phim Phim { get; set; }
    }
}
