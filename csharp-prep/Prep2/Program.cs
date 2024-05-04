using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // Variable to store letter grade
        string letter = "";

        // Determine letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Variable to store grade sign
        string sign = "";

        // Determine grade sign
        if (gradePercentage >= 60 && gradePercentage <= 100)
        {
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handling exceptional cases
        if (letter == "A" && sign == "+")
        {
            letter = "A";
            sign = "";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }

        // Print the letter grade and sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Congratulatory or encouraging messages based on the grade
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass this time, but keep trying!");
        }
    }
}
