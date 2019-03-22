using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

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

        public ActionResult Square()
        {
            SquareModel square = new SquareModel(0.0);
            return View(viewName: "Square", model: square);
        }

        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            SquareModel square = new SquareModel(inputNumber);
            return View(viewName: "Square", model: (square));
        }

    }
}