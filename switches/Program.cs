using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // switches are effective for handling multiple discrete values
            Console.WriteLine("What day is it today?");
            string? day = DateTime.Now.DayOfWeek.ToString();
            day = Console.ReadLine();

            switch (day)
            {
                case ("monday"):
                    Console.WriteLine("It's Monday!");
                    break;
                case ("tuesday"):
                    Console.WriteLine("It's Tuesday!");
                    break;
                case ("wednesday"):
                    Console.WriteLine("It's Wednesday!");
                    break;
                case ("thursday"):
                    Console.WriteLine("It's Thursday!");
                    break;
                case ("friday"):
                    Console.WriteLine("It's Friday!");
                    break;
                case ("saturday"):
                    Console.WriteLine("It's Saturday!");
                    break;
                case ("sunday"):
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine("Hmm, that doesn't seem to be a valid day.");
                    break;
            }
            Console.WriteLine("Have a great day!");
        }
    }
}