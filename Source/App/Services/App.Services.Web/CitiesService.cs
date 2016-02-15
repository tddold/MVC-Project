namespace App.Services.Web
{
    using System.Linq;

    using Contracts;
    using Data.Common;
    using Data.Models;

    public class CitiesService : ICitiesService
    {
        private IDbRepository<City> cities;

        public CitiesService(IDbRepository<City> cities)
        {
            this.cities = cities;
        }

        public IQueryable<City> GetAll()
        {
            return this.cities.All();
        }
    }
}
