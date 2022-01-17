using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {
        // private int 

        private void InitWariorAttributes()
        {
            ClassName = GetType().Name;

            BaseAttributes = new Attributes.Attribute(5, 2, 1); // (STR, DEX, INT)
        }

        public Warrior()
        {
            InitWariorAttributes();
            Console.WriteLine("A Warrior is born!");
            // ShowStats();
            // baseAttributes = new Attribute(1, 2, 3);
        }
    }
}
