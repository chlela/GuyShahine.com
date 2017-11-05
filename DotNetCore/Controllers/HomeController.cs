namespace Gshahine.DotNetCore.Controllers
{
  using System.Text;
  using Microsoft.AspNetCore.Mvc;

  public class HomeController : Controller
  {
    [Route("html5")]
    public IActionResult HTML5()
    {
      return View();
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Error()
    {
      return View();
    }

    [Route("seattle-1310b-29th-ave-s")]
    public IActionResult SeattleHouse()
    {
      return View();
    }

    [RouteAttribute(".well-known/acme-challenge/A-UKy5zxBfxSjs2-G8VIubeFj_F4E-1H9_H05INs4jI")]
     public IActionResult Verify1()
     {
       return Content("A-UKy5zxBfxSjs2-G8VIubeFj_F4E-1H9_H05INs4jI.85aiEmllgEjwN7iEz6QhiltWMD9Su42NUffD0VenhgQ");
     }

     [RouteAttribute(".well-known/acme-challenge/Axx9OHDf2a4NF248wHutFQF1jqClbxukfKoOAcH5c-w")]
     public IActionResult Verify2()
     {
       return Content("Axx9OHDf2a4NF248wHutFQF1jqClbxukfKoOAcH5c-w.85aiEmllgEjwN7iEz6QhiltWMD9Su42NUffD0VenhgQ");
     }
  }
}
