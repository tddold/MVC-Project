namespace App.Routes.Tests
{
    using System.Web.Routing;

    using NUnit.Framework;

    using Web;
    using System.Web;

    [TestFixture]
    [Category("Unit")]
    public class AppRouteTests
    {
        [Test]
        [Description("Verifies that the URL root (empty) matches the 'HomeController.Index()' action.")]
        public void TestRootUrlMatchesHomeIndex()
        {
            // Arrange
            const string url = "~/";
            var mockRequest = MockRepository.GenerateStub<HttpRequestBase>();
            var mockContext = MockRepository.GenerateStub<HttpContextBase>();

            mockRequest.Stub(r => r.AppRelativeCurrentExecutionFilePath)
                   .Return(url)
                   .Repeat.Any();
            mockRequest.Stub(r => r.PathInfo)
                       .Return(string.Empty)
                       .Repeat.Any();
            mockContext.Stub(c => c.Request)
                       .Return(mockRequest)
                       .Repeat.Any();

            // Act
            RouteTable.Routes.Clear();
            MvcApplication.RegisterRoutes(RouteTable.Routes);
            var routeData = RouteTable.Routes.GetRouteData(mockContext);

            // Assert
            Assert.Multiple(() =>
        {
            Assert.AreEqual("home",
                            routeData.Values["controller"].ToString(),
                            StringComparison.InvariantCultureIgnoreCase);
            Assert.AreEqual("index",
                            routeData.Values["action"].ToString(),
                            StringComparison.InvariantCultureIgnoreCase);
        });
        }
    }
}



//[Test]
//public void TestMethodById()
//{
//    const string Url = "/Products";
//    var routeCollection = new RouteCollection();
//    RouteConfig.RegisterRoutes(routeCollection);
//    routeCollection.ShouldMap(Url).To<ProductsController>(c =>c.Index);
//    }