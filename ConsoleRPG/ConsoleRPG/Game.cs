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

        public Characters.Character player;

        private void InitVariables()
        {
            this._gameOver = _gameOver;
        }

        // Constructors & Destructors
        public Game()
        {
            this.InitVariables();
        }

        public void run()
        {
            CharacterCreation();


            while (!this._gameOver)
            {
                Console.WriteLine("0: Game Over | 1: Show Stats | 2: Show Equipment | 3: Level Up");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("\nCASE 0: GAME OVER!");
                        _gameOver = true;
                        break;
                    case "1":
                        Console.WriteLine("\nCASE 1: Show Stats");
                        player.ShowAttributes();
                        break;
                    case "2":
                        Console.WriteLine("\nCASE 2: Show Equipment");
                        player.ShowAttributes();
                        break;
                    case "3":
                        Console.WriteLine("\nCASE 3: Level Up");
                        // player.AddAttributes(player.Gains[0], player.Gains[1], player.Gains[2]);
                        player.GainAttributes();
                        break;
                    default:
                        break;
                }

                // if (number < 0) this._gameOver = true;
                // else Console.WriteLine("You inputted: " + number);
            }

            
            Console.WriteLine("Ending game...");
        }

        private void CharacterCreation()
        {
            Console.WriteLine("Choose your Character Class\n" +
                "  1: Mage\n  2: Ranger\n  3: Rouge\n  4: Warrior");
            switch (Console.ReadLine())
            {
                case "1":
                    player = new Characters.Mage();
                    break;
                case "2":
                    player = new Characters.Ranger();
                    break;
                case "3":
                    player = new Characters.Rouge();
                    break;
                case "4":
                    player = new Characters.Warrior();
                    break;
                default:
                    break;
            }
            player.ShowAttributes();

        }
    }
}
