using System;
using System.Collections.Generic;
using static System.Random;

namespace Unit03.Game
{
    /// <summary>   
    /// The responsibility of WordBank is to keep a list of words and hits, and choose randomly one to user guess.
    /// </summary>
    public class WordBank
    {
        private string _randomWord;
        private List<string> wordList = new List<string>(){"apple", "orange", "banana", "melon", "pear", "mango", "date", "grapes", "watermelon",
             "lemon", "coconut" };
        private List<string> hintList = new List<string>(){ "It is a fruit red.", "It is a fruit orange.", "It is a fruit with a yellow skin.",
            "First letter is m.", "First letter is p.", "First letter is m.", "First letter is d.",
            "It is a small fruit.", "First letter is w.", "It's a sour fruit.", "It's a white fruit inside."};
        private int _index;

        /// <summary>   
        /// Constructs a new instance of WordBank.
        /// </summary>
        public WordBank()
        {
            _index = -1;

            Random random = new Random();
            _index = random.Next(wordList.Count);
            Console.Write(_index);

        }

        /// <summary>   
        /// Takes the randomly one word to user guess.
        /// </summary>
        public string GetRandowWord()
        {
            string _randomWord = wordList[_index].ToLower();
            Console.Write(_index);
            return _randomWord;

        }

        /// <summary>   
        /// Takes hits of random word.
        /// </summary>
        public string GetHint()
        {
            string _randomHint = hintList[_index].ToLower();

            return _randomHint;

        }


    }
}