namespace App.Web
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                 "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // Javascript(jQuery) Libraries and Plugins for Theme
            bundles.Add(new ScriptBundle("~/bundles/theme").Include(
                   "~/Content/Theme/js/libs/jquery-1.11.1.min.js",
                   "~/Content/Theme/js/libs/jquery-ui-1.10.4.custom.min.js",
                   "~/Content/Theme/js/libs/jquery.easing.min.js",
                   "~/Content/Theme/js/plugins/bootstrap.min.js",
                   "~/Content/Theme/js/plugins/smoothscroll.js",
                   "~/Content/Theme/js/plugins/jquery.validate.min.js",
                   "~/Content/Theme/js/plugins/icheck.min.js",
                   "~/Content/Theme/js/plugins/jquery.placeholder.js",
                   "~/Content/Theme/js/plugins/jquery.stellar.min.js",
                   "~/Content/Theme/js/plugins/jquery.touchSwipe.min.js",
                   "~/Content/Theme/js/plugins/jquery.shuffle.min.js",
                   "~/Content/Theme/js/plugins/lightGallery.min.js",
                   "~/Content/Theme/js/plugins/owl.carousel.min.js",
                   "~/Content/Theme/js/plugins/masterslider.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/theme-mailer").Include(
                    "~/Content/Theme/mailer/mailer.js",
                   "~/Content/Theme/js/scripts.js"));

            bundles.Add(new ScriptBundle("~/bundles/theme-modernizr").Include(
                     "~/Content/Theme/js/libs/modernizr.custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                   "~/Scripts/KendoUI/kendo.all.min.js",
                   "~/Scripts/KendoUI/kendo.aspnetmvc.min.js"));

            // bundles.Add(new ScriptBundle("~/bundles/theme-shuffle").Include(
            //        "~/Content/Theme/js/plugins/jquery.shuffle.min.js"));
        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/admin").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/admin.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/styleBundles/theme")
               .Include("~/Content/Theme/masterslider/style/masterslider.css")
               .Include("~/Content/Theme/css/styles.css"));

            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                    "~/Content/KendoUI/kendo.common.min.css",
                    "~/Content/KendoUI/kendo.default.min.css"));
        }
    }
}
