﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("Phim")]

    public class Phim
    {

        [Key]
        [StringLength(10)]
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string TheLoai { get; set; }
        public string MoTa { get; set; }
        public DateTime? NgayKhoiChieu { get; set; }
        //public virtual List<Phim> Phims { get; set; }
    }
}
