// John Shumway - W01 Prove Prep1
using System;

class Program

{
    static void Main(string[] args)
    {
        //get first name and last name from user
        Console.WriteLine("What is your first name?");
        string f_name = Console.ReadLine();
        
        Console.WriteLine("what is your last name?:");
        string l_name = Console.ReadLine();

        // print out the James Bond Thingy
        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}.");
    }
}


