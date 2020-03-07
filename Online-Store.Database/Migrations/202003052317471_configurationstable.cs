namespace Online_Store.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configurationstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.configs",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.configs");
        }
    }
}
