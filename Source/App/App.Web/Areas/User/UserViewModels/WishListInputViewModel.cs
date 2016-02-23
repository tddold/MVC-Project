namespace App.Web.Areas.User.UserViewModels
{
    using App.Data.Models;
    using Infrastructure.Mapping;
    using System.Collections.Generic;

    public class WishListInputViewModel : IMapFrom<Product>, IMapTo<Product>
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ProductId { get; set; }

        public int WishListCount { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}