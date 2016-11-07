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
  }
}
