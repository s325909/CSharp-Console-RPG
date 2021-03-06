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
            LevelAttributeGains = new[] { 1, 4, 1 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Leather", "Mail" };
            EquipableWeaponTypes = new[] { "Dagger", "Sword" };
        }

        /// <summary>
        /// Calculates total damage based on character and weapon attributes 
        /// </summary>
        /// <returns>Total Damage Per Second</returns>
        public override double CalculateTotalDamage()
        {
            // weapon item from equipment slot
            var weapon = (Weapon)Equipment.EquipmentSlots["Weapon"];

            // damage per second from equipped weapon or assign 1 as base damage
            double dps = (weapon is null) ? 1 : weapon.DamagePerSecond;

            // each point of dexterity increases a Rouges damage by 1 %
            return dps * (1 + (double)TotalAttributes.Dexterity / 100);
        }
    }
}
