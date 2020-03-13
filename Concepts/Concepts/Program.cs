using System;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(Algebra.Addition(10.1234, 5.4321));
            Console.WriteLine(Algebra.Subtraction(10.1234, 5.4321));
            Console.WriteLine(Algebra.Multiplication(10.1234, 5.4321));
            Console.WriteLine(Algebra.Division(10.1234, 5.4321));
            Console.WriteLine(Algebra.Abs(-1));
            Console.WriteLine(Algebra.IsDivisible(0, -1));
            Console.WriteLine(Algebra.IsPrime(100));
            Algebra.FactorList(10);
            Console.WriteLine(Algebra.Factorial(0));
            Console.WriteLine(Algebra.Summation(-20));

            Console.WriteLine("Welcome to my mathematical concepts project.");
            Console.WriteLine("This is a very simple project designed to be used as a calculator of sorts, \nin order to give me more understanding of various concepts in math when applied in programming.");
            Console.WriteLine("I have included a loop to allow any potential User to test this project out as they would like");
            Console.WriteLine("To exit the loop, when at the main screen, type QUIT, and the program will end.");
        }
    }
}
