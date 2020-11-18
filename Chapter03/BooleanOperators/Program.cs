using System;
using static System.Console;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical operators
            bool a = true;
            bool b = false;
            // For the AND & logical operator, both operands must be true for the result to be true.
            WriteLine($"AND | a | b ");
            WriteLine($"a | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            // For the OR | logical operator, either operand can be true for the result to be true.
            WriteLine($"OR | a | b ");
            WriteLine($"a | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            // For the XOR ^ logical operator, either operand can be true (but not both!) for the result to be true.
            WriteLine($"XOR | a | b ");
            WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");

            // Conditional logical operators &&
            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");

            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");
        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
