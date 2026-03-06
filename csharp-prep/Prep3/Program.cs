using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 3 Assignment by John S.");

        Console.WriteLine("Welcome to the Guessing Game!");

        // create a random number between 1 and 100
        Random RandomMagicNumber = new Random();
        int MagicNumber = RandomMagicNumber.Next(1, 101);

        Console.WriteLine("Try and guess the magic number between 1 and 100:");
        int guess = 0;

        while (guess != MagicNumber)
        {
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess < MagicNumber) Console.WriteLine("Sorry try again.. Hint: Guess higher.");
            else if (guess > MagicNumber) Console.WriteLine("Sorry try again.. Hint: Guess lower.");
            else Console.WriteLine($"You got it! The magic number was: {MagicNumber}. ");
        }
        
        Console.WriteLine("Thanks for playing! Goodbye.");


    }
}