namespace App.Services.Web
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web;

    using App.Services.Web.Contracts;
    using Data.Common;
    using Data.Models;

    public class ManufacturerService : Service<Manufacturer>, IManufacturerService
    {
        private IDbRepository<Manufacturer> manufacturers;

        public ManufacturerService(IDbRepository<Manufacturer> manufacturers)
            :base(manufacturers)
        {
            this.manufacturers = manufacturers;
        }
    }
}
