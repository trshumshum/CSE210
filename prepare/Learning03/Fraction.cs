// ++++++++++++++   FRACTION CLASS   ++++++++++++++
// Learning 03 Project - John S.

using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
//Public attributes

//Private Attributes
    private int _top;
    private int _bottom;

//Constructors (automatically used when initializing state or new object (Use NEW)) i.e. Fraction frac1 new Fraction()
    public Fraction() //blank constructor
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int Wholenumber) //whole number constructor
    {
        _top = Wholenumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) 
    {
        _top = top;
        _bottom = bottom;
    }

//Methods
    //get 
    public int GetTop()
    {
        return _top;  
    }
    
    public int GetBottom()
    {
        return _bottom;  
    }

    //set
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }



    public string GetFractionString() //returns the fraction in the form 3/4. (string)
    {
        string s_frac = $"{_top}/{_bottom}";
        return s_frac;
    }

    public double GetDecimalValue()
    //returns a double that is the result of dividing the top number by the bottom number, such as 0.75
    {
        double d_frac = (double)_top / (double)_bottom; //will get zero if don't specify (double)
        return d_frac;
    }
}