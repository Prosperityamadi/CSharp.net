using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty");
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
            } do
            {
                Console.WriteLine($"Hello, {name}!");
            } while (false);
        }
    }
}