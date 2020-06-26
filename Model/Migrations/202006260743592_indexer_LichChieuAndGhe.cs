namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class indexer_LichChieuAndGhe : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.DatVe", new[] { "MaLichChieu" });
            DropIndex("dbo.DatVe", new[] { "MaGhe" });
            CreateIndex("dbo.DatVe", new[] { "MaLichChieu", "MaGhe" }, unique: true, name: "IX_LichChieu_Ghe");
        }
        
        public override void Down()
        {
            DropIndex("dbo.DatVe", "IX_LichChieu_Ghe");
            CreateIndex("dbo.DatVe", "MaGhe");
            CreateIndex("dbo.DatVe", "MaLichChieu");
        }
    }
}
