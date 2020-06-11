namespace DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAuditForEachTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DatVe", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.DatVe", "NguoiTao", c => c.String());
            AddColumn("dbo.DatVe", "NgayTao", c => c.DateTime(nullable: false));
            AddColumn("dbo.DatVe", "NguoiSua", c => c.String());
            AddColumn("dbo.DatVe", "NgaySua", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ghe", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Ghe", "NguoiTao", c => c.String());
            AddColumn("dbo.Ghe", "NgayTao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ghe", "NguoiSua", c => c.String());
            AddColumn("dbo.Ghe", "NgaySua", c => c.DateTime(nullable: false));
            AddColumn("dbo.PhongChieu", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.PhongChieu", "NguoiTao", c => c.String());
            AddColumn("dbo.PhongChieu", "NgayTao", c => c.DateTime(nullable: false));
            AddColumn("dbo.PhongChieu", "NguoiSua", c => c.String());
            AddColumn("dbo.PhongChieu", "NgaySua", c => c.DateTime(nullable: false));
            AddColumn("dbo.LichChieu", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.LichChieu", "NguoiTao", c => c.String());
            AddColumn("dbo.LichChieu", "NgayTao", c => c.DateTime(nullable: false));
            AddColumn("dbo.LichChieu", "NguoiSua", c => c.String());
            AddColumn("dbo.LichChieu", "NgaySua", c => c.DateTime(nullable: false));
            AddColumn("dbo.Phim", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Phim", "NguoiTao", c => c.String());
            AddColumn("dbo.Phim", "NgayTao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Phim", "NguoiSua", c => c.String());
            AddColumn("dbo.Phim", "NgaySua", c => c.DateTime(nullable: false));
            AddColumn("dbo.Login", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Login", "NguoiTao", c => c.String());
            AddColumn("dbo.Login", "NgayTao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Login", "NguoiSua", c => c.String());
            AddColumn("dbo.Login", "NgaySua", c => c.DateTime(nullable: false));
            AddColumn("dbo.NhanVien", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.NhanVien", "NguoiTao", c => c.String());
            AddColumn("dbo.NhanVien", "NgayTao", c => c.DateTime(nullable: false));
            AddColumn("dbo.NhanVien", "NguoiSua", c => c.String());
            AddColumn("dbo.NhanVien", "NgaySua", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanVien", "NgaySua");
            DropColumn("dbo.NhanVien", "NguoiSua");
            DropColumn("dbo.NhanVien", "NgayTao");
            DropColumn("dbo.NhanVien", "NguoiTao");
            DropColumn("dbo.NhanVien", "RowVersion");
            DropColumn("dbo.Login", "NgaySua");
            DropColumn("dbo.Login", "NguoiSua");
            DropColumn("dbo.Login", "NgayTao");
            DropColumn("dbo.Login", "NguoiTao");
            DropColumn("dbo.Login", "RowVersion");
            DropColumn("dbo.Phim", "NgaySua");
            DropColumn("dbo.Phim", "NguoiSua");
            DropColumn("dbo.Phim", "NgayTao");
            DropColumn("dbo.Phim", "NguoiTao");
            DropColumn("dbo.Phim", "RowVersion");
            DropColumn("dbo.LichChieu", "NgaySua");
            DropColumn("dbo.LichChieu", "NguoiSua");
            DropColumn("dbo.LichChieu", "NgayTao");
            DropColumn("dbo.LichChieu", "NguoiTao");
            DropColumn("dbo.LichChieu", "RowVersion");
            DropColumn("dbo.PhongChieu", "NgaySua");
            DropColumn("dbo.PhongChieu", "NguoiSua");
            DropColumn("dbo.PhongChieu", "NgayTao");
            DropColumn("dbo.PhongChieu", "NguoiTao");
            DropColumn("dbo.PhongChieu", "RowVersion");
            DropColumn("dbo.Ghe", "NgaySua");
            DropColumn("dbo.Ghe", "NguoiSua");
            DropColumn("dbo.Ghe", "NgayTao");
            DropColumn("dbo.Ghe", "NguoiTao");
            DropColumn("dbo.Ghe", "RowVersion");
            DropColumn("dbo.DatVe", "NgaySua");
            DropColumn("dbo.DatVe", "NguoiSua");
            DropColumn("dbo.DatVe", "NgayTao");
            DropColumn("dbo.DatVe", "NguoiTao");
            DropColumn("dbo.DatVe", "RowVersion");
        }
    }
}
