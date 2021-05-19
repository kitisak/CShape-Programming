using System;

namespace SharedMember
{
    // Static Class
    public static class TemperatureConverter {
        // Static Member
        public static double NumTemperature;

        // Static Method
        public static double GetTemp
        {
            get {
                return 0.0;
            }
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TemperatureConverter.NumTemperature = 15.5);            
        }
    }
}
