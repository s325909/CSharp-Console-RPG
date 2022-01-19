using System;
using System.Collections.Generic;

namespace ConsoleRPG.Items
{
    public class Weapon : Item
    {
        // Properties
        public string[] Weapons { get; set; }

        // public List<Weapon> 

        // Constructor
        public Weapon(string name, string type, string slot, int level) : base(name, type, slot, level)
        {
            Weapons = Enum.GetNames(typeof(WeaponTypes));
            foreach (string weapon in Weapons)
            {
                Console.WriteLine("Weapon: " + weapon);
            }
        }

        public enum WeaponTypes { Axe, Bow, Dagger, Hammer, Staff, Sword, Wand }
    }
}
