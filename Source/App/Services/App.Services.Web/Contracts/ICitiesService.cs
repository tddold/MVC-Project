namespace App.Services.Web.Contracts
{
    using System.Linq;

    using Data.Models;

    public interface ICitiesService
    {
        IQueryable<City> GetAll();
    }
}
