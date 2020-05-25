using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    static public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                "~/Content/bootstrap.min.css",
                "~/Content/fontawesome.min.css",
                "~/Content/iconfont.min.css",
                "~/Content/helper.css",
                "~/Content/plugins.min.css",
                "~/Content/style.min.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                "~/Scripts/jquery-3.5.0.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/popper.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/plugins.min.js",
                "~/Scripts/main.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/modernizer")
                .Include("~/Scripts/modernizr-2.8.3.min.js"));
        }
    }
}