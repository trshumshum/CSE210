using System;
using System.Diagnostics.Contracts;


// ++++++++++++++   RESUME CLASS   ++++++++++++++
public class Resume
{
    public string _Name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine("Jobs:");

        foreach (Job x in _jobs)
        {
            x.Display();
        }
    }
    
}