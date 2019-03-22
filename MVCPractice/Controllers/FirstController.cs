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
            Employee empl = new Employee();
            empl.name = "bob";
            empl.age = 141;
            empl.Qualifications = new string[] {"c#", "java", "MVC" };
            return View(viewName: "Index", model: empl);
        }

        [HttpPost]
        public ActionResult SayHello(Employee emp)
        {
            return View(viewName: "Index", model: emp);
        }

    }
}
