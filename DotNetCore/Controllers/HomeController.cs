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

    [Route(".well-known/acme-challenge/bsAANM6dd6OlpX07uXMkISJX3l9aY7whGIZSD6yuW5o")]
    public IActionResult AcmeDomainValidation() {
      return new FileContentResult(Encoding.UTF8.GetBytes("bsAANM6dd6OlpX07uXMkISJX3l9aY7whGIZSD6yuW5o.u10OB683-R5VroKL7vZdOs75_EXzVyh9cOfccXZ4rcc"), "text/plain");
    }

     [Route(".well-known/acme-challenge/oW6HgjwN7ZLzL7A9rqza7khxGY7evAGNOhiWa4xOxJ4")]
    public IActionResult AcmeDomainValidation2() {
      return new FileContentResult(Encoding.UTF8.GetBytes("oW6HgjwN7ZLzL7A9rqza7khxGY7evAGNOhiWa4xOxJ4.u10OB683-R5VroKL7vZdOs75_EXzVyh9cOfccXZ4rcc"), "text/plain");
    }
  }
}
