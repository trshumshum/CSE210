using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is prep5 assignment by John S.");
        
        DisplayWelcome();
        string UserNameString = PromptUserName();
        int FavNumberInt = PromptUserNumber();
        int YearBornInt = PromptYearBorn();
        int AgeThisYear = DateTime.Now.Year - YearBornInt;
        int SquareRootInt = SquareNumber(FavNumberInt);
        DisplayResult(UserNameString, AgeThisYear, SquareRootInt);

    }

    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string input = Console.ReadLine();
        return input;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string InputString = Console.ReadLine();
        int input = int.Parse(InputString);
        return input;
    }

    static int PromptYearBorn()
    {
        Console.Write("Please enter the year you were born: ");
        string InputString = Console.ReadLine();
        int input = int.Parse(InputString);
        return input;
    }


    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int FavNumber)
    {
        int input = FavNumber * FavNumber;
        return input;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string Name, int YearBorn, int SquaredNumber)
    {
        Console.WriteLine($"{Name}, the square of your number is: {SquaredNumber}");
        Console.Write($"{Name}, you will turn {YearBorn} this year.");

    }
}