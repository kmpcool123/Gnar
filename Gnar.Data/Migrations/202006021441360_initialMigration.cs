namespace Gnar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bearings",
                c => new
                    {
                        BearingId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        BearingName = c.String(nullable: false, maxLength: 100),
                        Brand = c.String(maxLength: 100),
                        AbecRating = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        ProModel = c.String(maxLength: 100),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.BearingId);
            
            CreateTable(
                "dbo.Deck",
                c => new
                    {
                        DeckId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        DeckName = c.String(nullable: false, maxLength: 100),
                        Brand = c.String(maxLength: 100),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProModel = c.String(maxLength: 100),
                        Shape = c.String(maxLength: 100),
                        WheelBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.DeckId);
            
            CreateTable(
                "dbo.GripTape",
                c => new
                    {
                        GripTapeId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        GripTapeName = c.String(nullable: false, maxLength: 100),
                        Width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProModel = c.String(maxLength: 100),
                        Color = c.String(),
                        Brand = c.String(maxLength: 100),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.GripTapeId);
            
            CreateTable(
                "dbo.HardWare",
                c => new
                    {
                        HardWareId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        HardWareName = c.String(nullable: false, maxLength: 100),
                        ProModel = c.String(maxLength: 100),
                        Brand = c.String(maxLength: 100),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.HardWareId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Trucks",
                c => new
                    {
                        TruckId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        TruckName = c.String(nullable: false, maxLength: 100),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Brand = c.String(maxLength: 100),
                        ProModel = c.String(maxLength: 100),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.TruckId);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Wheels",
                c => new
                    {
                        WheelId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        WheelName = c.String(nullable: false, maxLength: 100),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProModel = c.String(maxLength: 100),
                        Brand = c.String(maxLength: 100),
                        Softness = c.Int(nullable: false),
                        Type = c.String(),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.WheelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropTable("dbo.Wheels");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.Trucks");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.HardWare");
            DropTable("dbo.GripTape");
            DropTable("dbo.Deck");
            DropTable("dbo.Bearings");
        }
    }
}
