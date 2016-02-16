namespace App.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using Web.Controllers;
    using Common;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    public class AdministrationController : BaseController
    {
    }
}