using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLRPContext : DbContext
    {
        public QLRPContext() : base("name=QLRPModel") {
            Database.SetInitializer<QLRPContext>(new CreateDatabaseIfNotExists<QLRPContext>());
        }
        public DbSet<Phim> Phims { get; set; }
        public DbSet<PhongChieu> PhongChieus { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
    }
}
