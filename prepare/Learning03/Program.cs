using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Learning 03 Project by John S.");
//testing with the differnet contructors
        Fraction f_empty = new Fraction();
        Console.WriteLine(f_empty.GetFractionString());
        Console.WriteLine(f_empty.GetDecimalValue());
        //frac_empty.SetTop(2);
        //frac_empty.SetBottom(3);
        //Console.WriteLine(frac_empty.GetFractionString());
        //Console.WriteLine(frac_empty.GetDecimalValue());
    
        Fraction f_whole = new Fraction(6);
        Console.WriteLine(f_whole.GetFractionString());
        Console.WriteLine(f_whole.GetDecimalValue());

        Fraction f_full = new Fraction(6, 7);
        Console.WriteLine(f_full.GetFractionString());
        Console.WriteLine(f_full.GetDecimalValue());


// loop for 20 times to test random fractions
        Fraction f_rando = new Fraction(); // initialize 1/1 fraction object for loop
        Random WillyNilly = new Random(); // initialize random object for loop

        for (int i = 1; i < 21; i++)
        {
            f_rando.SetTop(WillyNilly.Next(1,11));  //set top to random number 1-10
            f_rando.SetBottom(WillyNilly.Next(1,11)); //set bottom to random number 1-10
            Console.WriteLine($"Fraction # {i}: ");
            Console.WriteLine($"  String: {f_rando.GetFractionString()}");
            Console.WriteLine($"  Number: {f_rando.GetDecimalValue()}");
        }

        
    }
}