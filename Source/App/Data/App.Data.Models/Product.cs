namespace App.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Models;
    public class Product: BaseModel<int>
    {
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [MaxLength(40)]
        public string ShortDecription { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public double Whidth { get; set; }

        public double Heigth { get; set; }

        public double Depht { get; set; }

        public double Lenght { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
