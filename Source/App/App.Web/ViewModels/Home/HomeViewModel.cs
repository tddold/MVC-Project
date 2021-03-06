﻿namespace App.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using Products;
    using Categories;
    using Areas.User.UserViewModels;
    public class HomeViewModel
    {
        public ICollection<ProductDetailsViewModel> TopProducts { get; set; }

        public ICollection<ProductDetailsViewModel> AllProducts { get; set; }

        public ICollection<CategoryViewModel> Categories { get; set; }

        public ICollection<WishListInputViewModel> WishLists { get; set; }
    }
}