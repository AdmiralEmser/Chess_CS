using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_CS
{
    internal class GUI
    {
        public void start()
        {

        }
        public void update()
        {

        }
    }

    internal class Game
    {
        // variables to store data
        public short[,] field = new short[8, 8];
        private short[,] possible_moves = new short[8, 8];

        public void start()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // necessary classes and dependencies
            Game game = new Game();
            GUI graphics = new GUI();

            // general structure of the game
            game.start();
            graphics.start();

        }
    }
}
