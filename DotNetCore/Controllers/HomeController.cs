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

    public IActionResult AMP()
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

    [RouteAttribute("tNryy_CVd4W2gkGcvsKjB6gIkjgiOP5iaQtmVx-aKV8")]
     public IActionResult Verify1()
     {
       return Content("tNryy_CVd4W2gkGcvsKjB6gIkjgiOP5iaQtmVx-aKV8.sexpcY0QdD9A1ERg6I_4tpbj8UhmXCh4no4wyTXbVy0");
     }

     [RouteAttribute("s-S7LQmqysEPJPqwmk5FoMPO8H4DA5I2Wzc0Z0lGdBM")]
     public IActionResult Verify2()
     {
       return Content("s-S7LQmqysEPJPqwmk5FoMPO8H4DA5I2Wzc0Z0lGdBM.sexpcY0QdD9A1ERg6I_4tpbj8UhmXCh4no4wyTXbVy0");
     }
  }
}
