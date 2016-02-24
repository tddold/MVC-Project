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
    public class ShoppingCartController : BaseController
    {
        private IService<Product> productsService;
        private IProductService products;
        private IDbRepository<ShoppingCart> shoppingCarts;

        public ShoppingCartController(
              IProductService products,
              IDbRepository<ShoppingCart> shoppingCarts,
              IService<Product> productsService)
        {
            this.productsService = productsService;
            this.products = products;
            this.shoppingCarts = shoppingCarts;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var currentUserId = this.User.Identity.GetUserId();

            var viewShoppingCarts = this.shoppingCarts.All().Where(w => w.UserId == currentUserId).To<ShoppingCartViewModel>().ToList();

            return this.View(viewShoppingCarts);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShoppingCartInputViewModel model)
        {
            var userId = this.User.Identity.GetUserId();
            var product = this.productsService.Find(model.ProductId);
            if (this.shoppingCarts.All().Any(w => w.ProductId == product.Id && w.UserId == userId))
            {
                return this.RedirectToAction("Index", "Home", new { area = string.Empty });
            }

            this.shoppingCarts.Add(new ShoppingCart()
            {
                UserId = userId,
                Product = product,
                ProductId = product.Id
            });

            this.shoppingCarts.Save();

            return this.RedirectToAction("Index", "Home", new { area = string.Empty });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var shoppingCart = this.shoppingCarts.GetById(id);
            if (shoppingCart != null)
            {
                this.shoppingCarts.Delete(shoppingCart);
                this.shoppingCarts.Save();
            }

            return this.RedirectToAction("Index", "ShoppingCart");
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