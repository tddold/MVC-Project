namespace App.Web.ViewModels.Products
{
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;
    using Infrastructure.Mapping;

    using Data.Models;
    using Services.Web.Contracts;
    using Services.Web;
    using System.Web.Mvc;

    public class ProductDetailsViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        private ISanitizer sanitaizer;

        public ProductDetailsViewModel()
        {
            this.sanitaizer = new HtmlSanitizerAdapter();
        }

        [HiddenInput]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "Model")]
        public string Name { get; set; }

        [MaxLength(10000)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public string DescriptionSanitaized
        {
            get
            {
                return this.sanitaizer.Sanitize(this.Description);
            }
        }

        [MaxLength(2000)]
        [Display(Name = "Short Description")]
        public string ShortDecription { get; set; }

        public string ShortDecriptionSanitaized
        {
            get
            {
                return this.sanitaizer.Sanitize(this.Description);
            }
        }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImagePath { get; set; }

        public double Whidth { get; set; }

        public double Heigth { get; set; }

        public double Depht { get; set; }

        public double Lenght { get; set; }

        [Display(Name = "Manufacturer name")]
        public Manufacturer Manufacturer { get; set; }

        [Display(Name = "Category name")]
        public string CategoryName { get; set; }

        public int CategoryId { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Product, ProductDetailsViewModel>()
                 .ForMember(d => d.CategoryName, opt => opt.MapFrom(s => s.Category.Name))
                 .ReverseMap();
        }
    }
}