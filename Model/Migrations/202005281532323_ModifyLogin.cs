namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyLogin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien");
            DropPrimaryKey("dbo.Login");
            AddColumn("dbo.Login", "UserName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Login", "Password", c => c.String());
            AddPrimaryKey("dbo.Login", "UserName");
            AddForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien", "MaNhanVien", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien");
            DropPrimaryKey("dbo.Login");
            DropColumn("dbo.Login", "Password");
            DropColumn("dbo.Login", "UserName");
            AddPrimaryKey("dbo.Login", "MaNhanVien");
            AddForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien", "MaNhanVien");
        }
    }
}
