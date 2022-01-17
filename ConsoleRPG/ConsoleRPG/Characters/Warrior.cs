using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {

        private void InitWariorAttributes()
        {
            AddAttributes(5, 2, 1); // (STR, DEX, INT)
            Gains = new[] { 3, 2, 1 };
            Console.WriteLine($"{ClassName} gains:\n" +
                $" {Gains[0]} strenght | {Gains[1]} dexterity | {Gains[2]} intelligens");
        }
        
        // Constructor
        public Warrior()
        {
            InitWariorAttributes();
            Console.WriteLine($"A {ClassName} is born!");
        }

        public void GainAttributes()   // when levelling up
        {
            AddAttributes(3, 2, 1); // (STR, DEX, INT)
        }
    }
}
