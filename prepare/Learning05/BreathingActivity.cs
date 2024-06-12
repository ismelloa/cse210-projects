using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private string[] _breathingInstructions = { "Breathe in...", "Breathe out..." };

    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void RunActivity()
    {
        StartMessage();

        int interval = _duration / 2;
        for (int i = 0; i < interval; i++)
        {
            foreach (var instruction in _breathingInstructions)
            {
                Console.WriteLine(instruction);
                PauseWithAnimation(3);
            }
        }

        EndMessage();
    }
}
