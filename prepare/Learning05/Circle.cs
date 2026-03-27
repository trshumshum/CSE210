// ++++++++++++++       Child Class - Circle Shape     ++++++++++++++
// ++++++++++++   Shape Program    ++++++++++++
// PURPOSE: Return area of a circle (A = Pi R squared)
// Learning05 - John S.

using System;
namespace Learning05
{
    public class Circle : Shape
    {
// VARIABLES
        private double _CRadius =0;

// CONSTRUCTORS
        public Circle(string color, double radius)
        {
            _CRadius = radius;
            SetColor(color);
        }

// GET
        public double GetRadius()
        {
            return _CRadius;
        }

        public override double GetArea() //overide parent
        {
            return Math.PI * Math.Pow(_CRadius,2);
        }
// SET
        public void SetRadius(double radius)
        {
            _CRadius = radius;
        }

    
    }



}

