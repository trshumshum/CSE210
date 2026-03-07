using System;

class Program
{
    static void Main(string[] args)
    {
        //Using 2 Class files:
        //Journal.cs manages the journal functions
        //Entry.cs will work with writing reading storing etc.
        Console.WriteLine("Develop 2 assignment by John S.");
        Console.WriteLine("Welcome to the Journal program by John S.");
        
        //pre-populate empty journal list
        Journal journal = new Journal();
        
        //loop to run until someone selects 5 (quit)
        string choice = ""; 
        while (choice != "5")
        {   
            //display the menu
            Console.WriteLine("Please select from the choices by typing in the number you want.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load txt file");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            //read the input add option if they fat finger the number
            choice = Console.ReadLine();
            Console.WriteLine(); //for spacing

            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Enter file name to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter file name to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1-5.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}