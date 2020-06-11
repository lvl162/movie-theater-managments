using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Login")]
    public class Login
    {

        [Key]
        [Column(Order = 1)]
        public string UserName { get; set; }

        [Key]
        [ForeignKey("NhanVien")]
        [Column(Order = 2)]
        public int MaNhanVien { get; set; }
        public string Password { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime NgaySua { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        
      
    }
}
