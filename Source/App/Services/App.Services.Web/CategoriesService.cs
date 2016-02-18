namespace App.Services.Web
{
    using App.Services.Web.Contracts;
    using System;
    using System.Linq;
    using App.Data.Models;
    using App.Data.Common;
    using System.Collections.Generic;
    using System.Web;
    using System.IO;
    public class CategoriesService : ICategoriesService
    {
        private IDbRepository<Category> categories;

        public CategoriesService(IDbRepository<Category> categories)
        {
            this.categories = categories;
        }

        public void Add(Category category)
        {
            this.categories.Add(category);
            this.categories.Save();
        }

        public void Delete(Category category)
        {
            this.categories.Delete(category);
            this.categories.Save();
        }

        public Category Find(int id)
        {
            return this.categories.GetById(id);
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All();
        }

        public void SaveImage(HttpPostedFileBase photo, Object instance,string absolutePath, string relativePath)
        {
            if (!(instance is Category))
            {
                throw new ArgumentException("Categories service accepts only categories");
            }

            var category = (Category)instance;
            var fileName = Path.GetFileName(photo.FileName);
            var filePath = Path.Combine(absolutePath, fileName);
            photo.SaveAs(filePath);

            category.ImagePath = relativePath + fileName;
            this.categories.Save();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }

        //private void UploadPicture(Category category, HttpPostedFileBase photo)
        //{
        //    if (photo != null && photo.ContentLength > 0)
        //    {
        //        var fileName = Path.GetFileName(photo.FileName);
        //        var abstractPath = Constants.ImagesFolder + "/" + fileName;
        //        var filePath = Path.Combine(Server.MapPath(Constants.ImagesFolder), fileName);
        //        photo.SaveAs(filePath);

        //        product.ImagePath = abstractPath;
        //    }
        //}
    }
}
