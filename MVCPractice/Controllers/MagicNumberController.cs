using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class MagicNumberController : Controller
    {
        // GET: MagicNumber
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MagicNumberSubmit(int firstNumber, int secondNumber)
        {
            Random random = new Random();
            return View(viewName: "Index", model: random.Next(firstNumber,secondNumber));
        }
    }
}