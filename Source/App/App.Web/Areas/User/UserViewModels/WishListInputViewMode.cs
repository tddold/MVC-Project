namespace App.Web.Areas.User.UserViewModels
{
    using App.Data.Models;
    using Infrastructure.Mapping;
    using System.Collections.Generic;

    public class WishListInputViewMode : IMapFrom<Product>, IMapTo<Product>
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}