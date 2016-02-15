namespace App.Services.Web.Contracts
{
    using System.Linq;

    using Data.Models;

    public interface IPromotionService : IService
    {
        IQueryable<Promotion> GetAllPromotions();

        Promotion GetById(int id);
    }
}
