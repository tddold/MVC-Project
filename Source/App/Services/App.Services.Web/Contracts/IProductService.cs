namespace App.Services.Web.Contracts
{
    using System.Linq;

    using App.Data.Models;

    public interface IProductService : IService
    {
        IQueryable<Product> GetAllProducts();

        Product GetById(int id);
    }
}
