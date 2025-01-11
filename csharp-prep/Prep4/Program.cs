// John Shumway - W02 Learning Prep4
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //define variables
        List<int> numbers = new List<int>();
        int input;
        bool keepAskingForNumbers = true;

        //--------------START--------------
        while (keepAskingForNumbers)
        {
            //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0
            Console.Write("Enter a number (enter 0 to stop): ");
            input = int.Parse(Console.ReadLine());
                if (input != 0)
                {
                    numbers.Add(input);
                }
                else
                {
                    keepAskingForNumbers = false;
                }
        }
        //Start Calculations and printing information
        int numbercount = numbers.Count;
        if (numbercount == 0)
        {
            Console.WriteLine("You didn't enter any numbers. \nHave a nice day. \nPress any key to ext.");
            Console.ReadKey(); //just to wait for any key press to exit
            Environment.Exit(0); //exit program
        }

        Console.WriteLine($"you entered {numbercount} sets of numbers. \nHere are some calculation on those numbers:");

        // for loop to cycle through the list and perform calculations

        //Compute the sum, or total, of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The Sum is: {sum}");
        
        //Compute the average of the numbers in the list.
        double average = sum / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        //Find the maximum, or largest, number in the list.
        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The Largest number is: {max}");
        
        
    }
}