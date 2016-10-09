namespace Gshahine.MVC5
{
  using System.Web.Mvc;

  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new ErrorHandler.AiHandleErrorAttribute());
      filters.Add(new HandleErrorAttribute());
    }
  }
}