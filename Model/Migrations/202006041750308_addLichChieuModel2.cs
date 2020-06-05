namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLichChieuModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LichChieux",
                c => new
                    {
                        MaLichChieu = c.Int(nullable: false, identity: true),
                        MaPhong = c.Int(nullable: false),
                        MaPhim = c.Int(nullable: false),
                        NgayGioChieu = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaLichChieu)
                .ForeignKey("dbo.Phim", t => t.MaPhim, cascadeDelete: true)
                .ForeignKey("dbo.PhongChieu", t => t.MaPhong, cascadeDelete: true)
                .Index(t => new { t.MaPhong, t.MaPhim, t.NgayGioChieu }, unique: true, name: "IX_PhongPhimNgayGio");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LichChieux", "MaPhong", "dbo.PhongChieu");
            DropForeignKey("dbo.LichChieux", "MaPhim", "dbo.Phim");
            DropIndex("dbo.LichChieux", "IX_PhongPhimNgayGio");
            DropTable("dbo.LichChieux");
        }
    }
}
