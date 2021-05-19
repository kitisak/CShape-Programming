using System;

namespace ParamArray
{
    class Program
    {
        //Demo 01
        /* 
        double getAVG(int[] myArray, int size) {
            int i;
            double avg;
            int summary = 0;

            for (i = 0; i < size; i++) {
                summary += myArray[i];
            }

            avg = (double)summary / size;
            return avg;
        }

        static void Main(string[] args)
        {
            Program myApp = new Program();

            int[] mylist = new int[] { 100, 200, 300, 400, 500 };
            double avg;

            avg = myApp.getAVG(mylist, 5);

            Console.WriteLine("Average value : {0}", avg);
            Console.ReadKey();
        }
        */

        public int AddArrayMembers(params int[] myArr) {
            int sum = 0;

            foreach (int i in myArr) {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Program myApp = new Program();

            int sum = myApp.AddArrayMembers(10, 20, 30, 40, 50);

            Console.WriteLine("Summary is {0}", sum);
            Console.ReadKey();

        }    
    }
}
