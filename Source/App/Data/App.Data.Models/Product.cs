namespace App.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Common.Models;

    public class Product : BaseModel<int>
    {
        private ICollection<Image> images;

        public Product()
        {
            this.images = new HashSet<Image>();
        }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string ShortDecription { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImagePath { get; set; }

        public double Whidth { get; set; }

        public double Heigth { get; set; }

        public double Depht { get; set; }

        public double Weight { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public int? ManufacturerId { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        //public virtual ICollection<Image> Images
        //{
        //    get { return this.images; }
        //    set { this.images = value; }
        //}
    }
}
