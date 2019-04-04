namespace OgrenciSinif.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YasEkle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ogrenci", "Yas", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ogrenci", "Yas");
        }
    }
}
