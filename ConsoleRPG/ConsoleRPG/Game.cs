using System;
using ConsoleRPG.Characters;

namespace ConsoleRPG
{
    public class Game
    {
        private bool _gameOver { get; set; }

        public Character player;

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
                Console.WriteLine("\n(0): Game Over | (1): Show Stats | (2): Show Equipment | (3): Level Up |\n");
                switch (Console.ReadLine())
                {
                    case "0":
                        _gameOver = true;
                        break;
                    case "1":
                        player.ShowAttributes();
                        break;
                    case "2":
                        Items.Equipment equipment = new Items.Equipment();

                        Console.WriteLine("\n(0): Exit | (1): Show Equipped | (2): Show Armors | (3): Show Weapons |\n");

                        switch (Console.ReadLine())
                        {
                            case "0":
                                break;
                            case "1":
                                player.ShowEquiped();
                                break;
                            case "2":
                                Console.WriteLine("\n(0): Exit | (1): Head | (2): Body | (3): Legs\n");

                                var index = 0;

                                switch (Console.ReadLine())
                                {
                                    case "0":
                                        break;
                                    case "1":
                                        equipment.PrintHelmets();
                                        Console.WriteLine("Select Armor to Equip: ");
                                        index = Int16.Parse(Console.ReadLine());
                                        var head = equipment.Helmets[index];
                                        player.EquipableItemCheck(head);
                                        break;
                                    case "2":
                                        equipment.PrintBodyPlates();
                                        Console.WriteLine("Select Armor to Equip: ");
                                        index = Int16.Parse(Console.ReadLine());
                                        var body = equipment.BodyPlates[index];
                                        player.EquipableItemCheck(body);
                                        break;
                                    case "3":
                                        equipment.PrintLeggings();
                                        Console.WriteLine("Select Armor to Equip: ");
                                        index = Int16.Parse(Console.ReadLine());
                                        var legs = equipment.Leggings[index];
                                        player.EquipableItemCheck(legs);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "3":
                                equipment.PrintWeapons();
                                Console.WriteLine("Select Weapon to Equip: ");
                                index = Int16.Parse(Console.ReadLine());
                                var weapon = equipment.Weapons[index]; 
                                player.EquipableItemCheck(weapon); 
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        player.GainLevelAndAttributes();
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
            Console.WriteLine("\nYour name:");
            string name = Console.ReadLine();

            Console.WriteLine("\nChoose your Character Class\n" +
                "(1): Mage | (2): Ranger | (3): Rouge | (4): Warrior");
            switch (Console.ReadLine())
            {
                case "1":
                    player = new Mage(name);
                    break;
                case "2":
                    player = new Ranger(name);
                    break;
                case "3":
                    player = new Rouge(name);
                    break;
                case "4":
                    player = new Warrior(name);
                    break;
                default:
                    break;
            }
            player.ShowAttributes();
        }
    }
}
