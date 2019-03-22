using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "Thomas start page");
        }

        [HttpPost]
        public ActionResult ThomasHello(string inputString)
        {
            return View(viewName: "Index", model: "Thomas says 'Hello " + inputString + "'");
        }

    }
}