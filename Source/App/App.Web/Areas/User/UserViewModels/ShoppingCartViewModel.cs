namespace App.Web.Areas.User.UserViewModels
{
    using App.Data.Models;
    using Infrastructure.Mapping;
    using ViewModels.Products;

    public class ShoppingCartViewModel : IMapFrom<ShoppingCart>, IMapTo<ShoppingCart>
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ProductId { get; set; }

        public ProductDetailsViewModel Product { get; set; }
    }
}