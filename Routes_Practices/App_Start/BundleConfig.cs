using System.Web;
using System.Web.Optimization;

namespace Routes_Practices
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jslibs").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/semantic.js",
                        "~/Scripts/modernizr-*"
            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            // bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //             "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/csslibs").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/semantic.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/custJs").Include(
                        "~/Scripts/Cust/cust.js"
            ));

            bundles.Add(new StyleBundle("~/Content/custCss").Include(
                      "~/Content/Site.css"
            ));
        }
    }
}
