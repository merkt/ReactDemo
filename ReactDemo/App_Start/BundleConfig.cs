using System.Web.Optimization;
using System.Web.Optimization.React;

namespace ReactDemo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BabelBundle("~/bundles/main").Include(
                "~/Scripts/Tutorial.jsx",
                "~/Scripts/showdown.js"
                ));
        }
    }
}