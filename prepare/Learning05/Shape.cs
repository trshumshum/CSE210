// ++++++++++++++       Parent Class - All Shapes    ++++++++++++++
// ++++++++++++   Shape Program    ++++++++++++
// PURPOSE: store/get/set color + virtual area method for child classes
// Learning05 - John S.

using System;
namespace Learning05
{

    public class Shape
    {
//VARIABLES:
        protected string _color ="No Color Defined";
        protected double _area = 0;

//get + set
        public string GetColor()
        {
            return _color;
        }

        public virtual void SetColor(string color)
        {
            _color = color;
        }

        public virtual double GetArea()
        {
            return 0; //will use child class calculations
        }
    }


}



