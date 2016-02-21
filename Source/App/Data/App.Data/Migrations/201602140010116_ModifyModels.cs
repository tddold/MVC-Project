namespace App.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ModifyModels : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Categories", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.Categories", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.Categories", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.Categories", "DeletedOn", c => c.DateTime());
            this.AddColumn("dbo.Products", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.Products", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.Products", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.Products", "DeletedOn", c => c.DateTime());
            this.AddColumn("dbo.Images", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.Images", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.Images", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.Images", "DeletedOn", c => c.DateTime());
            this.AddColumn("dbo.OrderItems", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.OrderItems", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.OrderItems", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.OrderItems", "DeletedOn", c => c.DateTime());
            this.AddColumn("dbo.Orders", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.Orders", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.Orders", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.Orders", "DeletedOn", c => c.DateTime());
            this.AddColumn("dbo.Pages", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.Pages", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.Pages", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.Pages", "DeletedOn", c => c.DateTime());
            this.AddColumn("dbo.PromotionItems", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.PromotionItems", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.PromotionItems", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.PromotionItems", "DeletedOn", c => c.DateTime());
            this.AddColumn("dbo.Promotions", "CreatedOn", c => c.DateTime(nullable: false));
            this.AddColumn("dbo.Promotions", "ModifiedOn", c => c.DateTime());
            this.AddColumn("dbo.Promotions", "IsDeleted", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.Promotions", "DeletedOn", c => c.DateTime());
            this.CreateIndex("dbo.Categories", "IsDeleted");
            this.CreateIndex("dbo.Products", "IsDeleted");
            this.CreateIndex("dbo.Images", "IsDeleted");
            this.CreateIndex("dbo.OrderItems", "IsDeleted");
            this.CreateIndex("dbo.Orders", "IsDeleted");
            this.CreateIndex("dbo.Pages", "IsDeleted");
            this.CreateIndex("dbo.PromotionItems", "IsDeleted");
            this.CreateIndex("dbo.Promotions", "IsDeleted");
            this.DropColumn("dbo.Orders", "MyProperty");
        }

        public override void Down()
        {
            this.AddColumn("dbo.Orders", "MyProperty", c => c.DateTime(nullable: false));
            this.DropIndex("dbo.Promotions", new[] { "IsDeleted" });
            this.DropIndex("dbo.PromotionItems", new[] { "IsDeleted" });
            this.DropIndex("dbo.Pages", new[] { "IsDeleted" });
            this.DropIndex("dbo.Orders", new[] { "IsDeleted" });
            this.DropIndex("dbo.OrderItems", new[] { "IsDeleted" });
            this.DropIndex("dbo.Images", new[] { "IsDeleted" });
            this.DropIndex("dbo.Products", new[] { "IsDeleted" });
            this.DropIndex("dbo.Categories", new[] { "IsDeleted" });
            this.DropColumn("dbo.Promotions", "DeletedOn");
            this.DropColumn("dbo.Promotions", "IsDeleted");
            this.DropColumn("dbo.Promotions", "ModifiedOn");
            this.DropColumn("dbo.Promotions", "CreatedOn");
            this.DropColumn("dbo.PromotionItems", "DeletedOn");
            this.DropColumn("dbo.PromotionItems", "IsDeleted");
            this.DropColumn("dbo.PromotionItems", "ModifiedOn");
            this.DropColumn("dbo.PromotionItems", "CreatedOn");
            this.DropColumn("dbo.Pages", "DeletedOn");
            this.DropColumn("dbo.Pages", "IsDeleted");
            this.DropColumn("dbo.Pages", "ModifiedOn");
            this.DropColumn("dbo.Pages", "CreatedOn");
            this.DropColumn("dbo.Orders", "DeletedOn");
            this.DropColumn("dbo.Orders", "IsDeleted");
            this.DropColumn("dbo.Orders", "ModifiedOn");
            this.DropColumn("dbo.Orders", "CreatedOn");
            this.DropColumn("dbo.OrderItems", "DeletedOn");
            this.DropColumn("dbo.OrderItems", "IsDeleted");
            this.DropColumn("dbo.OrderItems", "ModifiedOn");
            this.DropColumn("dbo.OrderItems", "CreatedOn");
            this.DropColumn("dbo.Images", "DeletedOn");
            this.DropColumn("dbo.Images", "IsDeleted");
            this.DropColumn("dbo.Images", "ModifiedOn");
            this.DropColumn("dbo.Images", "CreatedOn");
            this.DropColumn("dbo.Products", "DeletedOn");
            this.DropColumn("dbo.Products", "IsDeleted");
            this.DropColumn("dbo.Products", "ModifiedOn");
            this.DropColumn("dbo.Products", "CreatedOn");
            this.DropColumn("dbo.Categories", "DeletedOn");
            this.DropColumn("dbo.Categories", "IsDeleted");
            this.DropColumn("dbo.Categories", "ModifiedOn");
            this.DropColumn("dbo.Categories", "CreatedOn");
        }
    }
}
