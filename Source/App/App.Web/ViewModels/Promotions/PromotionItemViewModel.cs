namespace App.Web.ViewModels.Promotions
{
    using AutoMapper;

    using App.Data.Models;
    using Infrastructure.Mapping;

    public class PromotionItemViewModel : IMapFrom<PromotionItem>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string PromotionName { get; set; }

        public string ProductName { get; set; }

        public decimal Discount { get; set; }

        public int Percent { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<PromotionItem, PromotionItemViewModel>()
              .ForMember(d => d.PromotionName, opt => opt.MapFrom(s => s.Promotion.Name))
               .ForMember(d => d.ProductName, opt => opt.MapFrom(s => s.Product.Name))
               .ReverseMap();
        }
    }
}