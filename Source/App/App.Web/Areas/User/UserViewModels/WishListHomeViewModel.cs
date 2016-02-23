namespace App.Web.Areas.User.UserViewModels
{
    using App.Web.ViewModels.Products;
    using System.Collections.Generic;

    public class WishListHomeViewModel
    {
        public ICollection<ProductDetailsViewModel> TopProducts { get; set; }

        public ICollection<ProductDetailsViewModel> OtherProducts { get; set; }

        public ICollection<WishListInputViewModel> WishLists { get; set; }
    }
}