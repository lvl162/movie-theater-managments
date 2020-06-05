namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLichChieuModel4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ghe",
                c => new
                    {
                        MaGhe = c.Int(nullable: false, identity: true),
                        MaPhong = c.Int(nullable: false),
                        TenGhe = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaGhe)
                .ForeignKey("dbo.PhongChieu", t => t.MaPhong, cascadeDelete: true)
                .Index(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.DatVe", "MaLichChieu", "dbo.LichChieu");
            //DropForeignKey("dbo.DatVe", "MaGhe", "dbo.Ghe");
            //DropForeignKey("dbo.Ghe", "MaPhong", "dbo.PhongChieu");
            //DropIndex("dbo.Ghe", new[] { "MaPhong" });
            //DropIndex("dbo.DatVe", new[] { "MaGhe" });
            //DropIndex("dbo.DatVe", new[] { "MaLichChieu" });
            DropTable("dbo.Ghe");
            //DropTable("dbo.DatVe");
        }
    }
}
