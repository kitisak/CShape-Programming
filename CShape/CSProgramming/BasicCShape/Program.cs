using System;
using System.Text;

namespace BasicCShape
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo 01 : Variable
            int myInt;
            short myShort;
            double myDouble;

            myInt = 100;
            myShort = 200;
            myDouble = myInt + myShort;

            Console.WriteLine("myInt variable : {0}, myShort variable : {1}, myDouble variable : {2}", myInt, myShort, myDouble);
            Console.ReadLine();
            
            


            /* // Demo 02 : Convert Type
            int myInt = 800;
            float myFloat = 500.55F;
            double myDouble = 2545.55;
            bool myBool = true;
            int myNum = 700;

            Console.WriteLine(myInt.ToString());
            Console.WriteLine(myFloat.ToString());
            Console.WriteLine(myDouble.ToString());
            Console.WriteLine(myBool.ToString());
            Console.WriteLine(Convert.ToInt64(myNum));
            Console.ReadKey();
            */

            /*//Demo 03 : const

            const double pi = 3.14159;
            double radius;
            double area;

            Console.WriteLine("Enter Radius : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = pi * radius * radius;

            Console.WriteLine("Radius : {0}, Area: {1}", radius, area);
            Console.ReadLine();

            */

            /*
            // Demo 04 : String Concatenation

            string result;

            string address = "23";
            address = address + ", Oxford Street";
            result = address + ", Thornbury";
            
            Console.WriteLine(result);
            Console.ReadKey();
            */

            /*
            // Demo 05 : Best Practise Concatenation
            // using System.Text;
            StringBuilder mySBRsult = new StringBuilder();
            mySBRsult.Append("23");
            mySBRsult.Append(", Oxford Street");
            mySBRsult.Append(", Thornbury");

            Console.WriteLine(mySBRsult);
            Console.ReadKey();
            */

            /*
            // Demo 06 : Declar Array

            // Declar Array
            int[] myEvenNumber1;
            string[] myCity1;

            // Declar Array & Initial 
            int[] myEvenNumber2 = new int[5] { 2, 4, 6, 8, 10 };
            string[] myCity2 = new string[5] { "London", "New York", "Bangkok", "Tokyo", "Liverpool" };

            // Declar Array using var
            var myEvenNumber3 = new int[] { 12, 14, 16, 18, 20, 22 };
            var myCity3 = new string[] { "Chicago", "Yokohama" };

            //short Systax
            int[] myEvenNumber4 = { 24, 26, 28, 30 };
            string[] myCity4 = { "Manchester", "Chonburi" }; 
            */

            /*    
            // Demo 07 - Array Loop For/For Each
            int[] myNum = new int[10];
            int i, j;

            // Intitail Element of Array
            for (i = 0; i < 10; i++) {
                myNum[i] = i + 100;
            }

            // Output-For
            for (j = 0; j < 10; j++) {
                Console.WriteLine("Element[{0}] = {1}", j, myNum[j]);
            }

            Console.WriteLine("---------------------");

            // Out-ForEach
            foreach (int y in myNum) {
                int x = y - 100;
                Console.WriteLine("Element[{0}] = {1}", x, y);
            }               

            Console.ReadKey();
            */

            /*
            // Demo0 8 - Dimesion Array

            int[,] myArray2D = new int[3, 2] {
                { 100, 200},
                { 300, 400},
                { 500, 600}
            };

            Console.WriteLine(myArray2D[0, 0]);
            Console.WriteLine(myArray2D[0, 1]);
            Console.WriteLine(myArray2D[1, 0]);
            Console.WriteLine(myArray2D[1, 1]);
            Console.WriteLine(myArray2D[2, 0]);
            Console.WriteLine(myArray2D[2, 1]);
            Console.ReadKey();
            */

            /*
            // Demo 09 - Jagged Array
            int[][] myJaggedArray = new int[2][] {
                new int[3] { 10, 20, 30},
                new int[5] { 40, 50, 60, 70 ,80}
            };

            Console.WriteLine(myJaggedArray[0][0]);
            Console.WriteLine(myJaggedArray[0][1]);
            Console.WriteLine(myJaggedArray[0][2]);

            Console.WriteLine(myJaggedArray[1][0]);
            Console.WriteLine(myJaggedArray[1][1]);
            Console.WriteLine(myJaggedArray[1][2]);
            Console.WriteLine(myJaggedArray[1][3]);
            Console.WriteLine(myJaggedArray[1][4]);

            Console.ReadKey();
            */

            /*
            // Demo 10 - Loop in Dimesion Array

            int[,] myArray = new int[5, 2] {
                {0, 0}, 
                {10, 20}, 
                {20, 40}, 
                {30, 60}, 
                {40, 80}
            };

            int i, j;

            for (i = 0; i < 5; i++) {
                for (j = 0; j < 2; j++) {
                    Console.WriteLine("myArray[{0}, {1}] = {2}", i, j, myArray[i, j]);
                }
            }
            Console.ReadKey();
            */

            /*
           // Demo 11 - Access in Dimesion Array
            int[][] m = new int[2][]
           {
                new int[2]{1,2 },
                new int[5]{3,4,5,6,7 }
           };


            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.WriteLine(m[i][j]);
                }
            }
            */

            /*
            //Demo 12 - Array Class
            int[] mylist = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int[] mytemp = mylist;
            int[] myOrder = { 10, 50, 70, 100, 20, 30 };

            Console.Write("Original Array: ");
            foreach (int i in mylist) {
                Console.WriteLine(i + " ");
            }

            // Array Class - Reverse Method
            Array.Reverse(mytemp);

            Console.Write("Reverse Array: ");
            foreach (int i in mytemp) {
                Console.WriteLine(i + " ");
            }

            // Array Class - Sort Array
            Array.Sort(myOrder);
            
            Console.WriteLine("Sorted Array: ");
            foreach (int i in myOrder)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadKey();
           */

            /*
            //Demo 13 - Array Class - Decision Statment
            int myNumber = 100;

            if (myNumber < 1000)
            {
                Console.WriteLine("Low Order");
            }
            else {
                Console.WriteLine("High Order");
            }

            Console.WriteLine("Value is : {0}", myNumber);
            Console.ReadKey();
            */

            /*
            //Demo 14 - Ternary Operator
            string carColor = "green";

            string response = (carColor == "red") ?
                "You have a red car" :
                "You do not have a red car";

            Console.WriteLine(response);
            Console.ReadKey();
            */

            /*
            //Demo 15 - Nested IF
            int myNumCondition1 = 1000;
            int myNumCondition2 = 2000;

            if (myNumCondition1 < 1500) {
                if (myNumCondition2 == 2000) {
                    Console.WriteLine("Complted.");
                }            
            }
            Console.ReadKey();
            */

            /*
            //Demo 16 - Switch
            char myGrade = 'B';

            switch (myGrade) {
                case 'A':
                    Console.WriteLine("Very Good.");
                    break;
                case 'B':
                    Console.WriteLine("Good.");
                    break;
                case 'C':
                    Console.WriteLine("Fair.");
                    break;
                case 'D':
                    Console.WriteLine("Not Good.");
                    break;
                default:
                    Console.WriteLine("Go to hell.");
                    break;
            }

            Console.WriteLine("My Grade is {0}", myGrade);
            Console.ReadKey();
           */

            /*
            //Demo 17 - While Loop

            int myInt = 15;

            while (myInt < 20) {
                Console.WriteLine("Value is : {0}", myInt);
                myInt++;
            }

            Console.ReadKey();
            */

            /*
            //Demo 18 - DO Loop

            int myInt = 15;

            do
            {
                Console.WriteLine("Value is : {0}", myInt);
                myInt++;
            } while (myInt < 20); {
                Console.ReadKey();
            }
            */
        }
    }
}
