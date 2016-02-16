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
    public class HomeController : BaseController
    {
        private IProductService products;
        //private IDbRepository<Category> categories;

        //IDbRepository<Category> categories
        public HomeController(
            IProductService products)
        {
            this.products = products;
            //this.categories = categories;
        }

        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel();

            homeViewModel.TopProducts = this.products
                .GetRandomProducts(5)
                .To<ProductDetailsViewModel>()
                .ToList();

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