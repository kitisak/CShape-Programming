using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream myFile = new FileStream("testdata.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    myFile.WriteByte((byte)i);
                }

                myFile.Position = 0;
                for (int i = 0; i <= 10; i++)
                {
                    Console.Write(myFile.ReadByte() + " ");
                }
            }
            catch (IOException ex)
            {
                Console.Write(ex.Message);
            }
            finally {
                myFile.Close();
                Console.ReadKey();
            }           
        }
    }
}