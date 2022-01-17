using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Game
    {
        private bool _gameOver { get; set; }

        private void InitVariables()
        {
            this._gameOver = _gameOver;
        }

        // Constructors & Destructors
        public Game()
        {
            Console.WriteLine("HELLO FROM THE GAME CLASS!");
            this.InitVariables();
        }

        public void run()
        {
            while (this._gameOver == false)
            {
                Console.WriteLine("Write a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0) this._gameOver = true;
                else Console.WriteLine("You inputted: " + number);
            }

            Console.WriteLine("Ending game...");
        }
    }
}
