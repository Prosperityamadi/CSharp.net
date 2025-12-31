using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name:");
        String name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}!");

        Console.WriteLine("Please enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"You are {age} years old.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}