namespace Online_Store.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderandOrderItemsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(),
                        OrderedAt = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        PorductID = c.Int(nullable: false),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.OrderID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropIndex("dbo.OrderItems", new[] { "Product_ID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
        }
    }
}
