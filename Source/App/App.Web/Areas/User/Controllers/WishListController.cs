namespace App.Web.Areas.User.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;

    using Data.Models;
    using Infrastructure.Mapping;
    using Services.Web.Contracts;
    using UserViewModels;
    using ViewModels.Products;
    using Web.Controllers;

    public class WishListController : BaseController
    {
        private IService<Product> productsService;
        private IProductService products;

        public WishListController(
              IProductService products,
              IService<Product> productsService)
        {
            this.productsService = productsService;
            this.products = products;
        }

        [HttpGet]
        public ActionResult Index(int? id, string userId)
        {
            var currentUser = this.User.Identity.GetUserId();
            var topProducts = new List<ProductDetailsViewModel>();
            var otherProducts = new List<ProductDetailsViewModel>();

            if (currentUser == userId)
            {
                topProducts = this.GetRandomProducts(2);
                otherProducts = this.GetRandomProducts(4);
            }

            var homeViewModel = new WishListHomeViewModel
            {
                TopProducts = topProducts,
                OtherProducts = otherProducts
            };

            return this.View(homeViewModel);
        }

        public ActionResult Create(ProductDetailsViewModel model)
        {
            return this.View();
        }

        private List<ProductDetailsViewModel> GetRandomProducts(int count)
        {
            return this.products
                              .GetRandomProducts(count)
                              .To<ProductDetailsViewModel>()
                              .ToList();
        }
    }
}