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

                Characters.Character player = new Characters.Warrior();
                player.ShowAttributes();

                // string slot1 = player.Slots[0];
                // Console.WriteLine(slot1);

                /**
                // Character Creation
                if (number == 0)
                {
                    player = new Characters.Warrior();
                    if (number == 1) player.ShowStats();
                }
                **/



                    if (number < 0) this._gameOver = true;
                else Console.WriteLine("You inputted: " + number);
            }

            Console.WriteLine("Ending game...");
        }
    }
}
