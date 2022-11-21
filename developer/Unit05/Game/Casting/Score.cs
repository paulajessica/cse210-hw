using System;
using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;



namespace Unit05.Game.Casting
{

    public class Score : Actor
    {
        private int _pointsone = 0;
        private int _pointstwo = 0;


        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public Score(Cast cast)
        {
            AddPoints(cast, 0, 0);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>

        public void AddPoints(Cast cast, int pointone, int pointtwo)
        {
            this._pointsone += pointone;
            Actor score = cast.GetFirstActor("scores");
            score.SetText($"Player One: {this._pointsone}");
            score.SetPosition(new Point(0, 0));


            this._pointstwo += pointtwo;
            List<Actor> scores = cast.GetActors("scores");
            Actor score2 = (Actor)scores[1];
            score2.SetText($"Player Two: {this._pointstwo}");
            score2.SetPosition(new Point(Constants.MAX_X - 120, 0));

        }



    }
}