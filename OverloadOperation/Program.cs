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
        }

        // Overload Operator
        public static ComplexNumber operator +(ComplexNumber myComplex1, ComplexNumber myComplex2)
        {
            ComplexNumber temp = new ComplexNumber();
            temp.myInt1 = myComplex1.myInt1 + myComplex2.myInt1;
            temp.myInt2 = myComplex1.myInt2 + myComplex2.myInt2;

            return temp;
        }

        public static ComplexNumber operator -(ComplexNumber myComplex1, ComplexNumber myComplex2)
        {
            ComplexNumber temp = new ComplexNumber();
            temp.myInt1 = myComplex1.myInt1 - myComplex2.myInt1;
            temp.myInt2 = myComplex1.myInt2 - myComplex2.myInt2;

            return temp;
        }

        public static ComplexNumber operator *(ComplexNumber myComplex1, ComplexNumber myComplex2)
        {
            ComplexNumber temp = new ComplexNumber();
            temp.myInt1 = myComplex1.myInt1 * myComplex2.myInt1;
            temp.myInt2 = myComplex1.myInt2 * myComplex2.myInt2;

            return temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber myComplex1 = new ComplexNumber(50, 100);
            myComplex1.Display();

            ComplexNumber myComplex2 = new ComplexNumber(5, 10);
            myComplex2.Display();

            ComplexNumber myResult = new ComplexNumber();
            myResult = myComplex1 + myComplex2;
            myResult.Display();

            Console.ReadKey();
        }
    }
}
