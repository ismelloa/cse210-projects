using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class Prompt
    {
        private List<string> _prompts;

        public Prompt()
        {
            _prompts = new List<string>
            {
                "What are you grateful for today?",
                "Describe a memorable event from your day.",
                "What are your goals for tomorrow?",
                "How did you feel today and why?",
                "What did you learn today?"
            };
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}
