namespace CarsAndTheirUsers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessibilities",
                c => new
                    {
                        AccessibilityID = c.Int(nullable: false, identity: true),
                        CarID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccessibilityID)
                .ForeignKey("dbo.Cars", t => t.CarID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.CarID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        CarName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CarID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accessibilities", "UserID", "dbo.Users");
            DropForeignKey("dbo.Accessibilities", "CarID", "dbo.Cars");
            DropIndex("dbo.Accessibilities", new[] { "UserID" });
            DropIndex("dbo.Accessibilities", new[] { "CarID" });
            DropTable("dbo.Users");
            DropTable("dbo.Cars");
            DropTable("dbo.Accessibilities");
        }
    }
}
