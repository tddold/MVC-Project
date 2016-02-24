namespace App.Web.Areas.User.UserViewModels
{
    using App.Data.Models;
    using App.Web.Infrastructure.Mapping;

    public class ShoppingCartInputViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ProductId { get; set; }
    }
}