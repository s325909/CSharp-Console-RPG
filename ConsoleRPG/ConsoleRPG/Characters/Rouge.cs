using System;
using System.Collections.Generic;
using ConsoleRPG.Items;

namespace ConsoleRPG.Characters
{
    public class Rouge : Character
    {
        // Constructor
        public Rouge(string name) : base(name)
        {
            // Character Base Attributes & Gains (STR, DEX, INT)
            AddAttributes(2, 6, 1);
            LevelGains = new[] { 1, 4, 1 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Leather", "Mail" };
            EquipableWeaponTypes = new[] { "Dagger", "Sword" };
        }
        public override double CalculateTotalDamage()
        {
            double dps = 1;

            var weapon = (Weapon)Equipment.EquipmentSlots["Weapon"];

            if (weapon != null) dps = weapon.DamagePerSecond;

            return dps * (1 + (double)TotalAttributes.Dexterity / 100);
        }
    }
}
