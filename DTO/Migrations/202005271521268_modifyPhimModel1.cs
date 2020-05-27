namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyPhimModel1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Phim");
            AlterColumn("dbo.Phim", "MaPhim", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Phim", "MaPhim");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Phim");
            AlterColumn("dbo.Phim", "MaPhim", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Phim", "MaPhim");
        }
    }
}
