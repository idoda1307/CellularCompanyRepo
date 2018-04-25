namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CallsEntities",
                c => new
                    {
                        CallId = c.Int(nullable: false, identity: true),
                        Duration = c.Double(nullable: false),
                        ExternalPrice = c.Double(nullable: false),
                        DestinationNumber = c.String(),
                        LineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CallId)
                .ForeignKey("dbo.LineEntities", t => t.LineId, cascadeDelete: true)
                .Index(t => t.LineId);
            
            CreateTable(
                "dbo.LineEntities",
                c => new
                    {
                        LineId = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Status = c.String(),
                        PackageId = c.Int(nullable: false),
                        ClientId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.LineId)
                .ForeignKey("dbo.ClientEntities", t => t.ClientId)
                .ForeignKey("dbo.PackageEntities", t => t.PackageId, cascadeDelete: true)
                .Index(t => t.PackageId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.ClientEntities",
                c => new
                    {
                        ClientId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        ContactNumber = c.String(),
                        CallsToCenter = c.Int(),
                        ClientTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.ClientTypeEntities", t => t.ClientTypeId)
                .Index(t => t.ClientTypeId);
            
            CreateTable(
                "dbo.ClientTypeEntities",
                c => new
                    {
                        ClientTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        MinutePrice = c.Double(),
                        SMSPrice = c.Double(),
                    })
                .PrimaryKey(t => t.ClientTypeId);
            
            CreateTable(
                "dbo.PaymentEntities",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TotalPayment = c.Double(nullable: false),
                        ClientId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.ClientEntities", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.PackageEntities",
                c => new
                    {
                        PackageId = c.Int(nullable: false, identity: true),
                        PackageName = c.String(),
                        PackageTotalPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PackageId);
            
            CreateTable(
                "dbo.PackageIncludesEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncludeName = c.String(),
                        MaxMinute = c.Int(nullable: false),
                        FixedPrice = c.Double(nullable: false),
                        DiscountPrecentage = c.Double(nullable: false),
                        MostCalledNumber = c.Boolean(nullable: false),
                        InsideFamilyCalls = c.Boolean(nullable: false),
                        FavoriteNumbersId = c.Int(nullable: false),
                        PackageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PackageEntities", t => t.PackageId, cascadeDelete: true)
                .ForeignKey("dbo.SelectedNumbersEntities", t => t.FavoriteNumbersId, cascadeDelete: true)
                .Index(t => t.FavoriteNumbersId)
                .Index(t => t.PackageId);
            
            CreateTable(
                "dbo.SelectedNumbersEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstNumber = c.String(),
                        SecondNumber = c.String(),
                        ThirdNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SMSEntities",
                c => new
                    {
                        SMSId = c.Int(nullable: false, identity: true),
                        ExternalPrice = c.Double(nullable: false),
                        DestinationNumber = c.String(),
                        LineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SMSId)
                .ForeignKey("dbo.LineEntities", t => t.LineId, cascadeDelete: true)
                .Index(t => t.LineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CallsEntities", "LineId", "dbo.LineEntities");
            DropForeignKey("dbo.SMSEntities", "LineId", "dbo.LineEntities");
            DropForeignKey("dbo.LineEntities", "PackageId", "dbo.PackageEntities");
            DropForeignKey("dbo.PackageIncludesEntities", "FavoriteNumbersId", "dbo.SelectedNumbersEntities");
            DropForeignKey("dbo.PackageIncludesEntities", "PackageId", "dbo.PackageEntities");
            DropForeignKey("dbo.LineEntities", "ClientId", "dbo.ClientEntities");
            DropForeignKey("dbo.PaymentEntities", "ClientId", "dbo.ClientEntities");
            DropForeignKey("dbo.ClientEntities", "ClientTypeId", "dbo.ClientTypeEntities");
            DropIndex("dbo.SMSEntities", new[] { "LineId" });
            DropIndex("dbo.PackageIncludesEntities", new[] { "PackageId" });
            DropIndex("dbo.PackageIncludesEntities", new[] { "FavoriteNumbersId" });
            DropIndex("dbo.PaymentEntities", new[] { "ClientId" });
            DropIndex("dbo.ClientEntities", new[] { "ClientTypeId" });
            DropIndex("dbo.LineEntities", new[] { "ClientId" });
            DropIndex("dbo.LineEntities", new[] { "PackageId" });
            DropIndex("dbo.CallsEntities", new[] { "LineId" });
            DropTable("dbo.SMSEntities");
            DropTable("dbo.SelectedNumbersEntities");
            DropTable("dbo.PackageIncludesEntities");
            DropTable("dbo.PackageEntities");
            DropTable("dbo.PaymentEntities");
            DropTable("dbo.ClientTypeEntities");
            DropTable("dbo.ClientEntities");
            DropTable("dbo.LineEntities");
            DropTable("dbo.CallsEntities");
        }
    }
}
