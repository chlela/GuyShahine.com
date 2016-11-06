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

    [Route(".well-known/acme-challenge/WP9UtlstQdjCq_lQrJXFtuk5OGjCiv2CE2KKc7mVDeo")]
    public IActionResult AcmeDomainValidation() {
      return new FileContentResult(Encoding.UTF8.GetBytes("WP9UtlstQdjCq_lQrJXFtuk5OGjCiv2CE2KKc7mVDeo.u10OB683-R5VroKL7vZdOs75_EXzVyh9cOfccXZ4rcc"), "text/plain");
    }
  }
}
