namespace App.Web.Areas.Administration.Controllers
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using App.Data;
    using App.Data.Models;
    using App.Services.Web.Contracts;
    using App.Web.Infrastructure.Mapping;
    using App.Web.Areas.Administration.AdminViewModels;
    using Web.Controllers;

    public class KendoProductsController : BaseController
    {
        private AppDbContext db = new AppDbContext();
        private IService<Product> productsService;
        private IProductService products;

        public KendoProductsController(
           IService<Product> productsService,
            IProductService products)
        {
            this.productsService = productsService;
            this.products = products;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Products_Read([DataSourceRequest]DataSourceRequest request)
        {
            DataSourceResult result = this.products.GetAll()
                .To<ProductViewModel>()
                .ToDataSourceResult(request);

            return this.Json(result, JsonRequestBehavior.AllowGet);

            // IQueryable<Product> products = db.Products;
            // DataSourceResult result = products.ToDataSourceResult(request, product => new {
            //    Id = product.Id,
            //    Name = product.Name,
            //    Description = product.Description,
            //    ShortDecription = product.ShortDecription,
            //    Price = product.Price,
            //    Quantity = product.Quantity,
            //    ImagePath = product.ImagePath,
            //    Whidth = product.Whidth,
            //    Heigth = product.Heigth,
            //    Depht = product.Depht,
            //    Weight = product.Weight,
            //    Manufacturer = product.Manufacturer,
            //    CreatedOn = product.CreatedOn,
            //    ModifiedOn = product.ModifiedOn,
            //    IsDeleted = product.IsDeleted,
            //    DeletedOn = product.DeletedOn
            // });

            // return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Products_Create([DataSourceRequest]DataSourceRequest request, ProductViewModel product)
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            var newId = 0;
            if (this.ModelState.IsValid)
            {
                var entity = new Product
                {
                    Name = product.Name,
                    Description = product.Description,
                    ShortDecription = product.ShortDecription,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    ImagePath = product.ImagePath,
                    Whidth = product.Whidth,
                    Heigth = product.Heigth,
                    Depht = product.Depht,
                    Weight = product.Weight,
                    ManufacturerId = product.ManufacturerId,
                    CategoryId = product.Id
                };

                this.products.Add(entity);

                // this.products.Save();
                newId = entity.Id;
            }

            var productToDisplay = this.products
               .GetAll()
               .To<ProductViewModel>()
               .FirstOrDefault(x => x.Id == newId);

            return this.Json(new[] { productToDisplay }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Products_Update([DataSourceRequest]DataSourceRequest request, Product product)
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            if (this.ModelState.IsValid)
            {
                var entity = this.productsService.Find(product.Id);

                entity.Id = product.Id;
                entity.Name = product.Name;
                entity.Description = product.Description;
                entity.ShortDecription = product.ShortDecription;
                entity.Price = product.Price;
                entity.Quantity = product.Quantity;
                entity.ImagePath = product.ImagePath;
                entity.Whidth = product.Whidth;
                entity.Heigth = product.Heigth;
                entity.Depht = product.Depht;
                entity.Weight = product.Weight;
                entity.Manufacturer = product.Manufacturer;
                entity.CreatedOn = product.CreatedOn;
                entity.ModifiedOn = product.ModifiedOn;
                entity.IsDeleted = product.IsDeleted;
                entity.DeletedOn = product.DeletedOn;

                // this.productsService.Save();
            }

            var productToDisplay = this.products
                .GetAll()
                .To<ProductViewModel>()
                .FirstOrDefault(p => p.Id == product.Id);

            return this.Json(new[] { productToDisplay }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Products_Destroy([DataSourceRequest]DataSourceRequest request, Product product)
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);

            // if (ModelState.IsValid)
            // {
            //    var entity = new Product
            //    {
            //        Id = product.Id,
            //        Name = product.Name,
            //        Description = product.Description,
            //        ShortDecription = product.ShortDecription,
            //        Price = product.Price,
            //        Quantity = product.Quantity,
            //        ImagePath = product.ImagePath,
            //        Whidth = product.Whidth,
            //        Heigth = product.Heigth,
            //        Depht = product.Depht,
            //        Weight = product.Weight,
            //        Manufacturer = product.Manufacturer,
            //        CreatedOn = product.CreatedOn,
            //        ModifiedOn = product.ModifiedOn,
            //        IsDeleted = product.IsDeleted,
            //        DeletedOn = product.DeletedOn
            //    };

            // db.Products.Attach(entity);
            //    db.Products.Remove(entity);
            //    db.SaveChanges();
            // }
            this.products.Delete(product);

            // this.products.Save();
            return this.Json(new[] { product }.ToDataSourceResult(request, this.ModelState));
        }

        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return this.File(fileContents, contentType, fileName);
        }

        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return this.File(fileContents, contentType, fileName);
        }

        // protected override void Dispose(bool disposing)
        // {
        //    this.db.Dispose();
        //    base.Dispose(disposing);
        // }
    }
}
