namespace App.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using Services.Web.Contracts;
    using ViewModels.Categories;
    using ViewModels.Products;
    using ViewModels.Home;
    public class CategoriesController : BaseController
    {
        private ICategoriesService categories;
        private IProductService products;

        public CategoriesController(
            ICategoriesService categories,
            IProductService products)
        {
            this.categories = categories;
            this.products = products;
        }

        public ActionResult Index(int id, string url, int page = 1)
        {
            var categoryViewModel = this.categories
                .GetAll()
                .Where(x => x.Id == id)
                .To<CategoryViewModel>()
                .ToList();

            var allProducts = this.products
                .GetAllProducts()
                .Where(x => x.CategoryId == id)
                .To<ProductDetailsViewModel>()
                .ToList();

            if (categoryViewModel == null)
            {
                return this.HttpNotFound("No such category");
            }

            var viewModel = new ProductInCategoryViewModel
            {
                Products = allProducts
            };

            return this.View(viewModel);
        }
    }
}