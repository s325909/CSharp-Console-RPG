using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {

        private void InitWariorAttributes()
        {
            AddAttributes(5, 2, 1); // (STR, DEX, INT)
            LevelGains = new[] { 3, 2, 1 };
        }
        
        // Constructor
        public Warrior()
        {
            InitWariorAttributes();
            Console.WriteLine($"A {ClassName} is born!");

            // Console.WriteLine($"{Gains[0]} strenght | {Gains[1]} dexterity | {Gains[2]} intelligens");
        }
    }
}
