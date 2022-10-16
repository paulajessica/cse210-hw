using System;


namespace Unit02.Game
{
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


