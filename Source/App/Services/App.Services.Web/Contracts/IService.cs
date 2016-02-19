namespace App.Services.Web.Contracts
{
    using System.Linq;

    public interface IService<T>
    {
        IQueryable<T> GetAll();

        T Find(int id);

        void Add(T model);

        void Delete(T model);

        T Update(T model);

        //void Save();
    }
}
