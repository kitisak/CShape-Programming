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

    public class DayCollection {
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        private int FindDay(string day) {
            for (int j = 0; j < days.Length; j++) {
                if (days[j] == day) {
                    return j;
                }
            }
            throw new ArgumentOutOfRangeException(nameof(day), $"Day {day} is not support.");
        } 

        public int this[string day] => FindDay(day);
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Demo 01 - Indexers
            var tempRecord = new TempRecord();

            tempRecord[3] = 45.5F;
            tempRecord[4] = 55.3F;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Element #{i} = {tempRecord[i]}");
            }

            Console.WriteLine("Complete.");
            Console.ReadKey();
            */

            // Demo 02 - Indexers call method
            var week = new DayCollection();
            Console.WriteLine(week["Friday"]);

            try
            {
                Console.WriteLine(week["Wroking Day"]);
            } catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
