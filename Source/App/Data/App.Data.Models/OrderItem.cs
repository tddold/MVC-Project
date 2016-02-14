namespace App.Data.Models
{
    using Common.Models;

    public class OrderItem: BaseModel<int>
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Discount { get; set; }
    }
}
