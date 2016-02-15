namespace App.Services.Web
{
    using System;
    using Data.Models;
    using App.Services.Web.Contracts;
    using Data.Common;
    using System.Linq;
    public class OrderService : IOrderService
    {
        private IDbRepository<Order> orders;

        public OrderService(IDbRepository<Order> orders)
        {
            this.orders = orders;
        }

        public Order GetById(int id)
        {
            return this.orders
                .All()
                .FirstOrDefault(o => o.Id == id);
        }
    }
}
