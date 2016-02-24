namespace App.Web.Tests.Routes
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    using MvcRouteTester;

    using NUnit.Framework;

    using App.Web.Controllers;
    using ViewModels.Account;

    [TestFixture]
    public class RouteTestsNoArea
    {
        private RouteCollection routeCollection;

        [SetUp]
        public void InitTests()
        {
            this.routeCollection = new RouteCollection();
            RouteConfig.RegisterRoutes(this.routeCollection);
        }

       
        public void RegisterAreaRoutes<TAreaRegistration>(RouteCollection routes)
            where TAreaRegistration : AreaRegistration, new()
        {
            var area = new TAreaRegistration();
            var ctx = new AreaRegistrationContext(area.AreaName, routes);
            area.RegisterArea(ctx);
        }

        // Home and login
        [Test]
        public void HomeRouteShouldCallCorrespondingController()
        {
            this.routeCollection.ShouldMap("/Home").To<HomeController>(x => x.Index());
        }

        [Test]
        public void LogoffRouteShouldCallCorrespondingController()
        {
            this.routeCollection.ShouldMap("/Account/Logoff").To<AccountController>(x => x.LogOff());
        }

      
        // Profile user page
        //[Test]
        //public void ProfileRouteShouldCallCorrespondingController()
        //{
        //    this.routeCollection.ShouldMap("/Profile").To<ProfileController>(x => x.Index());
        //}

        [Test]
        public void ResetRouteShouldCallCorrespondingController()
        {
            var model = new ResetPasswordViewModel();
            this.routeCollection.ShouldMap("/Account/ResetPassword").To<AccountController>(x => x.ResetPassword(model));
        }
    }
}
