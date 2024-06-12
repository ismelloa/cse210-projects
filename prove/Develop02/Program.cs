using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            Prompt promptGenerator = new Prompt();

            while (true)
            {
                Console.WriteLine("1. Write a journal entry");
                Console.WriteLine("2. Display all journal entries");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine(prompt);
                        string response = Console.ReadLine();
                        journal.AddEntry(new Entry(prompt, response));
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.Write("Enter the file name to save the journal: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        Console.WriteLine($"Journal saved to {saveFileName}");
                        break;
                    case "4":
                        Console.Write("Enter the file name to load the journal: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName);
                        Console.WriteLine($"Journal loaded from {loadFileName}");
                        Console.WriteLine();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
