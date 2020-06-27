namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phim", "NgayKhoiChieu", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NhanVien", "NgaySinh", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhanVien", "NgaySinh", c => c.DateTime());
            AlterColumn("dbo.Phim", "NgayKhoiChieu", c => c.DateTime());
        }
    }
}
