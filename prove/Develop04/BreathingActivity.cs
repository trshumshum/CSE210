// ++++++++++++++       Child Class - BreathingActivity      ++++++++++++++
// ++++++++++++   Mindfulness Program    ++++++++++++
// Prove 04 - John S.

using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        bool isBreatheIn = true;

        while (DateTime.Now < endTime)
        {
            int timeRemaining = (int)(endTime - DateTime.Now).TotalSeconds;
            if (timeRemaining <= 0) break;

            if (isBreatheIn)
                Console.WriteLine("Breathe in...");
            else
                Console.WriteLine("Breathe out...");

            int pauseSeconds = Math.Min(5, timeRemaining);
            ShowCountdown(pauseSeconds);

            isBreatheIn = !isBreatheIn;
        }

        DisplayEndingMessage();
    }
}