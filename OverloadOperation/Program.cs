using System;

namespace OverloadOperation
{
    public class ComplexNumber
    {
        private int myInt1;
        private int myInt2;

        public ComplexNumber() { }

        public ComplexNumber (int myNum1, int myNum2)
        {
            myInt1 = myNum1;
            myInt2 = myNum2;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1}", myInt1, myInt2);
            Console.ReadKey();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber myComplex1 = new ComplexNumber(50, 100);
            myComplex1.Display();
        }
    }
}
