using System.Collections.Generic;
using Unit04.Game.Casting;
using Unit04.Game.Services;
using System;


namespace Unit04.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService _keyboardService = null;
        private VideoService _videoService = null;
        List<int> totalpoints = new List<int>();
        Score score = new Score();

        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this._keyboardService = keyboardService;
            this._videoService = videoService;

        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            _videoService.OpenWindow();
            while (_videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            _videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = _keyboardService.GetDirection();
            robot.SetVelocity(velocity);


        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with gems or stones(actors).
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {

            Actor robot = cast.GetFirstActor("robot");
            int maxX = _videoService.GetWidth();
            int maxY = _videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            Actor banner = cast.GetFirstActor("banner");
            banner.SetText("Score: 0");

            List<Actor> allActors = cast.GetActors("allActors");

            foreach (Actor actor in allActors)
            {

                int maxXstone = _videoService.GetWidth();
                int maxYstone = _videoService.GetHeight();
                actor.MoveNext(maxXstone, maxYstone);


                if (robot.GetPosition().Equals(actor.GetPosition()) && actor.GetText() == "*")
                {
                    int pointgem = score.PointGem();
                    totalpoints.Add(pointgem);
                    cast.RemoveActor("allActors", actor);


                }
                else if (robot.GetPosition().Equals(actor.GetPosition()) && actor.GetText() == "o")
                {
                    int poinstone = score.PointStone();
                    totalpoints.Add(poinstone);
                    cast.RemoveActor("allActors", actor);

                }

            }


            int total = 0;
            foreach (int num in totalpoints)
            {
                total += num;
                string message = total.ToString();
                banner.SetText($"Score: {message}");
            }




        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            _videoService.ClearBuffer();
            _videoService.DrawActors(actors);
            _videoService.FlushBuffer();
        }
    }

}