namespace App.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Data;
    using Data.Common;
    using Data.Models;
    using ViewModels.Home;
    public class HomeController : Controller
    {
        private IDbRepository<Product> products;
        private IDbRepository<Category> categories;

        public HomeController(
            IDbRepository<Product> products,
            IDbRepository<Category> categories)
        {
            this.products = products;
            this.categories = categories;
        }

        public ActionResult Index()
        {
            var products = this.products.All()
                 .OrderBy(x => Guid.NewGuid())
                 .Take(3)
                 .Select(x => new ProductViewModel() { Name = x.Name })
                 .ToList();

            return this.View(products);
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}