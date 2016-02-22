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
using App.Services.Web.Contracts;
using App.Web.Infrastructure.Mapping;
using App.Data.Models;

namespace App.Web.Areas.Administration.Controllers
{
    public class KendoCategoriesController : BaseController
    {
        private ICategoriesService categoriesService;
        private IProductService productsService;
        private IManufacturerService manufacturerService;

        public KendoCategoriesController(
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
            var categories = this.categoriesService.GetAll();
            var manufacturers = this.manufacturerService.GetAll();
            this.ViewBag.ManufacturerListItems = new List<SelectListItem>();

            foreach (var item in manufacturers)
            {
                this.ViewBag.ManufacturerListItems.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });

            }         

            return this.View();
        }

        public ActionResult CategoryViewModels_Read([DataSourceRequest]DataSourceRequest request)
        {
            DataSourceResult result = this.categoriesService.GetAll().To<CategoryViewModel>().ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CategoryViewModels_Create([DataSourceRequest]DataSourceRequest request, CategoryViewModel categoryViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbCategory = this.Mapper.Map<Category>(categoryViewModel);

                this.categoriesService.Add(dbCategory);
                categoryViewModel.Id = dbCategory.Id;
            }

            return this.Json(new[] { categoryViewModel }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CategoryViewModels_Update([DataSourceRequest]DataSourceRequest request, CategoryViewModel categoryViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbCategory = this.categoriesService.Find(categoryViewModel.Id);
                dbCategory.Name = categoryViewModel.Name;
                dbCategory.Description = categoryViewModel.Description; 

                this.categoriesService.Update(dbCategory);
                categoryViewModel = this.Mapper.Map<CategoryViewModel>(dbCategory);
            }

            return this.Json(new[] { categoryViewModel }.ToDataSourceResult(request, this.ModelState));
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
