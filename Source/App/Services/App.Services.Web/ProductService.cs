namespace App.Services.Web
{
    using System.Linq;

    using App.Services.Web.Contracts;
    using Data.Models;
    using Data.Common;
    using System;
    public class ProductService : IProductService
    {
        private IDbRepository<Product> products;

        public ProductService(IDbRepository<Product> products)
        {
            this.products = products;
        }
        public IQueryable<Product> GetAllProducts()
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
    }
}
