namespace App.Web.ViewModels.Orders
{
    using AutoMapper;

    using Data.Models;
    using Infrastructure.Mapping;

    public class OrderViewModel : IMapFrom<Order>, IHaveCustomMappings
    {
        public bool Status { get; set; }

        public decimal Total { get; set; }

        public virtual DeliveryAdress DeliveryAdress { get; set; }

        public virtual User UserName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Order, OrderViewModel>()
               .ForMember(d => d.UserName, opt => opt.MapFrom(s => s.User.FirstName + " " + s.User.LastName))
                .ReverseMap();
        }
    }
}