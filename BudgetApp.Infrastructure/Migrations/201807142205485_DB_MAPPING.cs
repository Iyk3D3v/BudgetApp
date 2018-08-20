namespace BudgetApp.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_MAPPING : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        BudgetId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        expenditure = c.Decimal(nullable: false, precision: 18, scale: 2),
                        saving = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateCreated = c.String(),
                    })
                .PrimaryKey(t => t.BudgetId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        passwordHash = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Spendings",
                c => new
                    {
                        SpendingId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SpendingId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Budgets", "UserId", "dbo.Users");
            DropForeignKey("dbo.Spendings", "UserId", "dbo.Users");
            DropIndex("dbo.Spendings", new[] { "UserId" });
            DropIndex("dbo.Budgets", new[] { "UserId" });
            DropTable("dbo.Spendings");
            DropTable("dbo.Users");
            DropTable("dbo.Budgets");
        }
    }
}
