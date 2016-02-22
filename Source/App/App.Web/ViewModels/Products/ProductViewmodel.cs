namespace App.Web.ViewModels.Products
{
    using System.Collections.Generic;

    public class ProductViewModel
    {
        public ICollection<ProductDetailsViewModel> Products { get; set; }
    }
}