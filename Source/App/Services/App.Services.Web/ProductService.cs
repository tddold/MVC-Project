namespace App.Services.Web
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web;

    using App.Services.Web.Contracts;
    using Data.Common;
    using Data.Models;

    public class ProductService : IProductService
    {
        private IDbRepository<Product> products;

        public ProductService(IDbRepository<Product> products)
        {
            this.products = products;
        }

        public void Add(Product product)
        {
            this.products.Add(product);
            this.products.Save();
        }

        public void Delete(Product product)
        {
            this.products.Delete(product);
            this.products.Save();
        }

        public Product Find(int id)
        {
            return this.products.GetById(id);
        }

        public IQueryable<Product> GetAll()
        {
            return this.products.All();
        }

        public Product GetById(int id)
        {
            return this.products
                .All()
                .FirstOrDefault(p => p.Id == id);
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

        public Product Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
