using System;

namespace MethodOut
{
    class Program
    {
        //Output Parameter
        public void getVal(out int x, out int y) {
            Console.WriteLine("Enter Value 1: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value 2: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Program myNum = new Program();

            int num1, num2;

            myNum.getVal(out num1, out num2);

            Console.WriteLine("Value after call method 1: {0}", num1);
            Console.WriteLine("Value after call method 2: {0}", num2);
            Console.ReadLine();
        }
    }
}
