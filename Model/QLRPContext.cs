using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QLRPContext : DbContext
    {
        public QLRPContext() : base("name=QLRPModel2") {
            Database.SetInitializer<QLRPContext>(null);
        }
        public DbSet<Phim> Phims { get; set; }
        public DbSet<PhongChieu> PhongChieus { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<LichChieu> LichChieus { get; set; }
        public DbSet<Ghe> Ghes { get; set; }
        public DbSet<DatVe> DatVes { get; set; }
    }
}
