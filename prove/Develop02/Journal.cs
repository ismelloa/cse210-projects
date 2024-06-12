using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry);
                Console.WriteLine();
            }
        }

        public void SaveToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Entry entry in _entries)
                    {
                        writer.WriteLine($"{entry.GetDate()}\t{entry.GetPrompt()}\t{entry.GetResponse()}");
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving journal: {ex.Message}");
            }
        }

        public void LoadFromFile(string filePath)
        {
            try
            {
                _entries.Clear();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length == 3)
                        {
                            DateTime date = DateTime.Parse(parts[0]);
                            string prompt = parts[1];
                            string response = parts[2];
                            Entry entry = new Entry(prompt, response, date);
                            _entries.Add(entry);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}");
            }
        }
    }
}
