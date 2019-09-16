using System;
using System.IO;

namespace IO_Filhantering
{
    class Program
    {
        static void writeFile(string filename)
        {
            File.WriteAllText(filename, "Hello world");
        }

        static void readFile(string filename)
        {
            Console.WriteLine(File.ReadAllText(filename));
        }
        static void Main(string[] args)
        {
            string filename = @"C:\Users\eliagrun\Desktop\Programering\Git\IO Filhantering\io.txt";
            writeFile(filename);
            readFile(filename);
        }
    }
}
