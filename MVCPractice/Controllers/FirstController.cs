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

        public ActionResult MagicNumber()
        {
            MagicNumberModel magicNumber = new MagicNumberModel(0,0);
            return View(viewName: "MagicNumber", model: magicNumber);
        }

        [HttpPost]
        public ActionResult GetMagicNumber(int number1, int number2)
        {
            MagicNumberModel magicNumber = new MagicNumberModel(number1, number2);
            return View(viewName: "MagicNumber", model: (magicNumber));
        }

        public ActionResult Dates()
        {
            DateData dateData = new DateData(new DateTime(), 0, 0, 0);
            return View(viewName: "Dates", model: dateData);
        }

        [HttpPost]
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            int year, leapYears, age;
            year = inputBirthday.Year;
            DateTime now = DateTime.Now;
            leapYears = 0;
            for (int count = year; count<now.Year; count++)
            {
                if (DateTime.IsLeapYear(count))
                    leapYears++;
            }
            DateTime nextElec = new DateTime(2020, 11, 3);
            if (nextElec.CompareTo(new DateTime(nextElec.Year, inputBirthday.Month, inputBirthday.Day)) < 0)
                age = nextElec.Year - (year - 1);
            else
                age = nextElec.Year - year;
            DateData dateData = new DateData(inputBirthday, age, year, leapYears);
            return View(viewName: "Dates", model: dateData);
        }

    }
}