using System;
using System.IO;

namespace Module8Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSize test = new FileSize();

            Console.WriteLine($"Общий размр папки: {test.FileSizeCount("C:/Users/Анатолий/Desktop/testFolder")}");
        }
    }
}

