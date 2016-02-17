namespace App.Services.Web
{
    using App.Services.Web.Contracts;
    using System;
    using System.Linq;
    using App.Data.Models;
    using App.Data.Common;

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
        }

        public void Delete(Category category)
        {
           this.categories.Delete(category);
        }

        public Category Find(int id)
        {
            return this.categories.GetById(id);
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
