namespace App.Services.Web
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web;

    using App.Services.Web.Contracts;
    using Data.Common;
    using Data.Models;

    public class ProductService : Service<Product>, IProductService
    {
        private IDbRepository<Product> products;

        public ProductService(IDbRepository<Product> products)
            :base(products)
        {
            this.products = products;
        }

        public IQueryable<Product> GetRandomProducts(int count)
        {
            return this.products
                .All()
                .OrderBy(x => Guid.NewGuid())
                .Take(count);
        }

        public void SaveImage(HttpPostedFileBase photo, object instance, string absolutePath, string relativePath)
        {
            if (!(instance is Product))
            {
                throw new ArgumentException("Categories service accepts only categories");
            }

            var product = (Product)instance;
            var fileName = Path.GetFileName(photo.FileName);
            var filePath = Path.Combine(absolutePath, fileName);
            photo.SaveAs(filePath);

            product.ImagePath = relativePath + fileName;
            this.products.Save();
        }
    }
}
