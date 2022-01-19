using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public class Mage : Character
    {
        // Constructor
        public Mage()
        {
            // Character Base Attributes & Gains (STR, DEX, INT)
            AddAttributes(1, 1, 8);
            LevelGains = new[] { 1, 1, 5 };

            // Character Equipable Armor & Weapon Types 
            EquipableArmorTypes = new[] { "Cloth" };
            EquipableWeaponTypes = new[] { "Staff", "Wand" };
        }
    }
}
