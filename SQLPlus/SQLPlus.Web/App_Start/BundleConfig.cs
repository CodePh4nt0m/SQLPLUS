﻿using System.Web;
using System.Web.Optimization;

namespace SQLPlus.Web
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

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                        "~/Scripts/knockout-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/director").Include(
                        "~/Scripts/director.js"));

            // pixel admin bundles
            bundles.Add(new ScriptBundle("~/bundles/pixeladmin").Include(
                        "~/javascripts/jquery.transit.min.js",
                        "~/javascripts/bootstrap.min.js",
                        "~/javascripts/pixel-admin.min.js"));

            bundles.Add(new StyleBundle("~/styles/pixeladmin").Include(
                      "~/stylesheets/bootstrap.min.css",
                      "~/stylesheets/pixel-admin.min.css",
                      "~/stylesheets/widgets.min.css",
                      "~/stylesheets/pages.min.css",
                      "~/stylesheets/rtl.min.css",
                      "~/stylesheets/themes.min.css"));
            // end pixel admin

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/app/app.js",
                        "~/Scripts/app/routes.js"));
        }
    }
}
