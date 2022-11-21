using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;



namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService _videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            foreach (Cycle cycle in cast.GetActors("cycles"))
            {

                List<Actor> segment = cycle.GetSegments();
                Actor score = cast.GetFirstActor("scores");
                List<Actor> messages = cast.GetActors("messages");
                _videoService.DrawActors(segment);
                _videoService.DrawActor(score);
                _videoService.DrawActors(messages);
                _videoService.ClearBuffer();

            }

            foreach (Actor score in cast.GetActors("scores"))
            {

                List<Actor> scores = cast.GetActors("scores");
                List<Actor> messages = cast.GetActors("messages");
                _videoService.DrawActor(score);
                _videoService.ClearBuffer();

            }
            _videoService.FlushBuffer();

        }
    }
}