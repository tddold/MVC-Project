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

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
