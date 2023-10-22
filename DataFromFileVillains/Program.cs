using System;
using System.IO;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users//projects/villains.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);

            foreach (string element in dataFromFile)
            {
                Console.WriteLine(element);
            }
        }
    }
}