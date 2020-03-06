using System;
using System.Collections.Generic;
using System.Text;

namespace Concepts
{
    class Geometry
    {
        //TODO Add a check, so the user cannot input anything equal to or less than 0, as that is impossible with this theorem
        public double PythagoreanTheorem(double x, double y) //Represents the Pythagorean Theorem (A^2 + B^2 = C^2) 
        {
            double z = Algebra.Addition(Math.Pow(x, 2), Math.Pow(y, 2));
            return Math.Sqrt(z); //returns the square root of z, rather than z^2 that the function would otherwise produce
        }
    }
}
