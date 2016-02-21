namespace App.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class EditModels : DbMigration
    {
        public override void Up()
        {
            this.DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            this.DropIndex("dbo.Images", new[] { "ProductId" });
            this.RenameColumn(table: "dbo.Images", name: "ProductId", newName: "Product_Id");
            this.AddColumn("dbo.Products", "Weight", c => c.Double(nullable: false));
            this.AddColumn("dbo.Products", "Manufacturer", c => c.String());
            this.AddColumn("dbo.Images", "Ordere", c => c.Int(nullable: false));
            this.AlterColumn("dbo.Images", "Product_Id", c => c.Int());
            this.CreateIndex("dbo.Images", "Product_Id");
            this.AddForeignKey("dbo.Images", "Product_Id", "dbo.Products", "Id");
            this.DropColumn("dbo.Products", "Lenght");
            this.DropColumn("dbo.Images", "Ordered");
        }

        public override void Down()
        {
            this.AddColumn("dbo.Images", "Ordered", c => c.Int(nullable: false));
            this.AddColumn("dbo.Products", "Lenght", c => c.Double(nullable: false));
            this.DropForeignKey("dbo.Images", "Product_Id", "dbo.Products");
            this.DropIndex("dbo.Images", new[] { "Product_Id" });
            this.AlterColumn("dbo.Images", "Product_Id", c => c.Int(nullable: false));
            this.DropColumn("dbo.Images", "Ordere");
            this.DropColumn("dbo.Products", "Manufacturer");
            this.DropColumn("dbo.Products", "Weight");
            this.RenameColumn(table: "dbo.Images", name: "Product_Id", newName: "ProductId");
            this.CreateIndex("dbo.Images", "ProductId");
            this.AddForeignKey("dbo.Images", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
