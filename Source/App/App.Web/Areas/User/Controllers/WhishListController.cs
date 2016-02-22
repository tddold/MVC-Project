using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Web.Areas.User.Controllers
{
    public class WhishListController : Controller
    {
        // GET: User/WhishList
        public ActionResult Index()
        {
            return View();
        }
    }
}