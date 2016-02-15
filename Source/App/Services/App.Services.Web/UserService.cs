namespace App.Services.Web
{
    using System;
    using System.Linq;

    using Microsoft.AspNet.Identity;

    using App.Data.Models;
    using Contracts;

    public class UserService : IUserService
    {
        private readonly UserManager<User> users;

        public UserService(UserManager<User> users)
        {
            this.users = users;
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
