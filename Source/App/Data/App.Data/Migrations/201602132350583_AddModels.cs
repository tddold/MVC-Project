namespace App.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddModels : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    ImagePath = c.String(),
                    Description = c.String(),
                    ParentCategoryId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);

            this.CreateTable(
                "dbo.Products",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(maxLength: 100),
                    ShortDecription = c.String(maxLength: 40),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Quantity = c.Int(nullable: false),
                    Whidth = c.Double(nullable: false),
                    Heigth = c.Double(nullable: false),
                    Depht = c.Double(nullable: false),
                    Lenght = c.Double(nullable: false),
                    CategoryId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);

            this.CreateTable(
                "dbo.Images",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ImagePath = c.String(),
                    Link = c.String(),
                    ProductId = c.Int(nullable: false),
                    Ordered = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);

            this.CreateTable(
                "dbo.OrderItems",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    OrderId = c.Int(nullable: false),
                    ProductId = c.Int(nullable: false),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Quantity = c.Int(nullable: false),
                    Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);

            this.CreateTable(
                "dbo.Orders",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MyProperty = c.DateTime(nullable: false),
                    Status = c.Boolean(nullable: false),
                    Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    UserId = c.Int(nullable: false),
                    User_Id = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);

            this.CreateTable(
                "dbo.Pages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Link = c.String(),
                    ShowOnNav = c.Boolean(nullable: false),
                    PageTitle = c.String(),
                    PageContent = c.String(),
                })
                .PrimaryKey(t => t.Id);

            this.CreateTable(
                "dbo.PromotionItems",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PromotionId = c.Int(nullable: false),
                    ProductId = c.Int(nullable: false),
                    Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Percent = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.PromotionId, cascadeDelete: true)
                .Index(t => t.PromotionId)
                .Index(t => t.ProductId);

            this.CreateTable(
                "dbo.Promotions",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    StartDate = c.DateTime(),
                    EndDate = c.DateTime(),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            this.DropForeignKey("dbo.PromotionItems", "PromotionId", "dbo.Promotions");
            this.DropForeignKey("dbo.PromotionItems", "ProductId", "dbo.Products");
            this.DropForeignKey("dbo.OrderItems", "ProductId", "dbo.Products");
            this.DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            this.DropForeignKey("dbo.Orders", "User_Id", "dbo.AspNetUsers");
            this.DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            this.DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            this.DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            this.DropIndex("dbo.PromotionItems", new[] { "ProductId" });
            this.DropIndex("dbo.PromotionItems", new[] { "PromotionId" });
            this.DropIndex("dbo.Orders", new[] { "User_Id" });
            this.DropIndex("dbo.OrderItems", new[] { "ProductId" });
            this.DropIndex("dbo.OrderItems", new[] { "OrderId" });
            this.DropIndex("dbo.Images", new[] { "ProductId" });
            this.DropIndex("dbo.Products", new[] { "CategoryId" });
            this.DropIndex("dbo.Categories", new[] { "ParentCategoryId" });
            this.DropTable("dbo.Promotions");
            this.DropTable("dbo.PromotionItems");
            this.DropTable("dbo.Pages");
            this.DropTable("dbo.Orders");
            this.DropTable("dbo.OrderItems");
            this.DropTable("dbo.Images");
            this.DropTable("dbo.Products");
            this.DropTable("dbo.Categories");
        }
    }
}
