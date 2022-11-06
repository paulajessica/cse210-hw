using System;


namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Stone : Actor
    {
        private int _point;

        /// <summary>
        /// Constructs a new instance of Stone.
        /// </summary>
        public Stone()
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