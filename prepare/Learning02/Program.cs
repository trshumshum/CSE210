using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Learning02 assignment by John S.");

        Job job1 = new Job();
        job1._Company = "Microsoft";
        job1._JobTitle = "Software Dev1";
        job1._StartYear = 2001;
        job1._EndYear = 2004;

        Job job2 = new Job();
        job2._Company = "Apple";
        job2._JobTitle = "Manager";
        job2._StartYear = 2004;
        job2._EndYear = 2010;

        // Console.WriteLine($"{job1._JobTitle} ({job1._Company}) {job1._StartYear}-{job1._EndYear}");

        //job1.Display();
        //job2.Display();

        Resume johnresume = new Resume();
        johnresume._Name = "John S.";
        johnresume._jobs.Add(job1);
        johnresume._jobs.Add(job2);

        johnresume.Display();

    }
}