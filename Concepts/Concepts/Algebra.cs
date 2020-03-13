using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Concepts
{

    //Algebra class is used to represent various concepts important to Algebraic functions.
    //This class will not utilize functions written in text-form

    //The class is static so that any other class can easily utilize the functions within

    static class Algebra
    {
        public static double Addition(double x, double y) //Basic addition function to combine two separate numbers, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x + y;
            return z;
        }

        public static double Subtraction(double x, double y) //Basic subtraction function to subtract one number from another, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x - y;
            return z;
        }

        public static double Multiplication(double x, double y) // Basic multiplication function to multiply two number together, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x * y;
            return z;
        }

        public static double Division(double x, double y)//Basic division function to divide one number by another, and return them as a decimal up to 15 places (Due to the nature of a double)
        {
            double z = x / y; 
            return z;
        }

        public static double Abs(double x) //function to return the Absolute value of a double
        {
            if (x < 0)
            {
                return -x; //If the number is negative, returning the negative version will return a positive value
            }
            else
            {
                return x; //If the number is positive, we can return the number unaltered
            }
        }

        public static bool IsDivisible(int x, int y) //function to determine if an integer is divisible by another
        {
            if (y == 0)
            {
                Console.WriteLine("Hey! Nothing is divisible by 0!");
                return false;
            }
            else
            {
                if (x % y == 0)
                {
                    return true; //only return true if their is no remainder left when dividing two numbers
                }
                else
                {
                    return false; //else return false
                }

            }
        }

        public static bool IsPrime(int x) //function to determine if an integer is Prime or Composite
        {
            if (x <= 1)
            {
                Console.WriteLine("Negative numbers, as well as the numbers 1 and 0 are not considered Prime by the average definition");
                Console.WriteLine("A Prime number is a whole number greater than 1 whose only factors are 1 and itself");
                return false;
            }
            for (int i = 2; i < x; i++) //Iterate through all numbers between 2 and the number provided, but not including the number provided, as all numbers are divisible by themselves and by 1 
            {
                if (x % i == 0)
                {
                    return false; //Only return false if there exists some integer that results in having no remainder 
                }
            }

            return true;
        }

        //TODO Iterate through all ints less than x and if it divides x, add it into the List, output to the screen all values within the List, return the list for use in GCF function
        //TODO Add negative number integration
        public static List<int> FactorList(int x)
        {
            List<int> NewList = new List<int>();

            for (int i = 0; i <= x; i++)
            {
                if (IsDivisible(x, i))
                {
                    NewList.Add(i);
                }
            }
            foreach (var obj in NewList)
            {
                Console.WriteLine("{0} is a factor of {1}", obj, x);
            }

            return NewList;
        }
        //TODO add functions such as GCF, LCM, GCD, whatever

        public static BigInteger Factorial(int x)  //Factorial calculator. Uses BigInteger as it has no MaxValue
        {
            BigInteger y = 1;
            if (x < 0)
            {
                Console.WriteLine("Negative factorials not included");
                return 0;
            }
            else if (x > 0)
            {
                try
                {
                    for (int i = 0; i < x; i++)
                    {
                        y = y * (x - i);
                    }

                    return y;
                }
                catch (OutOfMemoryException) //Exception to throw just in case
                {
                    Console.WriteLine("The resulting number is too large to be included!");
                    return 0;
                }
            }

            return y; //will return 1 for 0, which is correct
        }

        public static int Summation(int num) // Summation function
        {
            if (num < 0)
            {
                Console.WriteLine("Summation of negative numbers not currently included.");
                return 0;
            }
            else
            {
                int x = Convert.ToInt32(Division(Multiplication(num, Addition(num, 1)), 2));
                //int x = Convert.ToInt32((num * (num + 1))/2)  //Here is a more simplified version of the above line, using functions built into the IDE
                return x;
            }

        }
    }
}
