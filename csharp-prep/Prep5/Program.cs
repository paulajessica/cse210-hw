using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 5");
            DisplayMessage();
            string username = PromptUserName();
            int usernumber = PromptUserNumber();
            int squarenumber = SquareNumber(usernumber);
            DisplayResult(username, squarenumber);

        }

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {

            Console.Write("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int PromptUserNumber)
        {
            int squaredresult = PromptUserNumber * PromptUserNumber;
            return squaredresult;

        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}.");
        }




    }
}