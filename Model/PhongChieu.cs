namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongChieu")]
    public class PhongChieu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhong { get; set; }

        public int SoGhe { get; set; }

        public string TenPhong { get; set; }
        public virtual List<Ghe> Ghes { get; set; }
    }
}
