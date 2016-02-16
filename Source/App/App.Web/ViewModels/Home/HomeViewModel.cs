namespace App.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using Products;

    public class HomeViewModel
    {
        public ICollection<ProductDetailsViewModel> TopProducts { get; set; }
    }
}