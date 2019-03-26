using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class DateData
    {
        public DateTime birthday;
        public int age, year, leapYears;
        public DateData(DateTime birthday, int age, int year, int leapYears)
        {
            this.birthday = birthday;
            this.age = age;
            this.year = year;
            this.leapYears = leapYears;
        }
    }
}