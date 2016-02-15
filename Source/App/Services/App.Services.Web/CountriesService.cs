namespace App.Services.Web
{
    using System.Linq;

    using Contracts;
    using Data.Common;
    using Data.Models;

    public class CountriesService : ICountriesService
    {
        private IDbRepository<Country> countries;

        public CountriesService(IDbRepository<Country> countries)
        {
            this.countries = countries;
        }

        public IQueryable<Country> GetAll()
        {
            return this.countries.All();
        }
    }
}
