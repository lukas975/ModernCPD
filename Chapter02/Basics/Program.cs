﻿using System; 
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {   
            // declare some unused variables using types
            // in additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            // loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                // declare a variable to count the number of methods
                int methodCount = 0;
                
                // loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }

                // output the count of types and their methods
                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: r.Name);
            }

            // let the heightInMetres variable become equal to the value 1.88
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

            char letter = 'A'; // assigning literal characters
            char digit = '1';
            char symbol = '$';
            //char userChoice = GetKeystroke(); // assigning from a function

            string firstName = "Bob"; // assigning literal strings
            string lastName = "Smith";
            string phoneNumber = "(215) 555-4256";
            // assigning a string returned from a function call
            //string address = GetAddressFromDatabase(id: 563);

            string fullNameWithTabSeparator = "Bob\tSmith";
            string filePath = @"C:\televisions\sony\bravia.txt";
        }   
    }
}
