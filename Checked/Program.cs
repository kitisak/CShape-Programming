using System;

namespace Checked
{
    class Program
    {
        static int maxIntValue = 2147483647;

        static void Main(string[] args)
        {
            int result = 0;

            try
            {
                result = checked(maxIntValue + 10);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("Check Integer is Error : " + ex.ToString());
            }            

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
