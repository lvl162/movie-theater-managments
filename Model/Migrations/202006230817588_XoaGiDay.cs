namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XoaGiDay : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DatVe", "LoaiVe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DatVe", "LoaiVe", c => c.String());
        }
    }
}
