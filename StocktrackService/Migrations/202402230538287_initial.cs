namespace StocktrackService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qty = c.Int(nullable: false),
                        Category = c.String(),
                        Brand = c.String(),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        Type = c.String(),
                        Product_Id = c.Int(),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Store_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Transactions", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Store_Id", "dbo.Stores");
            DropIndex("dbo.Transactions", new[] { "Store_Id" });
            DropIndex("dbo.Transactions", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "Store_Id" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Stores");
            DropTable("dbo.Products");
        }
    }
}
