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

        [Route("about")]
        public IActionResult About()
        {
            ViewData["Message"] = "";

            return View();
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("terms")]
        public IActionResult Terms()
        {
            return View();
        }

        [Route("seattle-1310b-29th-ave-s")]
        public IActionResult SeattleHouse()
        {
            return View();
        }
    }
}
