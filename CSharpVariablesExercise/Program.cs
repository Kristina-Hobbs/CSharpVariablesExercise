using System;

namespace CSharpVariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string myName = "Kristina Hobbs";
            int myAge = 35;
            bool isMale = false;
            char myCharacter = 'a';
            decimal myDecimal = 1234567890.234m;
            double num = 1234.5678;


            Console.WriteLine($"My name is {myName}, I am {myAge} years old, I am {isMale}");


            Console.WriteLine($"");

            if (isMale == true)
            {
                Console.WriteLine($"male");
            }
            if (isMale == false)
            {
                Console.WriteLine($"female");
            }

        }
    }
}

