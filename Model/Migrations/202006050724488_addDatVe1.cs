namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDatVe1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatVe",
                c => new
                    {
                        MaVe = c.Int(nullable: false, identity: true),
                        MaLichChieu = c.Int(nullable: false),
                        MaGhe = c.Int(nullable: false),
                        LoaiVe = c.String(),
                        ThoiGianDatVe = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaVe)
                .ForeignKey("dbo.Ghe", t => t.MaGhe, cascadeDelete: false)
                .ForeignKey("dbo.LichChieu", t => t.MaLichChieu, cascadeDelete: false)
                .Index(t => t.MaLichChieu)
                .Index(t => t.MaGhe);
            
        }
        
        public override void Down()
        {
            
            DropTable("dbo.DatVe");
        }
    }
}
