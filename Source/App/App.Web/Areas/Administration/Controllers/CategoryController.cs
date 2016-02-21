﻿namespace App.Web.Areas.Administration.Controllers
{
    using System.Linq;

    using System.Net;
    using System.Web;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using App.Data.Models;
    using App.Services.Web.Contracts;
    using App.Web.ViewModels.Categories;
    using ViewModels.Home;

    public class CategoryController : AdministrationController
    {
        private IService<Category> categoriesService;
        private ICategoriesService categories;

        public CategoryController(
            IService<Category> categoriesService,
            ICategoriesService categories)
        {
            this.categoriesService = categoriesService;
            this.categories = categories;
        }

        // GET: Administration/Category
        public ActionResult Index()
        {
            var cacheCategories = this.categoriesService
                      .GetAll()
                      .To<CategoryViewModel>()
                      .ToList();

            var viewModel = new HomeViewModel
            {
                Categories = cacheCategories
            };

            // var categories = this.categoriesService.GetAll();
            // var viewModel = this.Mapper.Map<CategoryViewModel>(categories);

            // var categories = categoriesService.GetAll().ToList();
            return this.View(viewModel);
        }

        // GET: Administration/Category/Create
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryViewModel categoryViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var categoryDb = this.Mapper.Map<Category>(categoryViewModel);
                this.categoriesService.Add(categoryDb);

                HttpPostedFileBase photo = this.Request.Files["photo"];
                if (photo != null && photo.ContentLength > 0 && this.categoriesService is IImagesService)
                {
                    ((IImagesService)this.categoriesService).SaveImage(photo, categoryDb, this.Server.MapPath("/Img"), "/Img/");
                }

                return this.RedirectToAction("Index");
            }

            return this.View(categoryViewModel);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CategoryViewModel categoryViewModel = this.Mapper.Map<CategoryViewModel>(this.categoriesService.Find((int)id));

            if (categoryViewModel == null)
            {
                return this.HttpNotFound();
            }

            return this.View(categoryViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = this.categoriesService.Find(id);
            this.categoriesService.Delete(category);

            return this.RedirectToAction("Index");
        }
    }

    // GET: Administration/Category/Edit/5
    // [HttpPost]
    //    public ActionResult Edit(int? id)
    // {
    //    if (id == null)
    //    {
    //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //    }

    // var editCategories

    // CategoryViewModel categoryViewModel = this.CategoryViewModels.Find(id);
    //    if (categoryViewModel == null)
    //    {
    //        return HttpNotFound();
    //    }
    //    return View(categoryViewModel);
    // }

    // POST: Administration/Category/Edit/5
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public ActionResult Edit(CategoryViewModel categoryViewModel)
    // {
    //    if (ModelState.IsValid)
    //    {
    //        db.Entry(categoryViewModel).State = EntityState.Modified;
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }
    //    return View(categoryViewModel);
    // }

    // GET: Administration/Category/Delete/5

    //// POST: Administration/Category/Delete/5

}
