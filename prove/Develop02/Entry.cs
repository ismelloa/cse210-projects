using System;

namespace JournalApp
{
    public class Entry
    {
        private string _prompt;
        private string _response;
        private DateTime _date;

        public Entry(string prompt, string response)
        {
            _prompt = prompt;
            _response = response;
            _date = DateTime.Now;
        }

        public Entry(string prompt, string response, DateTime date)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public string GetResponse()
        {
            return _response;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public override string ToString()
        {
            return $"{_date.ToShortDateString()} - {_prompt}\n{_response}";
        }
    }
}
