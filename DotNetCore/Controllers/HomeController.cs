namespace Gshahine.DotNetCore.Controllers
{
  using Microsoft.AspNetCore.Mvc;

  public class HomeController : Controller
  {
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
  }
}
