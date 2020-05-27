namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyPhimModel2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PhongChieu");
            AlterColumn("dbo.PhongChieu", "MaPhong", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PhongChieu", "MaPhong");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PhongChieu");
            AlterColumn("dbo.PhongChieu", "MaPhong", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.PhongChieu", "MaPhong");
        }
    }
}
