namespace App.Web.Areas.User.Controllers
{
    using System.Web.Mvc;

    using App.Data.Models;
    using App.Services.Web.Contracts;
    using App.Web.Controllers;

    public class WhishListController : BaseController
    {
        // GET: User/WhishList
        private IService<Product> productsService;

        public WhishListController(
            IService<Product> productsService)
        {
            this.productsService = productsService;
        }

        // GET: User/WhishList
        public ActionResult Index()
        {
            return this.View();
        }
    }
}