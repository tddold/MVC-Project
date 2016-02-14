namespace App.Data.Models
{
    using System.Collections.Generic;
    using Common.Models;

    public class Category: BaseModel<int>
    {
        private ICollection<Category> categories;
        private ICollection<Product> products;

        public Category()
        {
            this.categories = new HashSet<Category>();
            this.products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }

        public virtual ICollection<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }
    }
}