using System;


namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Score is to keep track of point from Actor. 
    /// </para>
    /// </summary>
    public class Score
    {
        private int _point;

        /// <summary>
        /// Constructs a new instance of Score.
        /// </summary>
        public Score()
        {
            _point = 0;
        }

        public int PointGem()
        {
            return _point = +10;
        }

        public int PointStone()
        {
            return _point = -10;
        }


    }
}