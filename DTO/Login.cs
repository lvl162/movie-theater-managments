using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("Login")]
    public class Login
    {
        [ForeignKey("NhanVien")]
        public int MaNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
        public string UserName;
        public string Password;
    }
}
