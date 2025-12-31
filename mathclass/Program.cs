using System;
using System.IO.Pipelines;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 5;

            double result = Math.Pow(num, 3);
            Console.WriteLine($"The cube of {num} is {result}");  

            Console.ReadKey();
        }
    }
}