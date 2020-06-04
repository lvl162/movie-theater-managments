namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyLogin1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Login", "role", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Login", "role");
        }
    }
}
