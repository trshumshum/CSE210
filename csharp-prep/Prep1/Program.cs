using System;

class Program
{
    static void Main(string[] args)
    {
        //John S
        Console.WriteLine("This is the Prep1 Assignment.");

        //get first name 
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        //get last name 
        Console.Write("What is your last name: ");
        string last_name = Console.ReadLine();

        //display name in james bond style :)
        Console.WriteLine($"your name is {last_name}, {first_name} {last_name}.");

        
    }
}