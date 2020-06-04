namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteLogin_role : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Login", "role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Login", "role", c => c.Int(nullable: false));
        }
    }
}
