namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.NhanVien", t => t.MaNhanVien)
                .Index(t => t.MaNhanVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien");
            DropIndex("dbo.Login", new[] { "MaNhanVien" });
            DropTable("dbo.Login");
        }
    }
}
