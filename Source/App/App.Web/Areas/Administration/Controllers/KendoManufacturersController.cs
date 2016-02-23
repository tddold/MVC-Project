namespace App.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using App.Data.Models;
    using App.Services.Web.Contracts;
    using App.Web.Infrastructure.Mapping;
    using App.Web.Areas.Administration.AdminViewModels;
    using App.Web.Controllers;

    public class KendoManufacturersController : BaseController
    {
        private ICategoriesService categoriesService;
        private IProductService productsService;
        private IManufacturerService manufacturerService;

        public KendoManufacturersController(
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

        public ActionResult ManufacturerSelectViewModel_Read([DataSourceRequest]DataSourceRequest request)
        {
            DataSourceResult result = this.manufacturerService.GetAll().To<ManufacturerSelectViewModel>().ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ManufacturerSelectViewModel_Create([DataSourceRequest]DataSourceRequest request, ManufacturerSelectViewModel manufacturerViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbManufacturer = this.Mapper.Map<Manufacturer>(manufacturerViewModel);

                this.manufacturerService.Add(dbManufacturer);
                manufacturerViewModel.Id = dbManufacturer.Id;
            }

            return this.Json(new[] { manufacturerViewModel }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ManufacturerSelectViewModel_Update([DataSourceRequest]DataSourceRequest request, ManufacturerSelectViewModel manufacturerViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbManufacturer = this.manufacturerService.Find(manufacturerViewModel.Id);
                dbManufacturer.Name = manufacturerViewModel.Name;

                this.manufacturerService.Update(dbManufacturer);
                manufacturerViewModel = this.Mapper.Map<ManufacturerSelectViewModel>(dbManufacturer);
            }

            return this.Json(new[] { manufacturerViewModel }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ManufacturerSelectViewModel_Destroy([DataSourceRequest]DataSourceRequest request, ManufacturerSelectViewModel manufacturerViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var dbManufacturer = this.manufacturerService.Find(manufacturerViewModel.Id);

                this.manufacturerService.Delete(dbManufacturer);
            }

            return this.Json(new[] { manufacturerViewModel }.ToDataSourceResult(request, this.ModelState));
        }
    }
}