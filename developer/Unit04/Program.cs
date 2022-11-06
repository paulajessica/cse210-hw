using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;
using System.Timers;


namespace Unit04
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 180;
        private static int ROWS = 80;
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_GEMS = 10;
        private static int DEFAULT_STONES = 10;
        private static string CAPTION = "Greed Game";



        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the banner
            Actor banner = new Actor();
            banner.SetText("");
            banner.SetFontSize(FONT_SIZE);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("banner", banner);

            // create the robot
            Actor robot = new Actor();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            robot.SetColor(WHITE);
            robot.SetPosition(new Point(MAX_X / 2, 580));
            cast.AddActor("robot", robot);

            // create the gems
            Random randomGem = new Random();
            for (int i = 0; i < DEFAULT_GEMS; i++)
            {
                int x = randomGem.Next(1, COLS);
                int y = randomGem.Next(1, ROWS);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);

                int r = randomGem.Next(0, 256);
                int g = randomGem.Next(0, 256);
                int b = randomGem.Next(0, 256);
                Color color = new Color(r, g, b);

                Gem gem = new Gem();
                gem.SetText("*");
                gem.SetFontSize(FONT_SIZE);
                gem.SetColor(color);
                gem.SetPosition(position);
                cast.AddActor("allActors", gem);

                Point direction = new Point(0, 1);
                direction = direction.Scale(CELL_SIZE - 10);
                gem.SetVelocity(direction);
            }


            // create the stones
            Random randomStone = new Random();
            for (int i = 0; i < DEFAULT_STONES; i++)
            {

                int x = randomStone.Next(1, COLS);
                int y = randomStone.Next(1, ROWS);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);

                int r = randomStone.Next(0, 256);
                int g = randomStone.Next(0, 256);
                int b = randomStone.Next(0, 256);
                Color color = new Color(r, g, b);

                Stone stone = new Stone();
                stone.SetText("o");
                stone.SetFontSize(FONT_SIZE);
                stone.SetColor(color);
                stone.SetPosition(position);
                cast.AddActor("allActors", stone);

                Point direction = new Point(0, 1);
                direction = direction.Scale(CELL_SIZE - 10);
                stone.SetVelocity(direction);
            }

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }

    }
}