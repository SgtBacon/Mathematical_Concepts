using System;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra algebra = new Algebra();

            Console.WriteLine(algebra.Addition(10.1234, 5.4321));
            Console.WriteLine(algebra.Subtraction(10.1234, 5.4321));
            Console.WriteLine(algebra.Multiplication(10.1234, 5.4321));
            Console.WriteLine(algebra.Division(10.1234, 5.4321));

            Console.WriteLine("Welcome to my mathematical concepts project.");
            Console.WriteLine("This is a very simple project designed to be used as a calculator of sorts, \nin order to give me more understanding of various concepts in math when applied in programming.");
            Console.WriteLine("I have included a loop to allow any potential User to test this project out as they would like");
            Console.WriteLine("To exit the loop, when at the main screen, type QUIT, and the program will end.");
        }
    }
}
