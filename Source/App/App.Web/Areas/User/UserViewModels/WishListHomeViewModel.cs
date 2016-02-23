namespace App.Web.Areas.User.UserViewModels
{
    using App.Web.ViewModels.Products;
    using System.Collections.Generic;

    public class WishListHomeViewModel
    {
        public ICollection<WishListViewModel> WishLists { get; set; }
    }
}