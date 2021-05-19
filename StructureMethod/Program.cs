using System;

namespace StructureMethod
{
    struct Teams
    {
        public string title;
        public string driver;
        public string nationality;
        public string constructor;
        public int podium;

        public void getValues(string strTitle, string strDriver, string strNationality,
            string strConstructor, int intPodium)
        {
            title = strTitle;
            driver = strDriver;
            nationality = strNationality;
            constructor = strConstructor;
            podium = intPodium;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
