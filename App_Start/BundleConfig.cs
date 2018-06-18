using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Assets/css").Include(
                "~/assets/vendor/bootstrap/css/bootstrap.css",
                "~/assets/vendor/fontawesome/css/font-awesome.min.css",
                "~/assets/vendor/flaticons/flaticon.css",
                "~/assets/vendor/hover/css/hover-min.css",
                "~/assets/vendor/wow/animate.css",
                "~/assets/vendor/mfp/css/magnific-popup.css",
                "~/assets/vendor/footable/footable.core.css",
                "~/assets/custom/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/Assets/js").Include(
                "~/assets/vendor/jquery/js/jquery-2.2.0.min.js",
                "~/assets/vendor/bootstrap/js/bootstrap.min.js",
                "~/assets/vendor/imagesloaded/js/imagesloaded.pkgd.min.js",
                "~/assets/vendor/mfp/js/jquery.magnific-popup.min.js",
                "~/assets/vendor/circle-progress/circle-progress.js",
                "~/assets/vendor/wow/wow.min.js",
                "~/assets/vendor/pjax/jquery.pjax.js",
                "~/assets/vendor/footable/footable.all.min.js",
                "~/assets/custom/js/custom.js"
                ));

        }
    }
}
