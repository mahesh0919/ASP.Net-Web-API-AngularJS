using System.Web;
using System.Web.Optimization;

namespace MVC4_WebAPI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
                     "~/Scripts/AngularJS/angular*"));

            bundles.Add(new ScriptBundle("~/bundles/customJS").Include(
                "~/Scripts/Custom/MyModule.js",
                "~/Scripts/Custom/MyRoute.js",
                "~/Scripts/Custom/MyService.js",
                "~/Scripts/Custom/MyController.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

        }
    }
}