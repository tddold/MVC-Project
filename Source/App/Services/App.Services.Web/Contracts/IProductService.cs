namespace App.Services.Web.Contracts
{
    using System.Linq;

    using App.Data.Models;

    public interface IProductService : IService<Product>, IImagesService
    {
        IQueryable<Product> GetRandomProducts(int count);
    }
}
