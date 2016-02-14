namespace App.Data.Models
{
    using App.Data.Common.Models;

    public class PromotionItem: BaseModel<int>
    {
        public int PromotionId { get; set; }

        public virtual Promotion Propmotion { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public decimal Discount { get; set; }

        public int Percent { get; set; }
    }
}
