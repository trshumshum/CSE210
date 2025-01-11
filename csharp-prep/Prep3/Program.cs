// John Shumway - W02 Prove Prep3
using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); //changed to 101 after looking at sample solution

        //Variables
        int guessCount = 0; 
        int guess;
        bool keepGuessing = true;
        
        //Start guessing game
        Console.WriteLine("The magic number is between 1 and 100.");
        
        
        // Begin guessing loop
        while(keepGuessing)
        {
            guessCount++; //increment 
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess == numberToGuess)
            {
                Console.WriteLine($"Congratulations! You've guessed it right! It took you {guessCount} attempts.");
                break; //exit the loop and program
            }
            else if (guess < numberToGuess)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
        
    }
}