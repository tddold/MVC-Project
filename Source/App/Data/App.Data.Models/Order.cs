namespace App.Data.Models
{
    using Common.Models;
    using System;

    public class Order: BaseModel<int>
    {
        public bool Status { get; set; }

        public decimal Total { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
