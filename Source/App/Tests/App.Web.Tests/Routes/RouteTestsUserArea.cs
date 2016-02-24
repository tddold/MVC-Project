namespace App.Web.Tests.Routes
{
    using MvcRouteTester;

    using NUnit.Framework;

    using App.Web.Areas.User;
    using App.Web.Areas.User.Controllers;
    using Areas.User.UserViewModels;

    [TestFixture]
    public class RouteTestsUserArea : AreaRouteBase<UserAreaRegistration>
    {
        [Test]
        public void UserRouteShouldCallCorrespondingController()
        {
            this.Routes.ShouldMap("/User/WishList").To<WishListController>(x => x.Index());
        }

        [Test]
        public void UserCreateRouteShouldCallCorrespondingController()
        {
            var model = new WishListInputViewModel();
           
            this.Routes.ShouldMap("/User/WishList/Create/2").To<WishListController>(x => x.Create(model));
        }

        [Test]
        public void UserDeleteRouteShouldCallCorrespondingController()
        {
            var model = new WishListInputViewModel();

            this.Routes.ShouldMap("/User/WishList/Delete/1").To<WishListController>(x => x.Delete(1));
        }

        [Test]
        public void UserRouteShouldCallCorrespondingAnotheController()
        {
            this.Routes.ShouldMap("/User/ShoppingCart").To<ShoppingCartController>(x => x.Index());
        }

        [Test]
        public void UserCreatRouteShouldCallCorrespondingAnotheController()
        {
            var model = new ShoppingCartInputViewModel();

            this.Routes.ShouldMap("/User/ShoppingCart/Create/2").To<ShoppingCartController>(x => x.Create(model));
        }

        [Test]
        public void UserDeleteRouteShouldCallCorrespondingAnotheController()
        {
            var model = new ShoppingCartInputViewModel();

            this.Routes.ShouldMap("/User/ShoppingCart/Delete/1").To<ShoppingCartController>(x => x.Delete(1));
        }
    }
}
