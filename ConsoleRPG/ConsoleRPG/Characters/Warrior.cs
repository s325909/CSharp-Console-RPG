using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {
        // private int 

        private void InitWariorAttributes()
        {
            ClassName = "WARRIOR";
            Level = 1;
            Strenght = 5;
            Dexterity = 2;
            Intelligence = 1;
        }

        public Warrior()
        {
            InitWariorAttributes();
            Console.WriteLine("A Warrior is born!");
            // ShowStats();
        }
    }
}
