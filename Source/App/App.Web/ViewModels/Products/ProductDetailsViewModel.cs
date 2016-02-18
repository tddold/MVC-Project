namespace App.Web.ViewModels.Products
{
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;

    using Data.Models;
    using Infrastructure.Mapping;

    public class ProductDetailsViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [MaxLength(40)]
        public string ShortDecription { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImagePath { get; set; }

        public double Whidth { get; set; }

        public double Heigth { get; set; }

        public double Depht { get; set; }

        public double Lenght { get; set; }

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