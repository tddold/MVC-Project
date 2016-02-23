namespace App.Web.ViewModels.Categories
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using App.Data.Models;
    using App.Web.Infrastructure.Mapping;
    using System.Collections.Generic;
    using Services.Web.Contracts;
    using Services.Web;

    [Bind(Exclude = "Id,ImagePath")]
    public class CategoryViewModel : IMapFrom<Category>, IMapTo<Category>
    {
        private ISanitizer sanitaizer;

        public CategoryViewModel()
        {
            this.sanitaizer = new HtmlSanitizerAdapter();
        }

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [MaxLength(5000)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string DescriptionSanitaized
        {
            get
            {
                return this.sanitaizer.Sanitize(this.Description);
            }
        }

        public ICollection<Manufacturer> Manufacturers { get; set; }
    }
}