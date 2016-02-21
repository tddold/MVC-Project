namespace App.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using Products;
    using Categories;
    public class HomeViewModel
    {
        public ICollection<ProductDetailsViewModel> TopProducts { get; set; }

        public ICollection<CategoryViewModel> Categories { get; set; }
    }
}