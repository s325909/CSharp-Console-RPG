using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {
        // private int 

        private void InitWariorAttributes()
        {
            ClassName = "WARRIOR";
            Strenght = 5;
            Dexterity = 2;
            Intelligence = 1;
        }

        private void ShowStats()
        {
            Console.WriteLine($"Class: {ClassName}" +
                $"\nStrength: {Strenght}\nDexterity: {Dexterity}\nIntelligence: {Intelligence}");
        }

        public Warrior()
        {
            InitWariorAttributes();
            Console.WriteLine("A Warrior is born!");
            ShowStats();
        }
    }
}
