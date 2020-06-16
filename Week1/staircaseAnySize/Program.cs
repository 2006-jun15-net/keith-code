using System;

namespace staircase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How big do you want your staircase?");

            string userInput = Console.ReadLine();
            int stairSize = int.Parse(userInput);

            for(int i = stairSize; i > 0; i--)
            {
                string output = "";
                for(int p = 0; p < stairSize + 1; p++)
                {
                    if (i > p){
                        output += " ";
                    }else
                    {
                        output += "#";
                    }
                }
            Console.WriteLine(output);
            }
        }
    }
}
