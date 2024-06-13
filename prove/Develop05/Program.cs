using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        // for (int i = 5; i>0; i--)
        // {
        //     Console.WriteLine(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
        // |/-\|/-\|

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.WriteLine(s);
            Thread.Sleep(3000);
            Console.Write("\b \b");

            i++;
            
            if(i >= animationStrings.Count)
            {
                i = 0;
            }
        }        
         
      
        Console.WriteLine("Done");
    }
}