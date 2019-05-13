using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace Server.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Script/Bundles")
                .Include(
                       "~/Bundles/inline.*",
                       "~/Bundles/polyfills.*",
                       "~/Bundles/main.*"
                       ));
            bundles.Add(new StyleBundle("~/Content/Styles")
                .Include(
                    "~/Bundles/*.css"
                    ));
        }
    }
}