﻿namespace App.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using ViewModels.Products;
    using Services.Web.Contracts;
    using ViewModels.Home;
    using ViewModels.Categories;
    using Data.Models;
    public class HomeController : BaseController
    {
        private IProductService products;
        private IService<Category> categories;

        public HomeController(
            IProductService products,
            IService<Category> categories)
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

            var allProducts = this.products
               .GetAll()
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
                        .ToList(), 30 * 60);

            var homeViewModel = new HomeViewModel
            {
                    TopProducts = topProducts,
                    Categories = cacheCategories,
                    AllProducts =allProducts
            };

            return this.View(homeViewModel);
        }

        public ActionResult _CategoryPartial()
        {
            var topProducts = this.products
                .GetRandomProducts(10)
                .To<ProductDetailsViewModel>()
                .ToList();

            var allProducts = this.products
               .GetAll()
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
                        .ToList(), 30 * 60);

            var homeViewModel = new HomeViewModel
            {
                TopProducts = topProducts,
                Categories = cacheCategories,
                AllProducts = allProducts
            };

            return PartialView(homeViewModel);
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