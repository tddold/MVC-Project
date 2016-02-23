namespace App.Web.Areas.User.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Data.Common;
    using Data.Models;

    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;

    using Services.Web.Contracts;
    using UserViewModels;
    using ViewModels.Products;
    using Web.Controllers;

    [Authorize]
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
        public ActionResult Index()
        {
            var currentUserId = this.User.Identity.GetUserId();

            var wishLists = this.wishLists.All().Where(w => w.UserId == currentUserId).To<WishListViewModel>().ToList();

            return this.View(wishLists);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WishListInputViewModel model)
        {
            var userId = this.User.Identity.GetUserId();
            var product = this.productsService.Find(model.ProductId);
            if (this.wishLists.All().Any(w => w.ProductId == product.Id && w.UserId == userId))
            {
                return this.RedirectToAction("Index", "Home", new { area = string.Empty });
            }

            this.wishLists.Add(new Wishlist()
            {
                UserId = userId,
                Product = product,
                ProductId = product.Id
            });

            this.wishLists.Save();

            return this.RedirectToAction("Index", "Home", new { area = string.Empty });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var wishList = this.wishLists.GetById(id);
            if (wishList != null)
            {
                this.wishLists.Delete(wishList);
                this.wishLists.Save();
            }

            return this.RedirectToAction("Index", "WishList");
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