using System;
using ConsoleRPG.Items;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {   
        // Constructor
        public Warrior(string name) : base(name)
        {
            // Character Base Attributes & Gains (STR, DEX, INT)
            AddAttributes(5, 2, 1);
            LevelAttributeGains = new[] { 3, 2, 1 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Mail", "Plate" };
            EquipableWeaponTypes = new[] { "Axe", "Hammer", "Sword" };
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

            // each point of strength increases a Warriors damage by 1 %
            return dps * (1 + (double)TotalAttributes.Strenght / 100);
        }
    }
}
