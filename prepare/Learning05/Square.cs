// ++++++++++++++       Child Class - Square Shape     ++++++++++++++
// ++++++++++++   Shape Program    ++++++++++++
// PURPOSE: Return area of a Square (A = a squared)
// Learning05 - John S.

using System;
using System.Security.Cryptography.X509Certificates;
namespace Learning05
{
    public class Square : Shape
    {
// VARIABLES
        private double _SSide =0;

// CONSTRUCTORS
        public Square(string color, double side) 
        {
            _SSide = side;
            SetColor(color);
        }


// METHODS



// GET
        public double GetSide()
        {
            return _SSide;
        }

        public override double GetArea() //overide parent
        {
            return _SSide*_SSide;
        }

// SET
        public void SetSide(double side)
        {
            _SSide = side;
        }

    
    }



}

