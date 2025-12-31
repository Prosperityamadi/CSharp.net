// arrays- collections of fixed set of values

using System;

class Program
{
    static void Main()
    {
        // Declare and initialize an array of integers
        int[] numbers = new int[5]; // Array to hold 5 integers

        // Assign values to the array
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Access and print values from the array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }

        // Alternatively, you can initialize an array with values directly
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Print the fruits array
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }
    }
}