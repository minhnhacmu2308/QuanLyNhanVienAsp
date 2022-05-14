namespace QuanLyNhanVienAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChamCongs",
                c => new
                    {
                        idChamCong = c.Int(nullable: false, identity: true),
                        idNhanVien = c.Int(nullable: false),
                        ngayChamCong = c.String(),
                    })
                .PrimaryKey(t => t.idChamCong)
                .ForeignKey("dbo.NhanViens", t => t.idNhanVien)
                .Index(t => t.idNhanVien);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        idNhanVien = c.Int(nullable: false, identity: true),
                        hoTen = c.String(maxLength: 255),
                        soDienThoai = c.String(maxLength: 255),
                        gioiTinh = c.String(maxLength: 255),
                        diaChi = c.String(maxLength: 255),
                        email = c.String(maxLength: 255),
                        ngaySinh = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.idNhanVien);
            
            CreateTable(
                "dbo.Luongs",
                c => new
                    {
                        idLuong = c.Int(nullable: false, identity: true),
                        idNhanVien = c.Int(nullable: false),
                        tienLuong = c.Int(nullable: false),
                        thang = c.Int(nullable: false),
                        loaiTienLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idLuong)
                .ForeignKey("dbo.NhanViens", t => t.idNhanVien)
                .Index(t => t.idNhanVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Luongs", "idNhanVien", "dbo.NhanViens");
            DropForeignKey("dbo.ChamCongs", "idNhanVien", "dbo.NhanViens");
            DropIndex("dbo.Luongs", new[] { "idNhanVien" });
            DropIndex("dbo.ChamCongs", new[] { "idNhanVien" });
            DropTable("dbo.Luongs");
            DropTable("dbo.NhanViens");
            DropTable("dbo.ChamCongs");
        }
    }
}
