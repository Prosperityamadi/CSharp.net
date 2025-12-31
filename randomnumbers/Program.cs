using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Random random = new Random();
            int randomNumber = random.Next(1,10);

            Console.WriteLine("Enter a number between 1 and 10:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }else
            {
                Console.WriteLine($"Sorry, the correct number was {randomNumber}. Better luck next time!");
            }
            Console.ReadKey();
        }
    }
}