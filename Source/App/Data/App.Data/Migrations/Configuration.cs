namespace App.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using App.Common;
    using Models;
    using System.Collections.Generic;
    public sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AppDbContext context)
        {
            const string AdministratorUserName = "admin@admin.com";
            const string AdministratorPassword = AdministratorUserName;

            var users = new List<User>();
            if (!context.Roles.Any())
            {
                // Create admin role
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var role = new IdentityRole { Name = GlobalConstants.AdministratorRoleName };
                roleManager.Create(role);

                // Create admin user
                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var user = new User
                {
                    UserName = AdministratorUserName,
                    Email = AdministratorUserName
                };

                userManager.Create(user, AdministratorPassword);

                // Assign user to admin role
                userManager.AddToRole(user.Id, GlobalConstants.AdministratorRoleName);
            }


            if (!context.Users.Any(u => u.UserName != "admin"))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                manager.PasswordValidator = new PasswordValidator
                {
                    RequiredLength = 3,
                    RequireNonLetterOrDigit = false,
                    RequireDigit = false,
                    RequireLowercase = false,
                    RequireUppercase = false,
                };

                for (int i = 1; i <= 5; i++)
                {
                    var user = new User
                    {
                        UserName = "user" + i + "@site.com",
                        Email = "user@site.com",
                    };

                    manager.Create(user, "user" + i);
                    users.Add(user);
                }

                context.SaveChanges();
            }

            if (context.Products.Any())
            {
                return;
            }

            var seed = new SeedData(users);

            seed.Products.ForEach(x => context.Products.Add(x));

            context.SaveChanges();
        }
    }
}
