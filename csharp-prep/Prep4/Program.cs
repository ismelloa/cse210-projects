using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        while (userNumber != 0)
        {
            numbers.Add(userNumber);
            userNumber = int.Parse(Console.ReadLine());
            
        }

        Console.WriteLine("Here is the list: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " "); // Print each number in the list
        }

        // Compute the sum of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("\nSum: " + sum);

        // Compute the average of the numbers in the list
        double average = (double)sum / numbers.Count;
        Console.WriteLine("Average: " + average);

        // Find the maximum number in the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine("Maximum number: " + max);
    }
}
