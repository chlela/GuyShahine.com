﻿namespace Gshahine.MVC5.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        [Route("now")]
        public ActionResult Now()
        {
            return View();
        }
    }
}
