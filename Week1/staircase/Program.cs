using System;

namespace staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int stairSize = 8;
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
