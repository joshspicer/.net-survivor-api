namespace survivorapi2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Year = c.String(),
                        Major = c.String(),
                        Hometown = c.String(),
                        Tribe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tribes", t => t.Tribe_Id)
                .Index(t => t.Tribe_Id);
            
            CreateTable(
                "dbo.Tribes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Tribe_Id", "dbo.Tribes");
            DropIndex("dbo.Players", new[] { "Tribe_Id" });
            DropTable("dbo.Tribes");
            DropTable("dbo.Players");
        }
    }
}
