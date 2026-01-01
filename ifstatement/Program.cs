using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please what is your name?");
            string name = Console.ReadLine();

            if(name == null || name.Trim() == "")
            {
                Console.WriteLine("please enter a valid name");
            }
            else
            {
                Console.WriteLine($"Hello, {name}!");
            }
            Console.ReadKey();
        }
    }
}
