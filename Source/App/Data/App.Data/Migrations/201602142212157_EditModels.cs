namespace App.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropIndex("dbo.Images", new[] { "ProductId" });
            RenameColumn(table: "dbo.Images", name: "ProductId", newName: "Product_Id");
            AddColumn("dbo.Products", "Weight", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Manufacturer", c => c.String());
            AddColumn("dbo.Images", "Ordere", c => c.Int(nullable: false));
            AlterColumn("dbo.Images", "Product_Id", c => c.Int());
            CreateIndex("dbo.Images", "Product_Id");
            AddForeignKey("dbo.Images", "Product_Id", "dbo.Products", "Id");
            DropColumn("dbo.Products", "Lenght");
            DropColumn("dbo.Images", "Ordered");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Ordered", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Lenght", c => c.Double(nullable: false));
            DropForeignKey("dbo.Images", "Product_Id", "dbo.Products");
            DropIndex("dbo.Images", new[] { "Product_Id" });
            AlterColumn("dbo.Images", "Product_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Images", "Ordere");
            DropColumn("dbo.Products", "Manufacturer");
            DropColumn("dbo.Products", "Weight");
            RenameColumn(table: "dbo.Images", name: "Product_Id", newName: "ProductId");
            CreateIndex("dbo.Images", "ProductId");
            AddForeignKey("dbo.Images", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
