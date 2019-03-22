using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class SquareModel
    {
        public double square, sqrt, cube;
        public SquareModel(double num)
        {
            square = num * num;
            sqrt = Math.Sqrt(num);
            cube = num * num * num;
        }
    }
}