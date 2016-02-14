namespace App.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Models;

    public class Image: BaseModel<int>
    {
        public string ImagePath { get; set; }

        public string Link { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Ordered { get; set; }
    }
}
