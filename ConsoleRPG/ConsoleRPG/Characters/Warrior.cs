using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {
        // private int 

        private void InitWariorAttributes()
        {
            BaseAttributes = new Attributes.Attribute(5, 2, 1); // (STR, DEX, INT)
        }

        public Warrior()
        {
            InitWariorAttributes();
            Console.WriteLine($"A {ClassName} is born!");

        }
    }
}
