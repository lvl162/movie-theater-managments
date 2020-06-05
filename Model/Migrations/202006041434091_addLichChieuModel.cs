namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLichChieuModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhongChieu", "TenPhong", c => c.String());
            DropColumn("dbo.PhongChieu", "DienTich");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhongChieu", "DienTich", c => c.Double());
            DropColumn("dbo.PhongChieu", "TenPhong");
        }
    }
}
