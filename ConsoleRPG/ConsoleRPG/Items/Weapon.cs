using System;
using System.Collections.Generic;
using ConsoleRPG.Attributes;

namespace ConsoleRPG.Items
{
    public class Weapon : Item
    {
        // Properties
        public string[] Weapons { get; set; }

        public double DamagePerSecond { get; set; }

        // Constructor
        public Weapon(string name, string type, string slot, int level, WeaponAttribute attribute) : base(name, type, slot, level)
        {
            DamagePerSecond = attribute.BaseDamage * attribute.AttackSpeed;
        }
    }
}
