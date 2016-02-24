namespace App.Web.Tests.Routes
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public abstract class AreaRouteBase<T>
        where T : AreaRegistration, new()
    {
        public AreaRouteBase()
        {
            // Arrange
            this.Routes = new RouteCollection();
            T area = new T();
            AreaRegistrationContext context = new AreaRegistrationContext(area.AreaName, this.Routes);
            area.RegisterArea(context);
        }

        public RouteCollection Routes { get; private set; }
    }
}
