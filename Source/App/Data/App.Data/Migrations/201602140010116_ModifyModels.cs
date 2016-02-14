namespace App.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Categories", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Categories", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categories", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.Products", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Products", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.Images", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Images", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Images", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Images", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.OrderItems", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.OrderItems", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.OrderItems", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderItems", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.Orders", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Orders", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.Pages", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pages", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Pages", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pages", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.PromotionItems", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.PromotionItems", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.PromotionItems", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.PromotionItems", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.Promotions", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Promotions", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Promotions", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Promotions", "DeletedOn", c => c.DateTime());
            CreateIndex("dbo.Categories", "IsDeleted");
            CreateIndex("dbo.Products", "IsDeleted");
            CreateIndex("dbo.Images", "IsDeleted");
            CreateIndex("dbo.OrderItems", "IsDeleted");
            CreateIndex("dbo.Orders", "IsDeleted");
            CreateIndex("dbo.Pages", "IsDeleted");
            CreateIndex("dbo.PromotionItems", "IsDeleted");
            CreateIndex("dbo.Promotions", "IsDeleted");
            DropColumn("dbo.Orders", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "MyProperty", c => c.DateTime(nullable: false));
            DropIndex("dbo.Promotions", new[] { "IsDeleted" });
            DropIndex("dbo.PromotionItems", new[] { "IsDeleted" });
            DropIndex("dbo.Pages", new[] { "IsDeleted" });
            DropIndex("dbo.Orders", new[] { "IsDeleted" });
            DropIndex("dbo.OrderItems", new[] { "IsDeleted" });
            DropIndex("dbo.Images", new[] { "IsDeleted" });
            DropIndex("dbo.Products", new[] { "IsDeleted" });
            DropIndex("dbo.Categories", new[] { "IsDeleted" });
            DropColumn("dbo.Promotions", "DeletedOn");
            DropColumn("dbo.Promotions", "IsDeleted");
            DropColumn("dbo.Promotions", "ModifiedOn");
            DropColumn("dbo.Promotions", "CreatedOn");
            DropColumn("dbo.PromotionItems", "DeletedOn");
            DropColumn("dbo.PromotionItems", "IsDeleted");
            DropColumn("dbo.PromotionItems", "ModifiedOn");
            DropColumn("dbo.PromotionItems", "CreatedOn");
            DropColumn("dbo.Pages", "DeletedOn");
            DropColumn("dbo.Pages", "IsDeleted");
            DropColumn("dbo.Pages", "ModifiedOn");
            DropColumn("dbo.Pages", "CreatedOn");
            DropColumn("dbo.Orders", "DeletedOn");
            DropColumn("dbo.Orders", "IsDeleted");
            DropColumn("dbo.Orders", "ModifiedOn");
            DropColumn("dbo.Orders", "CreatedOn");
            DropColumn("dbo.OrderItems", "DeletedOn");
            DropColumn("dbo.OrderItems", "IsDeleted");
            DropColumn("dbo.OrderItems", "ModifiedOn");
            DropColumn("dbo.OrderItems", "CreatedOn");
            DropColumn("dbo.Images", "DeletedOn");
            DropColumn("dbo.Images", "IsDeleted");
            DropColumn("dbo.Images", "ModifiedOn");
            DropColumn("dbo.Images", "CreatedOn");
            DropColumn("dbo.Products", "DeletedOn");
            DropColumn("dbo.Products", "IsDeleted");
            DropColumn("dbo.Products", "ModifiedOn");
            DropColumn("dbo.Products", "CreatedOn");
            DropColumn("dbo.Categories", "DeletedOn");
            DropColumn("dbo.Categories", "IsDeleted");
            DropColumn("dbo.Categories", "ModifiedOn");
            DropColumn("dbo.Categories", "CreatedOn");
        }
    }
}
