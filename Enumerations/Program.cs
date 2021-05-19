using System;

namespace Enumerations
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
        
        static void Main(string[] args)
        {
            int WeekDateStart = (int)Days.Monday;
            int WeekDateEnd = (int)Days.Sunday;

            Console.WriteLine("Monday : {0}", WeekDateStart);
            Console.WriteLine("Sunday : {0}", WeekDateEnd);
        }
    }
}
