namespace DTO
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
        [StringLength(10)]
        public string MaPhong { get; set; }

        public int? SoGhe { get; set; }

        public double? DienTich { get; set; }
        //public virtual List<PhongChieu> PhongChieus { get; set; }
    }
}
