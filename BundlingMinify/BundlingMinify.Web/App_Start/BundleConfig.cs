using System.Web;
using System.Web.Optimization;

namespace BundlingMinify.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new Bundle("~/bundles/NgAppes5").Include(
                "~/Scripts/NgApp/runtime-es5.js",
                "~/Scripts/NgApp/polyfills-es5.js",
                "~/Scripts/NgApp/styles-es5.js",
                "~/Scripts/NgApp/vendor-es5.js",
                "~/Scripts/NgApp/main-es5.js"
                ));

            bundles.Add(new Bundle("~/bundles/NgAppes2015").Include(
                "~/Scripts/NgApp/runtime-es2015.js",
                "~/Scripts/NgApp/polyfills-es2015.js",
                 "~/Scripts/NgApp/styles-es2015.js",
                "~/Scripts/NgApp/vendor-es2015.js",
                "~/Scripts/NgApp/main-es2015.js"
                ));
        }
    }
}
