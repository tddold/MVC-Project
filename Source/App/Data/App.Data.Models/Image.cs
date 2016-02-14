namespace App.Data.Models
{
    using Common.Models;

    public class Image: BaseModel<int>
    {
        public string ImagePath { get; set; }

        public string Link { get; set; }

        public int Ordere { get; set; }
    }
}
