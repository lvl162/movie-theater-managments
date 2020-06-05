using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Ghe")]
    public class Ghe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaGhe { get; set; }
        [ForeignKey("PhongChieu")]
        public int MaPhong { get; set; }
        public virtual PhongChieu PhongChieu { get; set; }
        public string TenGhe { get; set; }

    }
}
