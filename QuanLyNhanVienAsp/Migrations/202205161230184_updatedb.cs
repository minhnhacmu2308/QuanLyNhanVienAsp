namespace QuanLyNhanVienAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Luongs", "loaiTienLuong", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Luongs", "loaiTienLuong", c => c.Int(nullable: false));
        }
    }
}
