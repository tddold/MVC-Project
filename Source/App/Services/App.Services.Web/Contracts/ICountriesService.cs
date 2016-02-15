namespace App.Services.Web.Contracts
{
    using System.Linq;

    using Data.Models;

    public interface ICountriesService
    {
        IQueryable<Country> GetAll();
    }
}
