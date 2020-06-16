using System;

namespace collatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your number?");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);


           while(userNumber != 1)
            {
                if(userNumber%2 == 0)
                {
                    userNumber = userNumber/2;
                }else
                {
                    userNumber = userNumber*3 +1;
                }
                 Console.WriteLine(userNumber);
            }
        }    
    }
}
