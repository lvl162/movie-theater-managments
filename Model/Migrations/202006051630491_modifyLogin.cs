namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyLogin : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Login");
            AddPrimaryKey("dbo.Login", new[] { "UserName", "MaNhanVien" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Login");
            AddPrimaryKey("dbo.Login", "UserName");
        }
    }
}
