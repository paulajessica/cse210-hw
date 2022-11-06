using System;


namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Gem(actor) is to keep track of points from Gem.
    /// </para>
    /// </summary>
    public class Gem : Actor
    {
        private int _point;


        /// <summary>
        /// Constructs a new instance of Gem.
        /// </summary>
        public Gem()
        {
            _point = 0;

        }

        public int GetPoint()
        {
            return _point;
        }

        public int SetPoint(int point)
        {
            return this._point = point;
        }


    }


}