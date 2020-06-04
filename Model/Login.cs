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
        public string UserName { get; set; }

        public string Password { get; set; }

        [ForeignKey("NhanVien")]
        public int MaNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
      
    }
}
