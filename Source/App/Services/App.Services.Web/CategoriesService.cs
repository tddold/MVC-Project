namespace App.Services.Web
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web;

    using App.Data.Common;
    using App.Data.Models;
    using App.Services.Web.Contracts;

    public class CategoriesService : Service<Category>, ICategoriesService
    {
        private IDbRepository<Category> categories;

        public CategoriesService(IDbRepository<Category> categories)
            : base(categories)
        {
            this.categories = categories;
        }

        public void Save()
        {
            this.categories.Save();
        }

        public void SaveImage(HttpPostedFileBase photo, Object instance, string absolutePath, string relativePath)
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
