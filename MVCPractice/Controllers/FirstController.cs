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
            return View(viewName: "Index", model: "All starts here.");
        }

        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello " + inputString);
        }

        public ActionResult Square()
        {
            return View(viewName: "Square", model: 0.0);
        }

        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Square", model: (inputNumber * inputNumber));
        }

        [HttpPost]
        public ActionResult SayCube(double inputNumber)
        {
            return View(viewName: "Square", model: (inputNumber * inputNumber * inputNumber));
        }

        [HttpPost]
        public ActionResult SqrRoot(double inputNumber)
        {
            return View(viewName: "SqrRoot", model: (Math.Sqrt(inputNumber)));
        }

        public ActionResult MagicNumber()
        {
            return View(viewName: "MagicNumber", model: 0);
        }

        [HttpPost]
        public ActionResult MagicNumber(int firstNum, int secondNum)
        {
            if(firstNum > secondNum)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }
            Random gen = new Random();
            if(firstNum == secondNum || firstNum+1 == secondNum)
            {
                return View(viewName: "MagicNumber", model: (-999));
            }
            else
            {
                return View(viewName: "MagicNumber", model: (gen.Next(firstNum+1, secondNum)));
            }
        }

        public ActionResult Dates()
        {
            return View(viewName: "Dates", model: (DateTime.Now).ToShortDateString().ToString());
        }


        [HttpPost]
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            //Birthdate
            string birthdate = inputBirthday.ToShortDateString().ToString();

            //Age at next presidential election
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime presElec = new DateTime(2020, 11, 3);
            TimeSpan span = presElec - inputBirthday;
            int years = (zeroTime + span).Year - 1;
            string numYears = years.ToString();

            //Number of leap years

            return View(viewName: "Dates", model: ("Your Birthdate: " + birthdate + "\n" + "Age at Next Presidential Election: " + numYears ));
        }


    }
}
