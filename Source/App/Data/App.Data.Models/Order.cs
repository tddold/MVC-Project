namespace App.Data.Models
{
    using Common.Models;

    public class Order : BaseModel<int>
    {
        public bool Status { get; set; }

        public decimal Total { get; set; }

        public int DeliveryAdressId { get; set; }

        public virtual DeliveryAdress DeliveryAdress { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
