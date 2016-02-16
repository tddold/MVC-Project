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
    public class Service<T> : IService<T>
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
        }

        public void Delete(T model)
        {
            repository.Delete(model);
        }

        public T Find(int id)
        {
            return repository.GetById(id);
        }

        public IQueryable<T> GetAll()
        {
            return repository.All();
        }

        public T Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
