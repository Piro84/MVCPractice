using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class MagicNumberModel
    {
        public int magicNumber;
        public MagicNumberModel(int number1, int number2)
        {
            Random rand = new Random();
            if (number1 >= number2)
                magicNumber = rand.Next(number2, (number1 + 1));
            else
                magicNumber = rand.Next(number1, (number2+1));
        }
    }
}