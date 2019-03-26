using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class UnitConverterController : Controller
    {
        // GET: UnitConverter
        public ActionResult Index()
        {
            return View(viewName: "Index", model:"");
        }

        public ActionResult Convert(double toConvert, String UnitIn, String UnitOutWithComma)
        {
            string[] outStringArray = UnitOutWithComma.Split(',');
            string outputString = outStringArray[1];
            string UnitOut = outStringArray[0];
            Double.TryParse(UnitIn, out double input);
            Double.TryParse(UnitOut, out double output);
            toConvert = input * toConvert / output;
            return View(viewName: "Index", model: toConvert + " " + outputString);
        }
    }
}