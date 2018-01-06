using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class GameDemo
    {
        public static void Run(string[] args)
        {
            Game game = new Game();
            game.MaximumPlayers = 1;
            game.Name = "Game1";
            Console.WriteLine(game.ToString());

            GameWithTimeLimit newGame = new GameWithTimeLimit();
            newGame.MaximumPlayers = 10;
            newGame.Name = "GameTimeLimit";
            Console.WriteLine(newGame.ToString());
        }
    }
}
