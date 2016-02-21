using App.Data.Common;
using App.Data.Common.Models;
using App.Services.Web.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Web
{
    public abstract class Service<T> : IService<T>
        where T : BaseModel<int>
    {
        private IDbRepository<T> repository;

        public Service(IDbRepository<T> repositories)
        {
            this.repository = repositories;
        }
        public void Add(T model)
        {
            repository.Add(model);
            repository.Save();
        }

        public void Delete(T model)
        {
            repository.Delete(model);
            repository.Save();
        }

        public T Find(int id)
        {
            return repository.GetById(id);
        }

        public IQueryable<T> GetAll()
        {
            return repository.All();
        }

        public void Update(T model)
        {
            this.repository.Update(model);
        }
    }
}
