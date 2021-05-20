using System;

namespace Indexer
{
    public class TempRecord
    {
        // Field - Array (Collection)
        float[] temps = new float[5] { 10.5F, 20.5F, 30.5F, 40.5F, 50.5F };

        // => คือ Lambda Expression (inputparameter) => (Expression)
        public int Length => temps.Length;

        // Indexer ทำหน้า get/set ค่าใช้ตัวแปรในคลาส ที่เป็น Collection Class จะเป็นการใช้ index 
        // Indexer จะชื่อ this
        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
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
