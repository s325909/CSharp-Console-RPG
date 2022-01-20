using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
