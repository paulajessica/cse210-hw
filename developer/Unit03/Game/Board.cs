using System;

namespace Unit03.Game
{

    /// <summary>   
    /// The responsibility of class Board is to display parachute according of attempts.
    /// </summary>

    /// <summary>
    /// Constructs a new instance of Board.
    /// </summary>
    public class Board
    {
        private int _value;

        public Board()
        {
            _value = 0;

        }

        /// <summary>
        /// Keeps a track and display man parachute.
        /// </summary>
        public void PrintMan(int _value)
        {
            if (_value == 0)
            {

                Console.WriteLine(" ___");
                Console.WriteLine(@"/___\");
                Console.WriteLine(@"\   /");
                Console.WriteLine(@" \ /");
                Console.WriteLine("  O  ");
                Console.WriteLine(@"/ | \");
                Console.WriteLine(@"/   \");

            }

            else if (_value == 1)
            {

                Console.WriteLine("");
                Console.WriteLine(@"/___\");
                Console.WriteLine(@"\   /");
                Console.WriteLine(@" \ /");
                Console.WriteLine("  O  ");
                Console.WriteLine(@"/ | \");
                Console.WriteLine(@"/   \");

            }
            else if (_value == 2)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@"\   /");
                Console.WriteLine(@" \ /");
                Console.WriteLine("  O  ");
                Console.WriteLine(@"/ | \");
                Console.WriteLine(@"/   \");


            }
            else if (_value == 3)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@" \ /");
                Console.WriteLine("  O  ");
                Console.WriteLine(@"/ | \");
                Console.WriteLine(@"/   \");

            }
            else if (_value == 4)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  O  ");
                Console.WriteLine(@"/ | \");
                Console.WriteLine(@"/   \");

            }
            else if (_value == 5)
            {

                Console.WriteLine("      ");
                Console.WriteLine("      ");
                Console.WriteLine("      ");
                Console.WriteLine("      ");
                Console.WriteLine("      ");
                Console.WriteLine("  x  ");
                Console.WriteLine(@"/ | \");
                Console.WriteLine(@"/   \");
            }

        }
    }
}