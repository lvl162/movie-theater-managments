namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLichChieuModel3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.LichChieux", newName: "LichChieu");
            AlterColumn("dbo.Phim", "TenPhim", c => c.String(nullable: false));
            AlterColumn("dbo.Phim", "TheLoai", c => c.String(nullable: false));
            AlterColumn("dbo.Phim", "MoTa", c => c.String(nullable: false));
            AlterColumn("dbo.PhongChieu", "TenPhong", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhongChieu", "TenPhong", c => c.String());
            AlterColumn("dbo.Phim", "MoTa", c => c.String());
            AlterColumn("dbo.Phim", "TheLoai", c => c.String());
            AlterColumn("dbo.Phim", "TenPhim", c => c.String());
            RenameTable(name: "dbo.LichChieu", newName: "LichChieux");
        }
    }
}
