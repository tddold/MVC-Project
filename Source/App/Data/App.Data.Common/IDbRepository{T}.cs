namespace App.Data.Common
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using Data.Common.Models;

    public interface IDbRepository<T> : IDbRepository<T, int>
        where T : BaseModel<int>
    {
    }

    public interface IDbRepository<T, in TKey>
        where T : BaseModel<TKey>
    {
        IQueryable<T> All();

        IQueryable<T> AllWithDeleted();

        IQueryable<T> Include(Expression<Func<T, object>> expression);

        T GetById(TKey id);

        T GetById(object id);

        void Add(T entity);

        void Delete(T entity);

        void HardDelete(T entity);

        void Save();

        void Update(T entity);
    }
}
