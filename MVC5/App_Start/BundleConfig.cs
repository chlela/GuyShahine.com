namespace Gshahine.MVC5.App_Start
{
  using Microsoft.Azure;
  using System;
  using System.Web.Optimization;

  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.UseCdn = true;

      bundles.IgnoreList.Ignore("*.intellisense.js", OptimizationMode.Always);
      bundles.IgnoreList.Ignore("*.min.css", OptimizationMode.Always);
      bundles.IgnoreList.Ignore("*.map", OptimizationMode.Always);

      string cdnPath = new UriBuilder(CloudConfigurationManager.GetSetting("CdnStorageCdnUrl")).Host;

      bundles.Add(new StyleBundle("~/bundles/css/main")
        .Include("~/bower_components/bootstrap/dist/css/bootstrap.css")
        .Include("~/build/assets/stylesheets/site.css"));

      bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory("~/Scripts/app", "*.js", true));

      var jqueryBundle = new ScriptBundle("~/bundles/jquery", "https://" + cdnPath + "/scripts/jquery/3.1.0/jquery.min.js")
                           .Include("~/bower_components/jquery/dist/jquery.js");
      jqueryBundle.CdnFallbackExpression = "jQuery";
      bundles.Add(jqueryBundle);

      var bootstrapBundle = new ScriptBundle("~/bundles/bootstrap", "https://" + cdnPath + "/scripts/bootstrap/3.3.7/bootstrap.min.js")
                      .Include("~/bower_components/bootstrap/dist/js/bootstrap.js");
      bootstrapBundle.CdnFallbackExpression = "window.jQuery && window.jQuery.fn && window.jQuery.fn.modal";
      bundles.Add(bootstrapBundle);
    }
  }
}