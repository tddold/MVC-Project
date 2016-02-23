namespace App.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Linq;

    using App.Web.Areas.Administration.AdminViewModels;
    using App.Data.Models;
    using App.Services.Web.Contracts;
    using App.Web.Infrastructure.Mapping;
    using App.Web.Controllers;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    public class KendoProductController : BaseController
    {
        private ICategoriesService categoriesService;
        private IProductService productsService;
        private IManufacturerService manufacturerService;

        public KendoProductController(
           ICategoriesService categoriesService,
            IProductService productsService,
            IManufacturerService manufacturerService)
        {
            this.categoriesService = categoriesService;
            this.productsService = productsService;
            this.manufacturerService = manufacturerService;
        }

        public ActionResult Index()
        {
            var categories = this.categoriesService.GetAll().ToList();
            var manufacturers = this.manufacturerService.GetAll().ToList();

            this.ViewBag.CategoryListItem = new List<SelectListItem>();
            this.ViewBag.ManufacturerListItems = new List<SelectListItem>();

            for (int i = 0; i < categories.Count; i++)
            {
                this.ViewBag.CategoryListItem.Add(new SelectListItem() { Text = categories[i].Name, Value = categories[i].Id.ToString() });
            }

            for (int i = 0; i < manufacturers.Count; i++)
            {
                this.ViewBag.ManufacturerListItems.Add(new SelectListItem() { Text = manufacturers[i].Name, Value = manufacturers[i].Id.ToString() });
            }

            return this.View();
        }

        public ActionResult ProductViewModels_Read([DataSourceRequest]DataSourceRequest request)
        {
            DataSourceResult result = this.productsService.GetAll().To<ProductViewModel>().ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductViewModels_Create([DataSourceRequest]DataSourceRequest request, ProductViewModel productViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbProduct = this.Mapper.Map<Product>(productViewModel);

                this.productsService.Add(dbProduct);
                productViewModel.Id = dbProduct.Id;
            }
            else
            {
                return this.Json(this.ModelState.ToDataSourceResult());
            }

            return this.Json(new[] { productViewModel }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductViewModels_Update([DataSourceRequest]DataSourceRequest request, ProductViewModel productViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbProduct = this.productsService.Find(productViewModel.Id);
                dbProduct.Name = productViewModel.Name;
                dbProduct.Description = productViewModel.Description;
                dbProduct.Depht = productViewModel.Depht;
                dbProduct.ManufacturerId = productViewModel.ManufacturerId;
                dbProduct.Price = productViewModel.Price;
                dbProduct.Quantity = productViewModel.Quantity;
                dbProduct.ShortDecription = productViewModel.ShortDecription;
                dbProduct.Weight = productViewModel.Weight;

                this.productsService.Update(dbProduct);
                productViewModel = this.Mapper.Map<ProductViewModel>(dbProduct);
            }

            return this.Json(new[] { productViewModel }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductViewModels_Destroy([DataSourceRequest]DataSourceRequest request, ProductViewModel productViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbProduct = this.productsService.Find(productViewModel.Id);

                this.productsService.Delete(dbProduct);
            }

            return this.Json(new[] { productViewModel }.ToDataSourceResult(request, this.ModelState));
        }
    }
}
