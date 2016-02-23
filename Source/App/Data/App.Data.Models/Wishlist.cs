namespace App.Data.Models
{
    using Data.Common.Models;
    using System.Collections.Generic;

    public class Wishlist : BaseModel<int>
    {
        private HashSet<Product> products;

        public Wishlist()
        {
            this.products = new HashSet<Product>();
        }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
