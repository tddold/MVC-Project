namespace App.Data.Models
{
    using System.Collections.Generic;
    using Data.Common.Models;
    public class ShoppingCart : BaseModel<int>
    {
        private HashSet<Product> products;

        public ShoppingCart()
        {
            this.products = new HashSet<Product>();
        }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
