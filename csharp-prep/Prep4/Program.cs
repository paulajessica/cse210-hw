using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is Prep 4");
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            List<int> numbers = new List<int>();
            int input;

            do
            {
                Console.Write("Enter number:");
                input = int.Parse(Console.ReadLine());
                numbers.Add(input);

            } while (input != 0);

            int total = 0;

            foreach (int number in numbers)
            {
                total += number;

            }

            float average = total / (numbers.Count - 1);


            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average:.00}");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"The largest number is: {max}");

        }
    }
}