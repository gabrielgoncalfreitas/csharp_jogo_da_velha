using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Classes.Board;

namespace TicTacToe
{
    class Game
    {
        private static bool first = true;
        static void Main(String[] args)
        {
            Game game = new Game();
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                game.Home();

                if (first)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition((Console.WindowWidth - "New match".Length) / 2, Console.CursorTop);
                    Console.WriteLine("New match");
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.SetCursorPosition((Console.WindowWidth - "View matches and scores".Length) / 2, Console.CursorTop);
                    Console.WriteLine("View matches and scores");
                } else
                {
                    Console.SetCursorPosition((Console.WindowWidth - "New match".Length) / 2, Console.CursorTop);
                    Console.WriteLine("New match");

                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition((Console.WindowWidth - "View matches and scores".Length) / 2, Console.CursorTop);
                    Console.WriteLine("View matches and scores");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition((Console.WindowWidth - "Press arrows to navigate!".Length) / 2, Console.CursorTop);
                Console.WriteLine("Press arrows to navigate!");

                var key = Console.ReadKey().Key;
                if (key == System.ConsoleKey.DownArrow) { first = false; }
                else { first = true; }
            }
        } 

        private void Home()
        {
            Game game = new Game();

            game.Logo();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private void Logo()
        {
            string[] logo =
            {
                "   ___________       ___________            ___________             ",
                "  /____  ____/      /____  ____/           /____  ____/      _____  ",
                "     / / __  ______    / /          ______    / /          / ___ \\",
                "     / / /_/ / ____/   / / ____ __  / ____/   / / _____    / /__/ / ",
                "   / / / / / /       / / / ___` / / /       / / / ___ \\  / _____/ ",
                "  / / / / / /____   / / / /__/ / / /____   / / / /__/ / / /____   ",
                "/_/ /_/ /______/  /_/  \\___,_/ /______/  /_/  \\_____/  \\_____/ ",
            };


            foreach (string line in logo)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
            }
        }
    }
}
