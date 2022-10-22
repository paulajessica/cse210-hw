using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    /// <summary>   
    /// The responsibility of a Jumper is to guess a letter.
    /// </summary>
    public class Jumper
    {

        private WordBank _wordList = new WordBank();
        private string _chosenWord;
        public string _hint;
        private List<string> guessesLettersList = new List<string>();
        private int _countGuesses;
        private string _displayWord;
        private Board _man = new Board();
        private int _lengthChoseWord;
        private int _amountGuessesLettersList;

        /// <summary>
        /// Constructs a new instance of Jumper.
        /// </summary>
        public Jumper()
        {
            _chosenWord = _wordList.GetRandowWord();
            _hint = _wordList.GetHint();
            _countGuesses = 0;
            _displayWord = "";
            _lengthChoseWord = _chosenWord.Length;
            _amountGuessesLettersList = 0;

        }

        /// <summary>
        /// Checks how the parachute and the random word looks after the user tries to guess a letter.
        /// Counts a amount of attempts of the user.
        /// </summary>
        public void CutRope(string guessLetter)
        {

            if (_chosenWord.Contains(guessLetter))

            {
                guessesLettersList.Add(guessLetter);
                _amountGuessesLettersList++;
                Console.WriteLine(DisplayWord(_chosenWord, guessesLettersList, _displayWord));
                _countGuesses = _countGuesses + 0;
                _man.PrintMan(_countGuesses);

            }
            else
            {
                Console.WriteLine(DisplayWord(_chosenWord, guessesLettersList, _displayWord));
                _countGuesses = _countGuesses + 1;
                _man.PrintMan(_countGuesses);
            }

        }

        /// <summary>
        /// Display how the random word looks after the user tries to guess a letter.
        /// </summary>
        private string DisplayWord(string _chosenWord, List<string> guessesLettersList, string _displayWord)
        {

            foreach (char letter in _chosenWord)
                if (guessesLettersList.Contains(letter.ToString()))
                {
                    _displayWord += letter;
                }
                else
                {
                    _displayWord += "_";

                }

            return _displayWord;
        }

        /// <summary>
        /// Checks whether the user continues playing or not.
        /// </summary>
        public bool IsAlive()
        {
            return _countGuesses != 5 && _amountGuessesLettersList != _lengthChoseWord;
        }


    }
}