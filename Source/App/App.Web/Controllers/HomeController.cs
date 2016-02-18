namespace App.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using ViewModels.Products;
    using Services.Web.Contracts;
    using ViewModels.Home;
    using ViewModels.Categories;

    public class HomeController : BaseController
    {
        private IProductService products;
        private ICategoriesService categories;

        public HomeController(
            IProductService products,
            ICategoriesService categories)
        {
            this.products = products;
            this.categories = categories;
        }

        public ActionResult Index()
        {
            var topProducts = this.products
                .GetRandomProducts(10)
                .To<ProductDetailsViewModel>()
                .ToList();

            // no Cache
            // var cacheCategories = this.categories
            //          .GetAll().
            //          To<CategoryViewModel>()
            //          .ToList();

            var cacheCategories = this.Cache
                .Get("categories", () => this.categories
                        .GetAll().
                        To<CategoryViewModel>()
                        .ToList(),
                    30 * 60);

            var homeViewModel = new HomeViewModel
            {
                    TopProducts = topProducts,
                    Categories = cacheCategories
            };

            return this.View(homeViewModel);
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}