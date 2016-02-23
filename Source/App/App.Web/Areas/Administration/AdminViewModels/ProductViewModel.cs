namespace App.Web.Areas.Administration.AdminViewModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using AutoMapper;
    using Infrastructure.Mapping;

    using Data.Models;
    using Services.Web.Contracts;
    using Services.Web;

    public class ProductViewModel : IHaveCustomMappings
    {
        private ISanitizer sanitaizer;

        public ProductViewModel()
        {
            this.sanitaizer = new HtmlSanitizerAdapter();
        }

        [HiddenInput]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [MaxLength(10000)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        // [Display(Name = "Description")]
        // public string DescriptionSanitaized
        // {
        //    get
        //    {
        //        return this.sanitaizer.Sanitize(this.Description);
        //    }
        //    set
        //    {
        //        this.Description = this.sanitaizer.Sanitize(value);
        //    }
        // }
        [MaxLength(2000)]
        [Display(Name = "Short Description")]
        [DataType(DataType.MultilineText)]
        public string ShortDecription { get; set; }

        // public string ShortDecriptionSanitaized
        // {
        //    get
        //    {
        //        return this.sanitaizer.Sanitize(this.Description);
        //    }
        // }
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        public double Whidth { get; set; }

        public double Heigth { get; set; }

        public double Depht { get; set; }

        public double Weight { get; set; }

        [Required]
        [UIHint("DropDownListManufacturer")]
        public int ManufacturerId { get; set; }

        [Required]
        [UIHint("DropDownListCategory")]
        public int CategoryId { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Product, ProductViewModel>()
                .ForMember(x => x.ManufacturerId, opt => opt.MapFrom(x => (x.ManufacturerId == null && !x.ManufacturerId.HasValue) ? 0 : x.ManufacturerId.Value))
                .ReverseMap();
        }
    }
}