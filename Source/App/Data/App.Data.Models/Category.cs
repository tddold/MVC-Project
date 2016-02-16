namespace App.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Common.Models;

    public class Category : BaseModel<int>, IListedItem
    {
        private ICollection<Category> categories;
        private ICollection<Product> products;

        public Category()
        {
            this.categories = new HashSet<Category>();
            this.products = new HashSet<Product>();
        }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [MaxLength(500)]
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