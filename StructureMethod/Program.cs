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
        
        public void disply()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Driver : {0}", driver);
            Console.WriteLine("Nationality : {0}", nationality);
            Console.WriteLine("Constructor : {0}", constructor);
            Console.WriteLine("Podium : {0}", podium);
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
