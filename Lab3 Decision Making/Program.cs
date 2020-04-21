using System;
using System.Runtime.CompilerServices;

namespace Lab3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome what is your name? ");
            string name = Console.ReadLine();

            bool loop = true;
            while (loop == true)
            {
               
                Console.WriteLine($"{name} please enter a whole number between 1 and 100. ");
                string input = Console.ReadLine();

                int number = int.Parse(input);

                if (number % 2 == 0 && number >=0 && number <= 24)
                {
                    Console.WriteLine($"{name} your number is even and less than 25 ");
                }
                else if (number % 2 == 0 && number > 25 && number < 60)
                {
                    Console.WriteLine($"{name} your number is even ");
                }
                else if (number % 2 == 0 && number >= 60 && number <= 100)
                {
                    Console.WriteLine($"{name} {number} is an even number");
                }
                else if (number >= 0 && number <= 100)
                {
                    Console.WriteLine($"{name} {number} is an odd number");
                }
                else
                {
                    Console.WriteLine($"{name} that number does not fall between 1 and 100");
                }
                bool askAgain = true;
                while (askAgain)
                {
                    Console.WriteLine("Would you like to continue? y/n");
                    string answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        loop = true;
                        askAgain = false;
                        continue;
                    }
                    else if (answer == "n")
                    {
                        askAgain = false;
                        loop = false;
                        break;
                    }

                    
                }
            }
        }
    }
}
