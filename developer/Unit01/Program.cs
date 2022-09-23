using System;
using System.Collections.Generic;


// Paula Jessica Ferreira Lucas da Silva
//W02 Prove: Developer
namespace Unit01
{
    class TicTacToeGame
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Tic-Tac-Toe Game!");
            Console.WriteLine();
            // making the game table with index variable like a counter
            string[,] table = new string[3, 3];
            int index = 1;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = index.ToString();
                    index++;
                }
            }

            //print the game table
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j]}  |  ");
                }
                Console.WriteLine();
            }


            //sking the number from user and starting with letter 'X' in variable turn
            string turn = "X";

            // List to cheking if user select one played variable valid
            List<string> numberplayed = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //Taking position in table
            Console.Write($"{turn} turn to choose a square (1-9):");
            string played = Console.ReadLine();

            //cheking input from user to validation

            string positionselected = PlayedValidation(numberplayed, played, turn);

            //the loop to run Tic-Tac-Toe Game with numbermoves from one to nine
            int numbermoves = 1;
            while (numbermoves <= 9)
            {


                //scrolling trhough the table, cheking played from user is equal position in table
                // if yes then replace number selected for turn(letter X or O)
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (table[i, j] == (positionselected) && numberplayed.Contains(positionselected))
                        {
                            table[i, j] = turn;
                            numberplayed.Remove(positionselected);
                        }
                    }
                }
                //cleaning old table to after that it prints new table with the replacements
                Console.Clear();

                Console.WriteLine("Welcome to Tic-Tac-Toe Game!");
                Console.WriteLine();

                //printing the new table
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        Console.Write($"{table[i, j]}  |  ");
                    }
                    Console.WriteLine();
                }

                //the counter to increase the numbermoves variable and keeping the loop until nine times
                numbermoves++;

                //cheking if the user wins the game. If yes, the game finishes.
                if (table[0, 0] == table[0, 1] && table[0, 0] == table[0, 2] ||
                    table[1, 0] == table[1, 1] && table[1, 0] == table[1, 2] ||
                    table[2, 0] == table[2, 1] && table[2, 0] == table[2, 2] ||
                    table[0, 0] == table[1, 0] && table[0, 0] == table[2, 0] ||
                    table[0, 1] == table[1, 1] && table[0, 1] == table[2, 1] ||
                    table[0, 2] == table[1, 2] && table[0, 2] == table[2, 2] ||
                    table[0, 0] == table[1, 1] && table[0, 0] == table[1, 2] ||
                    table[0, 2] == table[1, 1] && table[0, 2] == table[2, 0])
                {
                    Console.WriteLine($"{turn} win this game. Congrats!!!");
                    break;
                }
                else if (numbermoves == 10)
                {
                    Console.WriteLine($"Tied the game!!!");
                    Console.WriteLine();
                    break;
                }

                //changing letter of user
                //printing and taking new turn variable                
                turn = ChangeTurn(turn);

                Console.WriteLine();
                Console.Write($"{turn} turn to choose a square (1-9):");
                positionselected = Console.ReadLine();

                //cheking input from user to validation                
                positionselected = PlayedValidation(numberplayed, positionselected, turn);
                Console.WriteLine();



            }

        }

        static string PlayedValidation(List<string> list, string position, string letter)
        {
            while (!list.Contains(position))
            {
                Console.Write($"{letter} Option Invalida. Try againd and to choose a square (1-9) again:");
                position = Console.ReadLine();

            }
            return position;
        }
        static string ChangeTurn(string letter)
        {
            if (letter == "X")
            {
                letter = "O";
            }
            else
            {
                letter = "X";
            }
            return letter;
        }

    }
}
