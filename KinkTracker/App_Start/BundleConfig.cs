using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryUI").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                            .Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap")
                    .Include("~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/site")
                    .Include("~/Content/Site.css"));

        }
    }
}