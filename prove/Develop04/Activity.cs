// ++++++++++++++       Parent Class - Activity      ++++++++++++++
// ++++++++++++   Mindfulness Program    ++++++++++++
// Prove 04 - John S.
// Common Starting Message, gather time / count down, ending message

using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_name} activity for {_duration} seconds.");
        ShowSpinner(4);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinnerChars = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinnerChars[counter % spinnerChars.Length]}  ");
            Thread.Sleep(250);
            counter++;
        }
        Console.Write("\r     \r"); // Clear spinner
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}   ");
            Thread.Sleep(1000);
        }
        Console.Write("\r     \r"); // Clear
    }
}
