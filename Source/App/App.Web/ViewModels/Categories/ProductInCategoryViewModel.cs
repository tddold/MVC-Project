namespace App.Web.ViewModels.Categories
{
    using App.Web.ViewModels.Products;
    using System.Collections.Generic;

    public class ProductInCategoryViewModel
    {
        public ICollection<ProductDetailsViewModel> Products { get; set; }
    }
}