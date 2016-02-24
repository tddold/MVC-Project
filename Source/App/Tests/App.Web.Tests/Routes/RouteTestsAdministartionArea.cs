namespace App.Web.Tests.Routes
{
    using MvcRouteTester;

    using NUnit.Framework;

    using App.Web.Areas.Administration;
    using App.Web.Areas.Administration.Controllers;

    [TestFixture]
    public class RouteTestsAdministartionArea : AreaRouteBase<AdministrationAreaRegistration>
    {
        [Test]
        public void UserRouteShouldCallCorrespondingController()
        {
            this.Routes.ShouldMap("/Administration/Users").To<UsersController>(x => x.Index());
        }

        [Test]
        public void UserCreateRouteShouldCallCorrespondingController()
        {
            this.Routes.ShouldMap("/Administration/Users/Create").To<UsersController>(x => x.Create());
        }

        [Test]
        public void UserDeleteRouteShouldCallCorrespondingController()
        {
            this.Routes.ShouldMap("/Administration/Users/Delete/1").To<UsersController>(x => x.Delete("1"));
        }

        [Test]
        public void UserEditRouteShouldCallCorrespondingAnotheController()
        {
            this.Routes.ShouldMap("/Administration/Users/Edit/1").To<UsersController>(x => x.Edit("1"));
        }

        [Test]
        public void UserDetailsRouteShouldCallCorrespondingAnotheController()
        {
            this.Routes.ShouldMap("/Administration/Users/Details/1").To<UsersController>(x => x.Details("1"));
        }

        [Test]
        public void UserDeleteRouteShouldCallCorrespondingAnotheController()
        {
            this.Routes.ShouldMap("/Administration/Users/Delete/1").To<UsersController>(x => x.Delete("1"));
        }
    }
}
