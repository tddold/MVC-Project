namespace App.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Services.Web.Contracts;

    using Infrastructure.Mapping;

    using ViewModels.Categories;
    using ViewModels.Products;

    public class ProductsDetailsController : BaseController
    {
        private ICategoriesService categories;
        private IProductService products;

        public ProductsDetailsController(
            ICategoriesService categories,
            IProductService products)
        {
            this.categories = categories;
            this.products = products;
        }

        public ActionResult Index(int id, string url, int page = 1)
        {

            var productViewModel = this.products
               .GetAll()
               .Where(x => x.Id == id)
               .To<ProductDetailsViewModel>()
               .FirstOrDefault();

            //var allProducts = this.products
            //    .GetAll()
            //    .Where(x => x.CategoryId == id)
            //    .To<ProductDetailsViewModel>()
            //    .ToList();

            if (productViewModel == null)
            {
                return this.HttpNotFound("No such category");
            }

            //var viewModel = new ProductViewModel
            //{
            //    Products = productViewModel
            //};

            return this.View(productViewModel);
        }
    }
}