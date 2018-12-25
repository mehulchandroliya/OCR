using System.Web;
using System.Web.Optimization;

namespace OCR.Master.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jQuery/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/fontawesome/css/all.css",
                "~/Content/bootstrap/bootstrap.css"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
