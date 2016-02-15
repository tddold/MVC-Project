namespace App.Services.Web.Contracts
{
    using System.Linq;

    using Data.Models;

    public interface IUserService : IService
    {
        IQueryable<User> GetAll();

        User GetById(string id);
    }
}
