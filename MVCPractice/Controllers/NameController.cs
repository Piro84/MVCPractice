using MVCPractice.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class NameController : Controller
    {
        // GET: Name
        public ActionResult Index()
        {
            ViewBag.NameList = "Name lsit";
            List<NameList> nameList = new List<NameList>()
            {
                new NameList{ID=0, FirstName="Thomas", LastName = "Harmeyer"},
                new NameList { ID = 1, FirstName = "Nabil", LastName = "Hussani" },
                new NameList { ID = 2, FirstName = "Anja", LastName = "Logan" },
            };

            return View(nameList);
        }
    }
}