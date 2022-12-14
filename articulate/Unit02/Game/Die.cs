using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of its currently rolled value and the points its
    /// worth.
    /// </summary>
    public class Die
    {
        public int _points;
        public int _value;


        // 2) Create the class constructor. Use the following method comment.
        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
            _points = 0;
            _value = 0;
        }

        // 3) Create the Roll() method. Use the following method comment.
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>   

        public void Roll()
        {
            Random number = new Random();
            _value = number.Next(1, 7);

            if (_value == 5)
            {
                _points = 50;
            }
            else if (_value == 1)
            {
                _points = 100;
            }
            else
            {
                _points = 0;
            }

        }
    }


}