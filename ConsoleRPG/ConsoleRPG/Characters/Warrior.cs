using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {

        private void InitWariorAttributes()
        {
            // BaseAttributes = new Attributes.Attribute(5, 2, 1); // (STR, DEX, INT)
            // BaseAttributes.Dexterity = 2;
            // BaseAttributes.AddAttributes(5, 2, 1); 

            AddAttributes(5, 2, 1); // (STR, DEX, INT)

            Console.WriteLine("LEVELLING UP");
            AddAttributes(3, 2, 1); // (STR, DEX, INT)
        }

        

        public Warrior()
        {
            InitWariorAttributes();
            Console.WriteLine($"A {ClassName} is born!");

        }
    }
}
