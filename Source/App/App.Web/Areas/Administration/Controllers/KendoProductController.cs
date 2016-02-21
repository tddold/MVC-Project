using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using App.Web.Areas.Administration.AdminViewModels;
using App.Web.Controllers;
using App.Data.Models;
using App.Services.Web.Contracts;
using App.Web.Infrastructure.Mapping;
using AutoMapper.Mappers;

namespace App.Web.Areas.Administration.Controllers
{
    public class KendoProductController : BaseController
    {
        private ICategoriesService categoriesService;
        private IProductService productsService;

        public KendoProductController(
           ICategoriesService categoriesService,
            IProductService productsService)
        {
            this.categoriesService = categoriesService;
            this.productsService = productsService;
        }
        public ActionResult Index()
        {
            var categories = this.categoriesService.GetAll();

            ViewBag.ListItem = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "pesho", Value = "1" },
                new SelectListItem() {Text = "gosho",Value = "2" },
                new SelectListItem() {Text = "dasda",Value = "3" },
                new SelectListItem() {Text = "test",Value = "4" },
            };

            return View();
        }

        public ActionResult ProductViewModels_Read([DataSourceRequest]DataSourceRequest request)
        {
            DataSourceResult result = this.productsService.GetAll().To<ProductViewModel>().ToDataSourceResult(request);

            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductViewModels_Create([DataSourceRequest]DataSourceRequest request, ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var dbProduct = Mapper.Map<Product>(productViewModel);

                this.productsService.Add(dbProduct);
                productViewModel.Id = dbProduct.Id;
            }

            return Json(new[] { productViewModel }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductViewModels_Update([DataSourceRequest]DataSourceRequest request, ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var dbProduct = this.productsService.Find(productViewModel.Id);
                dbProduct.Name = productViewModel.Name;
                dbProduct.Description = productViewModel.Description;
                dbProduct.Depht = productViewModel.Depht;
                dbProduct.Manufacturer = productViewModel.Manufacturer;
                dbProduct.Price = productViewModel.Price;
                dbProduct.Quantity = productViewModel.Quantity;
                dbProduct.ShortDecription = productViewModel.ShortDecription;
                dbProduct.Weight = productViewModel.Weight;

                this.productsService.Update(dbProduct);
                productViewModel = Mapper.Map<ProductViewModel>(dbProduct);
            }

            return Json(new[] { productViewModel }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductViewModels_Destroy([DataSourceRequest]DataSourceRequest request, ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var dbProduct = this.productsService.Find(productViewModel.Id);

                this.productsService.Delete(dbProduct);
            }

            return Json(new[] { productViewModel }.ToDataSourceResult(request, ModelState));
        }
    }
}
