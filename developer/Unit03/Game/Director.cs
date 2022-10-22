using System;

namespace Unit03.Game
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
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private TerminalService _terminalService = new TerminalService();
        private Jumper _jumper = new Jumper();
        private bool _isPlaying;
        private string _guessLetter;
        private WordBank _choseHint = new WordBank();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {

            _isPlaying = true;
            _guessLetter = "";

        }


        public void StartGame()
        {
            _terminalService.WriteText("Welcome to Jumper Game!");
            _terminalService.WriteText("\n");
            string Hint = _jumper._hint;
            _terminalService.WriteText($"Hint: {Hint}");



            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks form the user to a letter.
        /// </summary>
        private void GetInputs()
        {
            _terminalService.WriteText("\nEnter a letter: ");
            char[] input = Console.ReadLine().ToCharArray();

            string letter = "";
            if (input.Length > 0)
            {
                letter = input[0].ToString();
                letter = letter.ToLower();
            }
            _guessLetter = letter;

        }

        /// <summary>
        /// Checks if a letter is rigth or wrong.
        /// </summary>
        private void DoUpdates()
        {
            _jumper.CutRope(_guessLetter);
        }

        /// <summary>
        /// Checks whether the user continues playing or not.
        /// </summary>
        private void DoOutputs()
        {

            if (_jumper.IsAlive())
            {
                _isPlaying = true;

            }
            else
            {
                _isPlaying = false;
                Console.WriteLine("Games is over! Thank you for playing!");
            }

        }


    }
}
