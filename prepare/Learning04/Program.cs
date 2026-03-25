// ++++++++++++++       MAIN       ++++++++++++++
// ++++++++++++   Different Kinds of Homework Assignments   ++++++++++++
// Learning 04 by - John S.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Learning04 by John S.");

        // Create a Math assignment
        MathAssignment math = new MathAssignment("John S.", "Fractions", "7.3", "18-19");

        // Create a Writing assignment
        WritingAssignment writing = new WritingAssignment("John S.", "European History", "The Causes of World War II");

        // Display results
        Console.WriteLine("Math Assignment:");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        Console.WriteLine("Writing Assignment:");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

    }
}