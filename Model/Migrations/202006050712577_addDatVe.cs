namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDatVe : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.DatVe", "MaGhe", "dbo.Ghe");
            //DropForeignKey("dbo.DatVe", "MaLichChieu", "dbo.LichChieu");
            //DropIndex("dbo.DatVe", new[] { "MaLichChieu" });
            //DropIndex("dbo.DatVe", new[] { "MaGhe" });
            //DropTable("dbo.DatVe");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DatVe",
                c => new
                    {
                        MaDatVe = c.Int(nullable: false, identity: true),
                        MaLichChieu = c.Int(nullable: false),
                        MaGhe = c.Int(nullable: false),
                        LoaiVe = c.String(),
                        ThoiGianDatVe = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaDatVe);
            
            CreateIndex("dbo.DatVe", "MaGhe");
            CreateIndex("dbo.DatVe", "MaLichChieu");
            AddForeignKey("dbo.DatVe", "MaLichChieu", "dbo.LichChieu", "MaLichChieu", cascadeDelete: true);
            AddForeignKey("dbo.DatVe", "MaGhe", "dbo.Ghe", "MaGhe", cascadeDelete: true);
        }
    }
}
