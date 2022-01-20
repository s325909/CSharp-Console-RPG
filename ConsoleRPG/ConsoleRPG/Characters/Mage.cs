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
            // Character Base Attributes & Level Gains (STR, DEX, INT)
            AddAttributes(1, 1, 8);
            LevelAttributeGains = new[] { 1, 1, 5 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Cloth" };
            EquipableWeaponTypes = new[] { "Staff", "Wand" };
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

            // each point of intelligence increases a Mages damage by 1 %
            return dps * (1 + (double)TotalAttributes.Intelligence / 100);
        }
    }
}
