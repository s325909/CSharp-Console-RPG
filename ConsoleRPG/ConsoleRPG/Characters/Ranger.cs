using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public class Ranger : Character
    {
        // Constructor
        public Ranger()
        {
            // Character Base Attributes & Gains (STR, DEX, INT)
            AddAttributes(1, 7, 1);
            LevelGains = new[] { 1, 5, 1 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Leather", "Mail" };
            EquipableWeaponTypes = new[] { "Bow" };
        }
    }
}
