namespace MasterDetailsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productIdRemoveFromPurchaseDetail : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.PurchaseDetails", new[] { "ProductId" });
            AddColumn("dbo.PurchaseDetails", "Name", c => c.String());
            DropColumn("dbo.PurchaseDetails", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseDetails", "ProductId", c => c.Long(nullable: false));
            DropColumn("dbo.PurchaseDetails", "Name");
            CreateIndex("dbo.PurchaseDetails", "ProductId");
            AddForeignKey("dbo.PurchaseDetails", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
        }
    }
}
