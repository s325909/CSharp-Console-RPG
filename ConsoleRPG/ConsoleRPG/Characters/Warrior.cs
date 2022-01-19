using System;

namespace ConsoleRPG.Characters
{
    public class Warrior : Character
    {   
        // Constructor
        public Warrior()
        {
            // Character Base Attributes & Gains (STR, DEX, INT)
            AddAttributes(5, 2, 1);
            LevelGains = new[] { 3, 2, 1 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Axe", "Hammer", "Sword" };
            EquipableWeaponTypes = new[] { "Mail", "Plate" };
        }
    }
}
