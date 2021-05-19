using System;

namespace Structure
{
    struct Teams {
        public string title;
        public string driver;
        public string nationality;
        public string constructor;
        public int podium;    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teams team1;         

            team1.title = "Redbull Racing";
            team1.driver = "Alexander Alborn";
            team1.nationality = "Thailand";
            team1.constructor = "Honda";
            team1.podium = 2;

            Teams team2;
            team2.title = "AlphaTari";
            team2.driver = "Pierre Gasly";
            team2.nationality = "France";
            team2.constructor = "Honda";
            team2.podium = 3;

            Console.WriteLine("Title : {0}", team1.title);
            Console.WriteLine("Driver : {0}", team1.driver);
            Console.WriteLine("Nationality : {0}", team1.nationality);
            Console.WriteLine("Constructor : {0}", team1.constructor);
            Console.WriteLine("Podium : {0}", team1.podium);

            Console.ReadKey();
        }
    }
}
