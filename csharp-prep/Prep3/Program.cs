using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guessNumber = -1;
        int numberOfGuesses = 0;
              
        while (guessNumber != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guessNumber = int.Parse(Console.ReadLine());
            numberOfGuesses++;
                  
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");  
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
        Console.WriteLine($"Number of guesses: {numberOfGuesses}");
    }
}
