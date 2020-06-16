using System;

namespace ProceduralBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            // the Main method is ultimately run by the "dotnet run" command

            // each "line of code" is a "statement"ending in a semicolon.
            int x = 5; // declares a variable named "x: with type "int" (integer, whole number), and
                       // gives it the value 5.

            x = 4; // can change variable
        //    x = true;  // can't change type  

            // numeric data types

            //adding or subtracting can have some rounding errors

            //char (jusst one character, use single quotes)

            // arrays 
            int[] numbers = {4, 5, 9, 2};

                    //  min         max+1      (increase by one)
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            bool mathWorks = (3 + 3 == 6); // true

            Console.WriteLine("Enter a number:");

            string userInput = Console.ReadLine();

            // int.parse can convert a string into the int it represents
            int number = int.Parse(userInput);

            number *= 2; // shorthand for writing "number = number * 2;"

            // the value of the number will be converted back to a string and combined with the first string
            Console.WriteLine("Double: " + number);

            // control structures
            // let us run lines of code conditionally or repeatedly

            if(number < 0)
            {
                Console.WriteLine("negative number");
            }

            else 
            {
                // repeatedly decrease the number until it's negative

                //for loop is one way to allow code to run repeatedly
                for (; number >= 0; number -= 5)
                // (init; test; update)
                {
                    Console.WriteLine(number);
                }// print eg 16 then 11 then 6 then 1
            }
        }
    }
}
