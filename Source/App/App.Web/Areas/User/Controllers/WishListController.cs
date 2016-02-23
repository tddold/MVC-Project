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
    using Data.Common;
    public class WishListController : BaseController
    {
        private IService<Product> productsService;
        private IProductService products;
        private IDbRepository<Wishlist> wishLists;

        public WishListController(
              IProductService products,
              IDbRepository<Wishlist> wishLists,
              IService<Product> productsService)
        {
            this.productsService = productsService;
            this.products = products;
            this.wishLists = wishLists;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WishListInputViewModel model)
        {
            var userId = this.User.Identity.GetUserId();
            //var wishList = this.wishLists
            //    .All()
            //    .FirstOrDefault(x => x.UserId == userId && x.ProductId == productId);

            //wishList = new Wishlist
            //{
            //    UserId = userId,
            //    Id = wishListId,
            //    ProductId = productId
            //};

            //this.wishLists.Add(wishList);
            //this.wishLists.Save();

            //var wishListCount = this.wishLists
            //    .All()
            //    .Where(x => x.Id == wishListId)
            //    .Count();

            //return this.Json(new { Count = wishListCount });

            return RedirectToAction("/");
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