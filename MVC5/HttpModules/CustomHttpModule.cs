namespace Gshahine.MVC5.HttpModules
{
  using System;
  using System.Linq;
  using System.Web;

  public class CustomHttpModule : IHttpModule
  {
    public void Init(HttpApplication context)
    {
      context.BeginRequest += onBeginRequest;
    }

    public void Dispose()
    { }

    private void onBeginRequest(object sender, EventArgs e)
    {
      HttpApplication app = (HttpApplication)sender;

      if (app.Request.Path.IndexOf("/blog") == 0)
      {
        var splitPath = app.Request.Path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

        string postName = splitPath.Length > 1 ? splitPath.Last() : string.Empty;

        var newUrl = new Uri(new Uri("http://blog.gshahine.com"), postName);

        app.Response.RedirectPermanent(newUrl.AbsoluteUri, true);
      }
    }
  }
}