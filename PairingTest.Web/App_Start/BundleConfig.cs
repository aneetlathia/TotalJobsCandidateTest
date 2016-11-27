using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PairingTest.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/angular-aria.js",
                "~/Scripts/angular-cookies.js",
                "~/Scripts/angular-csp.js",
                "~/Scripts/angular-loader.js",
                "~/Scripts/angular-message-format.js",
                "~/Scripts/angular-messages.js",
                "~/Scripts/angular-mocks.js",
                "~/Scripts/angular-parse-ext.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-sanitize.js",
                "~/Scripts/angular-scenario.js",
                "~/Scripts/angular-touch.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularApp").Include(
                "~/app/*.js",
                "~/app/Services/*.js",
                "~/app/Directives/*.js"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}