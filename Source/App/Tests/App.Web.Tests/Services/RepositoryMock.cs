namespace App.Web.Tests.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Data.Common;
    using Data.Common.Models;

    public class RepositoryMock<T, TKey> : IDbRepository<T, int>
        where T : BaseModel<int>
    {
        private List<T> data;

        public RepositoryMock()
        {
            this.data = new List<T>();
        }

        public void Add(T entity)
        {
            this.data.Add(entity);
            this.Save();
        }

        public IQueryable<T> All()
        {
            return this.data.AsQueryable();
        }

        public IQueryable<T> AllWithDeleted()
        {
            return this.data.AsQueryable();
        }

        public void Delete(T entity)
        {
            if (this.data.Count > 0)
            {
                this.data.RemoveAt(0);
            }
        }

        public virtual void Delete(TKey id)
        {
            if (this.data.Count > 0)
            {
                this.data.RemoveAt(0);
            }
        }

        public T GetById(object id)
        {
            return this.data.First();
        }

        public T GetById(int id)
        {
            return this.data.FirstOrDefault(x => x.Id == id);
        }

        public T GetById(TKey id)
        {
            return this.data.First();
        }

        public void HardDelete(T entity)
        {
            if (this.data.Count > 0)
            {
                this.data.RemoveAt(0);
            }
        }

        public IQueryable<T> Include(Expression<Func<T, object>> expression)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            return;
        }

        public void Update(T entity)
        {
            return;
        }
    }
}
