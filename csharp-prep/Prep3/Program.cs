using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guessNumber = 0;
        
        while (guessNumber != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guessNumber = int.Parse(Console.ReadLine());

            //or use like this
            // string userInput1 = Console.ReadLine();
            // guessNumber = int.Parse(userInput1);
            
         
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            
            else if (guessNumber < magicNumber)
            {
            Console.WriteLine("higher");  
            }
            
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
                   
    }
}