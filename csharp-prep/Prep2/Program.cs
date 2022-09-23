using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");

            Console.Write("What is your grade percent?");
            string grade = Console.ReadLine();
            int number = int.Parse(grade);

            if (number >= 90)
            {
                Console.WriteLine($"Your grade is letter {number}.");
            }
            else if (number >= 80 && number < 90)
            {
                Console.WriteLine($"Your grade is letter {number}.");
            }
            else if (number >= 70 && number < 80)
            {
                Console.WriteLine($"Your grade is letter {number}.");
            }
            else if (number >= 60 && number < 70)
            {
                Console.WriteLine($"Your grade is letter {number}.");
            }
            else
            {
                Console.WriteLine($"Your grade is letter {number}.");
            }
            if (number >= 70)
            {
                Console.WriteLine("You pass in this class. Congratulations!");
            }
            else
            {
                Console.WriteLine("Don't give up. You can do it!");

            }


        }
    }
}
