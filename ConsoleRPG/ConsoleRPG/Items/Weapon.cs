using System;
using ConsoleRPG.Attributes;

namespace ConsoleRPG.Items
{
    public class Weapon : Item
    {
        // Properties
        public double DamagePerSecond { get; set; }
        public WeaponAttribute Attributes { get; set; } 

        // Constructor
        public Weapon(string name, string type, string slot, int level, WeaponAttribute attributes) : base(name, type, slot, level)
        {
            Attributes = attributes;
            DamagePerSecond = attributes.BaseDamage * attributes.AttackSpeed;
        }
    }
}
