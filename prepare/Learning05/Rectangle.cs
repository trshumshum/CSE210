// ++++++++++++++       Child Class - Rectangle Shape     ++++++++++++++
// ++++++++++++   Shape Program    ++++++++++++
// PURPOSE: Return area of a rectangle  (A = WL)
// Learning05 - John S.

using System;
// using System.Dynamic;
namespace Learning05
{
    public class Rectangle : Shape
    {
//VARIABLES
        private double _RArea =0;
        private double _RWidth =0;
        private double _RLength =0;

//constructors (making multiple constructors only on Rectangle shape)
        public Rectangle() //empty
        {}  
        public Rectangle(double width, double length)
        {
            _RWidth = width;
            _RLength = length;
        }
        public Rectangle(string color, double width, double length)
        {
            _RWidth = width;
            _RLength = length;
            SetColor(color); //pointing to parent class
        } 

//SET
        public void SetWidth(double width)
        {
            _RWidth = width;
        }

        public void SetLength(double length)
        {
            _RLength = length;
        }

        // public new void SetColor(string color)
        // {}

//GET
        public double GetWidth()
        {
            return _RWidth;
        }

        public double GetLenght()
        {
            return _RLength;
        }

        public override double GetArea()
        {
            _RArea = _RLength*_RWidth;
            return _RArea;
        }
        
    }



}