namespace App.Services.Web
{
    using System.Linq;

    using App.Services.Web.Contracts;
    using Data.Models;
    using Data.Common;

    public class PromotionService : IPromotionService
    {
        private IDbRepository<Promotion> promotions;

        public PromotionService(IDbRepository<Promotion> promotions)
        {
            this.promotions = promotions;
        }
        public IQueryable<Promotion> GetAllPromotions()
        {
            return this.promotions.All();
        }

        public Promotion GetById(int id)
        {
            return this.promotions
                .All()
                .FirstOrDefault(pr => pr.Id == id);
        }
    }
}
