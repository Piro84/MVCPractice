using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "Please type your name.");
        }

        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello " + inputString);
        }

    }
}