using System;
using System.Collections.Generic;
using System.Text;

namespace Concepts
{

    //Algebra class is used to represent various concepts important to Algebraic functions.
    //This class will not utilize functions written in text-form

    class Algebra
    {
        public double Addition(double x, double y) //Basic addition function to combine two separate numbers, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x + y;
            return z;
        }

        public double Subtraction(double x, double y) //Basic subtraction function to subtract one number from another, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x - y;
            return z;
        }

        public double Multiplication(double x, double y) // Basic multiplication function to multiply two number together, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x * y;
            return z;
        }

        public double Division(double x, double y)//Basic division function to divide one number by another, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x / y; 
            return z;
        }



    }
}
