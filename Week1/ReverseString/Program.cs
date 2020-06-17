using System;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type your string?");
            string userInput = Console.ReadLine();

                char[] array = userInput.ToCharArray();
                Array.Reverse(array);
                string output = new string(array);
                
                Console.WriteLine(output);
                
        }
    }
}