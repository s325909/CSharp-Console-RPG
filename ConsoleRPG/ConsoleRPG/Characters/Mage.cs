using System;
using System.Collections.Generic;
using ConsoleRPG.Items;

namespace ConsoleRPG.Characters
{
    public class Mage : Character
    {
        // Constructor
        public Mage(string name) : base(name)
        {
            // Character Base Attributes & Gains (STR, DEX, INT)
            AddAttributes(1, 1, 8);
            LevelGains = new[] { 1, 1, 5 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Cloth" };
            EquipableWeaponTypes = new[] { "Staff", "Wand" };
        }

        public override double CalculateTotalDamage()
        {
            double dps = 1;

            var weapon = (Weapon)Equipment.EquipmentSlots["Weapon"];

            if (weapon != null) dps = weapon.DamagePerSecond;

            return dps * (1 + (double)TotalAttributes.Intelligence / 100);
        }
    }
}
