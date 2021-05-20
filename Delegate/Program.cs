using System;

namespace Delegate
{
    public class Teams
    {
        public static void DispalyTeams(string message)
        {
            Console.WriteLine("Call Teams.DisplayTeams() with :" + message);
        }
    }

    public class Grandprix
    {
        public static void DispalyGP(string message)
        {
            Console.WriteLine("Call Grandprix.DispalyGP() with :" + message);
        }
    }

    // Define Delegate
    public delegate void MyDelegate(string msg);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del;
                
            del = Teams.DispalyTeams;
            del("Redbull Racing");

            del = Grandprix.DispalyGP;
            del("TuscanGP");

            del = (string msg) => Console.WriteLine("Call Lambda : " + msg);
            del("Alex Albon");
        }
    }
}
