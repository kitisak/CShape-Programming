using System;

namespace StructureMethod
{
    struct Teams
    {
        private string title;
        private string driver;
        private string nationality;
        private string constructor;
        private int podium;

        public void getValues(string strTitle, string strDriver, string strNationality,
            string strConstructor, int intPodium)
        {
            title = strTitle;
            driver = strDriver;
            nationality = strNationality;
            constructor = strConstructor;
            podium = intPodium;
        }

        public void display()
        {
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Driver : {driver}");
            Console.WriteLine($"Nationality : {nationality}");
            Console.WriteLine($"Constructor : {constructor}");
            Console.WriteLine($"Title : {podium}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teams f1 = new Teams();

            f1.getValues("Redbull Racing", "Alex Alborn", "Thailand", "Honda", 2);
            f1.display();

            Console.ReadKey();
        }
    }
}
