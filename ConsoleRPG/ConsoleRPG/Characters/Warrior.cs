using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {   
        // Constructor
        public Warrior()
        {
            // Character Attributes and Gains (STR, DEX, INT)
            AddAttributes(5, 2, 1);
            LevelGains = new[] { 3, 2, 1 };

            // InitWariorAttributes();
            // Console.WriteLine($"{Gains[0]} strenght | {Gains[1]} dexterity | {Gains[2]} intelligens");
        }
    }
}
