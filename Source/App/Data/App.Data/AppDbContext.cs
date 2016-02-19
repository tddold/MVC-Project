namespace App.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Common.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Image> Images { get; set; }

        public IDbSet<Order> Orders { get; set; }

        public IDbSet<OrderItem> OrderItems { get; set; }

        public IDbSet<Page> Pages { get; set; }

        public IDbSet<Promotion> Promotions { get; set; }

        public IDbSet<PromotionItem> PromotionItems { get; set; }

        public IDbSet<Address> Addresses { get; set; }

        public IDbSet<City> Cities { get; set; }

        public IDbSet<Country> Countries { get; set; }

        public IDbSet<DeliveryAdress> DeliveryAdresses { get; set; }

        public IDbSet<ShoppingCart> ShoppingCarts { get; set; }

        public IDbSet<Wishlist> Wishlists { get; set; }



        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

        public new IDbSet<T> Set<T>()
           where T : class
        {
            return base.Set<T>();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }       
    }
}