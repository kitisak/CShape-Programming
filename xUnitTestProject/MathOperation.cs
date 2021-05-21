using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestProject
{
    public static class MathOperation
    {
        public static double Add(double myNum1, double myNum2)
        {
            return (myNum1 + myNum2);
        }

        public static double Subtract(double myNum1, double myNum2)
        {
            return (myNum1 - myNum2);
        }

        public static double Multiply(double myNum1, double myNum2)
        {
            return (myNum1 * myNum2);
        }

        public static double Divide(double myNum1, double myNum2)
        {
            return (myNum1 / myNum2);
        }
    }
}