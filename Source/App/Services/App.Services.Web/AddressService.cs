namespace App.Services.Web
{
    using System;
    using System.Linq;

    using App.Services.Web.Contracts;
    using Data.Models;
    using Data.Common;

    public class AddressService : IAddressService
    {
        private IDbRepository<Address> adresses;

        public AddressService(IDbRepository<Address> adresses)
        {
            this.adresses = adresses;
        }
        public IQueryable<Address> GetAll()
        {
            return this.adresses.All();
        }

        public Address GetById(object id)
        {
            return this.adresses.GetById(id);
        }

        public IQueryable<Address> GetByPage(int count, int skip)
        {
            throw new NotImplementedException();
        }
    }
}
