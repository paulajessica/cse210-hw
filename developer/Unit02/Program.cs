using System;
using System.Collections.Generic;

namespace Unit02
{
    class Program
    {
        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }

    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        bool _isPlaying;
        public int _score;
        public int _totalScore;
        public int _currentcard;
        public int _nextcard;
        public string _guessuser;


        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>        
        public Director()
        {
            _isPlaying = true;
            _score = 0;
            _currentcard = 0;
            _guessuser = "0";
            _totalScore = 300;
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

            }
        }

        /// <summary>
        /// Asks the user to guess if next card is lower or higher.
        /// it contains input validation.
        /// </summary>
        public void GetInputs()
        {

            Card card = new Card();
            _currentcard = card.Draw();
            Console.WriteLine($"The card is: {_currentcard}");
            Console.Write("Higher or Lower? [h/l] ");
            _guessuser = Console.ReadLine();
            List<string> inputlist = new List<string>() { "h", "l", "H", "L" };

            while (!inputlist.Contains(_guessuser))
            {
                Console.Write("Option Invalid. Higher or Lower? [h/l] ");
                _guessuser = Console.ReadLine();

            }
        }

        /// <summary>
        /// Updates the player's score acording to answer.
        /// Calculates the points for the Card. User earns 100 points if they guessed correctly.
        /// User Loses 75 points if they guessed incorrectly. User reaches 0 points the game is over.        
        /// </summary>
        public void DoUpdates()
        {
            Card card = new Card();
            _nextcard = card.Draw();
            Console.WriteLine($"Next card was: {_nextcard}");

            if (_guessuser == "l" && _nextcard > _currentcard ||
                _guessuser == "h" && _nextcard < _currentcard)
            {
                _score = -75;

            }
            else if (_guessuser == "l" && _nextcard < _currentcard ||
                     _guessuser == "h" && _nextcard > _currentcard)
            {
                _score = 100;
            }
            else
            {
                _score = 0;
            }

            _totalScore += _score;

        }

        /// <summary>
        /// Displays the total score and check if total score is greater than zero.
        /// Also asks the player if they want to play again, in the case if your total score is greater than zero.
        /// </summary>
        public void DoOutputs()
        {
            if (_totalScore <= 0)
            {
                Console.WriteLine($"Your score is: {_totalScore}. Game Over!!!");
                _isPlaying = (_totalScore > 0);

            }
            else
            {
                Console.WriteLine($"Your score is: {_totalScore}");
                Console.Write($"Play again? [y/n] ");
                string _playagain = Console.ReadLine();
                _isPlaying = (_playagain == "y");

            }

        }

    }

    /// <summary>    
    /// The responsibility of Card is generating a new random value for the currently card and next card.
    /// </summary>

    public class Card
    {
        public int _value;

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
            _value = 0;
        }

        /// <summary>
        /// Generates a new random value for the Card.
        /// </summary>
        public int Draw()
        {
            Random number = new Random();
            _value = number.Next(1, 14);
            return _value;
        }
    }

}
