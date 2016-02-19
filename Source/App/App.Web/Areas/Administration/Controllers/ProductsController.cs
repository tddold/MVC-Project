namespace App.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using App.Data.Models;
    using App.Web.Controllers;
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

        //// GET: Administration/Products/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        //// GET: Administration/Products/Create
        //public ActionResult Create()
        //{
        //    ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
        //    return View();
        //}

        //// POST: Administration/Products/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Name,Description,ShortDecription,Price,Quantity,ImagePath,Whidth,Heigth,Depht,Weight,Manufacturer,CategoryId,CreatedOn,ModifiedOn,IsDeleted,DeletedOn")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Products.Add(product);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
        //    return View(product);
        //}

        //// GET: Administration/Products/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
        //    return View(product);
        //}

        //// POST: Administration/Products/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Name,Description,ShortDecription,Price,Quantity,ImagePath,Whidth,Heigth,Depht,Weight,Manufacturer,CategoryId,CreatedOn,ModifiedOn,IsDeleted,DeletedOn")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(product).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
        //    return View(product);
        //}

        //// GET: Administration/Products/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        //// POST: Administration/Products/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Product product = db.Products.Find(id);
        //    db.Products.Remove(product);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        this..Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
