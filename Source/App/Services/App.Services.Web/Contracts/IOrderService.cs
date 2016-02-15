namespace App.Services.Web.Contracts
{
    using App.Data.Models;

    public interface IOrderService : IService
    {
        Order GetById(int id);
    }
}
