namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phim",
                c => new
                    {
                        MaPhim = c.Int(nullable: false, identity: true),
                        TenPhim = c.String(),
                        TheLoai = c.String(),
                        MoTa = c.String(),
                        NgayKhoiChieu = c.DateTime(),
                    })
                .PrimaryKey(t => t.MaPhim);
            
            CreateTable(
                "dbo.PhongChieu",
                c => new
                    {
                        MaPhong = c.Int(nullable: false, identity: true),
                        SoGhe = c.Int(),
                        DienTich = c.Double(),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhongChieu");
            DropTable("dbo.Phim");
        }
    }
}
