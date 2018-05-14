using System;
using Overview.Game;

namespace Overview
{
    internal class Program
    {
        private static void EnableBreakdown(bool enable)
        {
            if (!enable) return;
            var b = new Breakdown.Breakdown();
            Console.Read();
        }

        /// <summary>
        /// Entry point of the application.
        /// </summary>
        private static void Main(string[] args)
        {
            EnableBreakdown(false);
            var game = new Game.Solitare();

            Player[] players =
            {
                new Player("Harry"),
                new Player("Enemy")
            };
            game.Start(players);
        }
    }
}
