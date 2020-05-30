using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyNhanVienDAL
    {
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.NhanViens.Add(nv);
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public List<NhanVien> DanhSachSinhVien()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = context.NhanViens.Select(p => p);
                return list.ToList();
            }
        }
    }
}
