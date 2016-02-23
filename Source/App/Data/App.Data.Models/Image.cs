namespace App.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Common.Models;

    public class Image : BaseModel<int>
    {

        [Required]
        [MaxLength(500)]
        public string ImagePath { get; set; }

        [MaxLength(100)]
        public string Link { get; set; }

        public int Ordere { get; set; }
    }
}
