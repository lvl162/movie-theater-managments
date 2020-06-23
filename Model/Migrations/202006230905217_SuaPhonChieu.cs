namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuaPhonChieu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhongChieu", "SoHang", c => c.Int(nullable: false));
            AddColumn("dbo.PhongChieu", "SoCot", c => c.Int(nullable: false));
            AddColumn("dbo.Phim", "ThoiLuong", c => c.Int(nullable: false));
            DropColumn("dbo.PhongChieu", "SoGhe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhongChieu", "SoGhe", c => c.Int(nullable: false));
            DropColumn("dbo.Phim", "ThoiLuong");
            DropColumn("dbo.PhongChieu", "SoCot");
            DropColumn("dbo.PhongChieu", "SoHang");
        }
    }
}
