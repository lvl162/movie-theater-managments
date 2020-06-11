using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("DatVe")]
    public class DatVe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaVe { get; set; }
        [ForeignKey("LichChieu")]
        public int MaLichChieu { get; set; }
        [ForeignKey("Ghe")]
        public int MaGhe { get; set; }
        public string LoaiVe { get; set; }
        public DateTime ThoiGianDatVe { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime NgaySua { get; set; }
        public virtual LichChieu LichChieu { get; set; }
        public virtual Ghe Ghe { get; set; }
    }
}
