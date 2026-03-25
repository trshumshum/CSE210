// ++++++++++++++       Child Class - ListingActivity      ++++++++++++++
// ++++++++++++   Mindfulness Program    ++++++++++++
// Prove 04 - John S.


using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("\nList as many responses as you can for the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou have a few moments to think about it.");
        ShowCountdown(8);

        Console.WriteLine("\nStart listing items. Enter one item per line and press Enter.");
        Console.WriteLine("The activity will end when time is up.\n");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }
}