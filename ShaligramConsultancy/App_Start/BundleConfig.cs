// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="Microsoft">
//   Copyright � 2017 Microsoft
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.ShaligramConsultancy
{
    using System.Web;
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/app").Include("~/content/app.css",
                "~/content/css/bootstrap.min.css",
                "~/content/css/custom.min.css",
                "~/content/css/font-awesome.min.css",
                //"~/content/css/header.custom.min.css",
                "~/content/css/header.responsive.min.css",
                "~/content/css/responsive.min.css"
                ));
                
            //bundles.Add(new ScriptBundle("~/js/app").Include(
            //      "~/scripts/js/jquery.min.js",
            //    "~/scripts/vendor/angular-ui-router.js",
            //    "~/scripts/filters.js",
            //    "~/scripts/services.js",
            //    "~/scripts/directives.js",
            //    "~/scripts/controllers.js",
            //    "~/scripts/app.js",
            //     "~/scripts/js/bootstrap.min.js",
            //    "~/scripts/js/Priceformscript.js",
            //       "~/scripts/js/sticky-kit.min.js"
            //       ));


            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                         "~/Scripts/js/jquery.min.js"
                         , "~/Scripts/js/Priceformscript.js"
                       ));

            bundles.Add(new ScriptBundle("~/js/bootstrapBundle").Include(
                "~/Scripts/js/bootstrap.min.js",
                "~/Scripts/vendor/angular.js"
                ));

            bundles.Add(new ScriptBundle("~/js/routerBundle").Include(
                "~/Scripts/vendor/angular-ui-router.js",
                "~/Scripts/toastr.js"
                ));

            bundles.Add(new ScriptBundle("~/js/app").Include(
                "~/Scripts/app.js",
                "~/Scripts/js/sticky-kit.min.js"
                ));

            bundles.Add(new ScriptBundle("~/js/angularModule").Include(
                "~/Scripts/controllers.js",
                "~/Scripts/filters.js",
                "~/Scripts/services.js",
                "~/Scripts/directives.js"
                ));


        }
    }
}
