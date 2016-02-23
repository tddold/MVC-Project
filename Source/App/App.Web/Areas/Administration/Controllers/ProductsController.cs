namespace App.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using App.Data.Models;
    using App.Services.Web.Contracts;
    using App.Web.Areas.Administration.AdminViewModels;
    using Infrastructure.Mapping;
    using System.Linq;
    using System;

    public class ProductsController : AdministrationController
    {
        private const int ItemsPerPage = 5;
        private IService<Product> productsService;
        private IProductService products;

        public ProductsController(
           IService<Product> productsService,
            IProductService products)
        {
            this.productsService = productsService;
            this.products = products;
        }

        // GET: Administration/Products
        public ActionResult Index(int id = 1)
        {
            ProductInputViewModel viewModels;
            if (this.HttpContext.Cache["Product_page_" + id] != null)
            {
                viewModels = (ProductInputViewModel)this.HttpContext.Cache["Product_page_" + id];
            }
            else
            {
                var page = id;
                var allItemsCount = this.products.GetAll().Count();
                var totalPages = (int)Math.Ceiling(allItemsCount / (decimal)ItemsPerPage);
                var itemsToSkip = (page - 1) * ItemsPerPage;

                var productViewModel = this.products
                       .GetAll()
                       .OrderBy(x => x.CreatedOn)
                       .ThenBy(x => x.Id)
                       .Skip(itemsToSkip)
                       .Take(ItemsPerPage)
                       .To<ProductViewModel>()
                       .ToList();

                viewModels = new ProductInputViewModel
                {
                    CurrentPage = page,
                    TotalPage = totalPages,
                    Product = productViewModel
                };

                this.HttpContext.Cache["Product_page_" + id] = viewModels;
            }

            return this.View(viewModels);
        }
    }
}
