namespace Online_Store.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnlineStoreConnection : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
