namespace App.Web.Areas.Administration.AdminViewModels
{
    using System.Collections.Generic;

    public class ProductInputViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPage { get; set; }

        public ICollection<ProductViewModel> Product { get; set; }
    }
}