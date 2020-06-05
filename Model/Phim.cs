using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Phim")]

    public class Phim
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhim { get; set; }
        [Required]
        public string TenPhim { get; set; }
        [Required]
        public string TheLoai { get; set; }
        [Required]
        public string MoTa { get; set; }
        public DateTime? NgayKhoiChieu { get; set; }
    }
}
