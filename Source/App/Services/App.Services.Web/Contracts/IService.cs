using App.Data.Models;
using System.Linq;

namespace App.Services.Web.Contracts
{
    public interface IService<T>
    {
        IQueryable<T> GetAll();

        T Find(int id);

        void Add(T model);

        void Delete(T model);

        T Update(T model);
    }
}
