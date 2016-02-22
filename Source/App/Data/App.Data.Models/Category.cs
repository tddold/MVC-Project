namespace App.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Common.Models;

    public class Category : BaseModel<int>, IListedItem
    {
        private ICollection<Category> categories;
        private ICollection<Product> products;
        private ICollection<Manufacturer> manufacturers;

        public Category()
        {
            this.categories = new HashSet<Category>();
            this.products = new HashSet<Product>();
            this.manufacturers = new HashSet<Manufacturer>();
        }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Manufacturer> Manufacturers
        {
            get { return this.manufacturers; }
            set { this.manufacturers = value; }
        }   

        public virtual ICollection<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }
    }
}