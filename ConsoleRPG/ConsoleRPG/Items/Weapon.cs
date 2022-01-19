using System;

namespace ConsoleRPG.Items
{
    public class Weapon : Item
    {
        public string[] Weapons { get; set; } 

        public Weapon(string name, string slot, int level) : base(name, slot, level)
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
