using System;

namespace Enumerations
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
        
        static void Main(string[] args)
        {
          
            Console.WriteLine("Sunday : {0}", (int)Days.Sunday);
            Console.WriteLine("Monda : {0}", (int)Days.Monday);
            Console.WriteLine("Tuesday : {0}", (int)Days.Tuesday);
            Console.WriteLine("Wednesday : {0}", (int)Days.Wednesday);
            Console.WriteLine("Thursday : {0}", (int)Days.Thursday);
            Console.WriteLine("Friday : {0}", (int)Days.Friday);
            Console.WriteLine("Saturday : {0}", (int)Days.Saturday);

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Sunday : {0}", Days.Sunday);
            Console.WriteLine("Monda : {0}", Days.Monday);
            Console.WriteLine("Tuesday : {0}", Days.Tuesday);
            Console.WriteLine("Wednesday : {0}", Days.Wednesday);
            Console.WriteLine("Thursday : {0}", Days.Thursday);
            Console.WriteLine("Friday : {0}", Days.Friday);
            Console.WriteLine("Saturday : {0}", Days.Saturday);
            Console.ReadKey();

            /*
          int WeekDateStart = (int)Days.Monday;
          int WeekDateEnd = (int)Days.Sunday;

          Console.WriteLine("Monday : {0}", WeekDateStart);
          Console.WriteLine("Sunday : {0}", WeekDateEnd);
          */

        }
    }
}
