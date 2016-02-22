namespace App.Web.Areas.User.UserViewModels
{
    using App.Data.Models;
    using Infrastructure.Mapping;
    using System.Collections.Generic;

    public class WishListViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string User { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}