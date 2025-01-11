// John Shumway - W01 Prove Prep2
using System;
using System.Runtime.CompilerServices;

class Program

{
    static void Main(string[] args)
    {
        //get grade percentage
        Console.Write("What percentage did you recive in the class? (for example 75): ");
        string GradeString = Console.ReadLine();
        int GradeInt = int.Parse(GradeString);
        string LetterGradeString = "";
        bool passed = false;
        
        // if statements to determine grade and pass/fail status
        if (GradeInt >= 90)
            {
            passed = true;
            if (GradeInt >= 97)
                {
                    LetterGradeString = "A+";
                }
            else if (GradeInt <= 93)
                {
                    LetterGradeString = "A-";
                }
            else
                {
                    LetterGradeString = "A";
                } 
            }

        else if (GradeInt >= 80)
            {
            passed = true;
            if (GradeInt >= 87)
                {
                    LetterGradeString = "B+";
                }
            else if (GradeInt <= 83)
                {
                    LetterGradeString = "B-";
                }
            else
                {
                    LetterGradeString = "B";
                } 
            }

        else if (GradeInt >= 70)
            {
            passed = true;
            if (GradeInt >= 77)
                {
                    LetterGradeString = "C+";
                }
            else if (GradeInt <= 73)
                {
                    LetterGradeString = "C-";
                }
            else
                {
                    LetterGradeString = "C";
                } 
            }

        else if (GradeInt >= 60)
            {
            passed = false;
            if (GradeInt >= 67)
                {
                    LetterGradeString = "D+";
                }
            else if (GradeInt <= 63)
                {
                    LetterGradeString = "D-";
                }
            else
                {
                    LetterGradeString = "D";
                } 
            }

        else
            {
            passed = false;
            LetterGradeString = "F";
            }

        // Print Grade
        Console.WriteLine($"Your grade for the class is: {LetterGradeString}");
        if (passed)
        {
            Console.WriteLine("Congratulations you Passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass. You need to score at least a 70.");
            Console.WriteLine("don't give up. You can do this!");
        }
    }
}