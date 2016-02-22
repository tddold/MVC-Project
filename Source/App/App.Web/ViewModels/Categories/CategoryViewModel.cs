namespace App.Web.ViewModels.Categories
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using App.Data.Models;
    using App.Web.Infrastructure.Mapping;
    using System.Collections.Generic;
    [Bind(Exclude = "Id,ImagePath")]
    public class CategoryViewModel : IMapFrom<Category>, IMapTo<Category>
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [MaxLength(500)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ICollection<Manufacturer> Manufacturers{ get; set; }
    }
}