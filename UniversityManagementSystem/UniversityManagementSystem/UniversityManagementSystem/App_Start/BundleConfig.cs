﻿using System.Web;
using System.Web.Optimization;

namespace UniversityManagementSystem
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
                      "~/Scripts/script.js",
                      "~/Scripts/wowslider.js",
                      "~/Scripts/bootstrap-datetimepicker.js",
                      //"~/Scripts/wowslider.mod.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/Angular.js").Include(
                "~/Scripts/angular.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/style.css",
                      "~/Content/style.mod.css",
                      "~/Content/bootstrap-datetimepicker.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/slideStyle").Include(
                    "~/Content/SlideStyle/style.css"
                ));
            bundles.Add(new StyleBundle("~/Content/slideScripts").Include(
                "~/Scripts/SlideScripts/script.js",
                "~/Scripts/SlideScripts/wowslider.js"
                ));
               bundles.Add(new StyleBundle("~/Content/dataTablesDesigner").Include(
                "~/Content/DataTables/css/jquery.dataTables.min.css"
                ));

            bundles.Add(new StyleBundle("~/Scripts/dataTablesScripts").Include(
                "~/Scripts/DataTables/jquery.dataTables.min.js"
    ));

        }
    }
}
