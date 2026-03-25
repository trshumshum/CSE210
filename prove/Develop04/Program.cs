// ++++++++++++++       MAIN       ++++++++++++++
// ++++++++++++   Mindfulness Program    ++++++++++++
// Prove 04 - John S.

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prove 04 - Mindfulness Program by John S.");
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true) //menu loop and pick until quit
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
            {
                activity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                activity = new ReflectionActivity();
            }
            else if (choice == "3")
            {
                activity = new ListingActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Thread.Sleep(2000);
                continue;
            }

            if (activity != null)
            {
                // Call the method
                if (activity is BreathingActivity breathing)
                    breathing.Run();
                else if (activity is ReflectionActivity reflection)
                    reflection.Run();
                else if (activity is ListingActivity listing)
                    listing.Run();
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}