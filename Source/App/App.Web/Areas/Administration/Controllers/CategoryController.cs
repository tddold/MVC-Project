namespace App.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using App.Data.Models;
    using App.Services.Web.Contracts;
    using App.Web.ViewModels.Categories;
    using App.Web.Controllers;

    public class CategoryController : BaseController
    {
        private IService<Category> categoriesService;

        public CategoryController(IService<Category> categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        // GET: Administration/Category
        public ActionResult Index()
        {
            var categories = this.categoriesService.GetAll();
            var viewModel = this.Mapper.Map<CategoryViewModel>(categories);

            // var categories = categoriesService.GetAll().ToList();
            return View(viewModel);
        }

        // GET: Administration/Category/Create
        public ActionResult Create()
        {
            return View();
        }
    }
        // POST: Administration/Category/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(CategoryViewModel categoryViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Categories.Add(categoryViewModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(categoryViewModel);
        //}

        // GET: Administration/Category/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CategoryViewModel categoryViewModel = db.CategoryViewModels.Find(id);
        //    if (categoryViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(categoryViewModel);
        //}

        // POST: Administration/Category/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(CategoryViewModel categoryViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(categoryViewModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(categoryViewModel);
        //}

        // GET: Administration/Category/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CategoryViewModel categoryViewModel = db.CategoryViewModels.Find(id);
        //    if (categoryViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(categoryViewModel);
        //}

        //// POST: Administration/Category/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    CategoryViewModel categoryViewModel = db.CategoryViewModels.Find(id);
        //    db.CategoryViewModels.Remove(categoryViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

}
