namespace App.Data.Models
{
    using System.Collections.Generic;

    using App.Data.Common.Models;

    public class Manufacturer : BaseModel<int>
    {
        private HashSet<Category> categories;
        private HashSet<Product> products;

        public Manufacturer()
        {
            this.categories = new HashSet<Category>();
            this.products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
