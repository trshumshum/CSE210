using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Prep 4 Assignment by John S.");

         //Create list
        List<int> NumberList = new List<int>();

        Console.WriteLine("Please provide a series of numbers. When you want to stop type the number 0.");

        bool Continue = true;
        while (Continue)
        {
            Console.Write("Enter A Number: ");
            string InputString = Console.ReadLine();
            int InputInt = int.Parse(InputString);

            if (InputInt != 0)
            {
                //Console.WriteLine($"Thank you! I have added {InputInt} to the list.");
                //Console.WriteLine("Lets add another. hint: type the number 0 if you want to stop.");
                NumberList.Add(InputInt);
            }
            else
            {
                //Console.WriteLine($"Thank you! you typed {InputInt} indicating you want to stop adding numbers.");
                Continue = false;
            }
        }

        Console.WriteLine("Here is some info about all those numbers (not including the 0 you just typed to quit)");

        //sum
        int Sum = NumberList.Sum();
        Console.WriteLine($"Sum = {Sum} ");

        //average
        double Average = NumberList.Average();
        Console.WriteLine("Average = " + Average); //trying the + variable instead of $ method

        //max
        int Max = NumberList.Max();
        Console.WriteLine($"Max = {Max} ");

    }
}