using System;

public class Program
{
    public static void Main()
    {
        Application app = new Application();
        app.DisplayMenu();
    }
}

public class Application
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunActivity();
                    break;
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.RunActivity();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.RunActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
