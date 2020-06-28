namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_login : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien");
            DropPrimaryKey("dbo.Login");
            AlterColumn("dbo.Login", "UserName", c => c.String());
            AddPrimaryKey("dbo.Login", "MaNhanVien");
            AddForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien", "MaNhanVien");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien");
            DropPrimaryKey("dbo.Login");
            AlterColumn("dbo.Login", "UserName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Login", new[] { "UserName", "MaNhanVien" });
            AddForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien", "MaNhanVien", cascadeDelete: true);
        }
    }
}
