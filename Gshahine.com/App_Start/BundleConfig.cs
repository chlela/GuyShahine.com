namespace Gshahine.com.App_Start
{
    using System;
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new StyleBundle("~/bundles/main").IncludeDirectory("~/Content/css/", "*.css", true));

            bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory("~/Scripts/app", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                            .Include("~/Scripts/jquery-2*")
                            .Include("~/Scripts/jquery.color-2*")
                            .Include("~/Scripts/jquery.signalR-2*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-js", "//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js")
                            .Include("~/Scripts/bootstrap.js"));
        }
    }
}