using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatVeDAL
    {
        public List<String> getListPhim()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = from phim in context.Phims
                           select phim.TenPhim.ToString();
                return list.ToList();
            }
        }
    }
}
