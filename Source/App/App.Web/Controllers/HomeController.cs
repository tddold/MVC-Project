namespace App.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    using Data.Common;
    using Data.Models;
    using ViewModels.Products;
    using Services.Web.Contracts;
    using Infrastructure.Mapping;
    using ViewModels.Home;
    using ViewModels.Categories;
    public class HomeController : BaseController
    {
        private IProductService products;
        private ICategoriesService categories;
        //private IDbRepository<Category> categories;

        //IDbRepository<Category> categories
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
                .GetRandomProducts(5)
                .To<ProductDetailsViewModel>()
                .ToList();
            var cacheCategories = this.Cache
                .Get("categories", () => this.categories
                        .GetAll().
                        To<CategoryViewModel>()
                        .ToList(),
                    30 * 60);

            //homeViewModel.Categories = this.categories
            //    .GetAll()
            //    .To<CategoryViewModel>()
            //    .ToList();

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