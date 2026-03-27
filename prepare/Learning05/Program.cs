// ++++++++++++++   MAIN   ++++++++++++++
//  ++++++++++++   SHAPE PROGRAM   ++++++++++++
// Learning 05 - John S.

using System;
namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning05 assignment by John S.");

            // Rectangle Rec1 = new Rectangle();
            // Rec1.SetColor("orange");
            // Rec1.SetLength(4);
            // Rec1.SetWidth(2);
            // Console.WriteLine($"The {Rec1.GetColor()} shape has an Area of {Rec1.GetArea()}");

//create 1 of each shapes

            Rectangle Rec1 = new Rectangle("Orange",4,2);        
            // Console.WriteLine($"The {Rec1.GetColor()} shape has an Area of {Rec1.GetArea()}");

            Square Square1 = new Square("Blue",4);
            // Console.WriteLine($"The {Square1.GetColor()} shape has an Area of {Square1.GetArea()}");
        
            Circle Circle1 = new Circle("Green", 4);
            // Console.WriteLine($"The {Circle1.GetColor()} shape has an Area of {Circle1.GetArea()}");

// create a list
            List<Shape> ShapeList = new List<Shape>();

// add shapes to list
            ShapeList.Add(Rec1);
            ShapeList.Add(Square1);
            ShapeList.Add(Circle1);

// for loop to print out each shape reguardless of what child class since all belong to parent class
            foreach (Shape x in ShapeList)
            {
                Console.WriteLine($"The {x.GetColor()} shape has an Area of {x.GetArea()}");
            }

        }
    }
}

