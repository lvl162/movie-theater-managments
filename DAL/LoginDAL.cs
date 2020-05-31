using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        public string Login(Login lg)
        {
            using(QLRPContext context = new QLRPContext())
            {
                try
                {
                    Login res = context.Logins.Single(p => p.UserName == lg.UserName && p.Password == lg.Password);
                    int maNV = res.MaNhanVien;
                    var nv = context.NhanViens.Single(p => p.MaNhanVien == maNV);
                    /*
                     QTV Hệ Thống
                    Quản Lý Phòng Chiếu
                    Quản Lý Phim
                    Quản Lý Lịch Chiếu
                    Nhân Viên Bán Vé
                    */
                    return nv.ChucVu;
                }
                catch (Exception e) { return "Khong tim thay"; }
                
            }
        }
    }
}
