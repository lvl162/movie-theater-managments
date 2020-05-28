namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false, identity: true),
                        HoVaTen = c.String(),
                        SDT = c.String(),
                        NgaySinh = c.DateTime(),
                        SoCMND = c.String(),
                        DiaChi = c.String(),
                        GioiTinh = c.String(),
                        ChucVu = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanVien");
        }
    }
}
