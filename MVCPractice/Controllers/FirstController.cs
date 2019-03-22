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
            MVCPractice.Models.Employee empl = new MVCPractice.Models.Employee();
            empl.name = "bob";
            empl.age = 141;
            return View(viewName: "Index", model: empl);
        }

        [HttpPost]
        public ActionResult EmployeeTransfer(MVCPractice.Models.Employee emp)
        {
            return View(viewName: "Index", model: emp);
        }
    }
}