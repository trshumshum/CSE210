using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //populate entries list
    private List<Entry> _entries = new List<Entry>(); //populate entries list
    
    //populate prompts
    private List<string> _prompts = new List<string> //populate prompts
    {
        "What was the best part of my day was:",
        "Who did I help today?",
        "What did I learn today?",
        "What made me smile today?",
        "What is something I want to remember from today?",
        "If I could pick one thing to do over today what would it be?"

    };

    // Option 1 - WRITE
    public void WriteEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(date, prompt, response);
        _entries.Add(newEntry);

        Console.WriteLine("Entry added.");
    }

    //Option 2 - Display
    public void DisplayJournal()
    {
        if (_entries.Count == 0) //logic test to verify entries not empty before attempting to display
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    //Option 4 - Save
    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.ToFileFormat());
                }
            }

            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    //Option 3 - Load
    public void LoadFromFile(string fileName)
    {
        try
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _entries.Clear();

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Entry entry = Entry.FromFileFormat(line);

                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}