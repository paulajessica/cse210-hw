using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3");

            {
                /*Console.Write("What is the magic number? ");*/

                Random number = new Random();
                int magicinput = number.Next(1, 101);
                string magicnumber = magicinput.ToString();
                string guessinput;

                do
                {

                    Console.Write("What is your guess?");
                    guessinput = Console.ReadLine();
                    int guessnumber = int.Parse(guessinput);

                    /*converter to ReadLine to int
                    guess = int.Parse(Console.ReadLine());*/

                    if (magicinput > guessnumber)
                    {
                        Console.WriteLine($"Higher");
                    }
                    else if (magicinput < guessnumber)
                    {
                        Console.WriteLine($"Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it!");
                    }

                } while (magicnumber != guessinput);

            }
        }
    }
}
