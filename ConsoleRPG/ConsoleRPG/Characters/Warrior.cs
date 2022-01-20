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
            LevelGains = new[] { 3, 2, 1 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Mail", "Plate" };
            EquipableWeaponTypes = new[] { "Axe", "Hammer", "Sword" };
        }
        public override double CalculateTotalDamage()
        {
            double dps = 1;

            var weapon = (Weapon)Equipment.EquipmentSlots["Weapon"];

            if (weapon != null) dps = weapon.DamagePerSecond;

            return dps * (1 + (double)TotalAttributes.Strenght / 100);
        }
    }
}
