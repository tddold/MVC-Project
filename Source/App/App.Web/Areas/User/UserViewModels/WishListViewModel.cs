namespace App.Web.Areas.User.UserViewModels
{
    using App.Data.Models;
    using Infrastructure.Mapping;
    using System.Collections.Generic;
    using ViewModels.Products;
    public class WishListViewModel : IMapFrom<Wishlist>, IMapTo<Wishlist>
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ProductId { get; set; }

        public ProductDetailsViewModel Product { get; set; }
    }
}