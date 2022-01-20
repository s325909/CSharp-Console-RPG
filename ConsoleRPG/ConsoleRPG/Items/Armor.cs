using System;
using System.Collections.Generic;
using ConsoleRPG.Attributes;

namespace ConsoleRPG.Items
{
    public class Armor : Item
    {
        // Properties
        public PrimeAttribute Attributes { get; set; }
        // public string[] Armors { get; set; }


        // Constructor
        public Armor(string name, string type, string slot, int level) : base(name, type, slot, level)
        {
            // Armors = Enum.GetNames(typeof(ArmorTypes));
            Attributes = CalculateArmorAttributes(type, level);
        }

        // Armor Types
        public enum ArmorTypes { Cloth, Leather, Mail, Plate}

        protected PrimeAttribute CalculateArmorAttributes(string type, int level)
        {
            int STR, DEX, INT;
            STR = DEX = INT = 1 * level;

            switch (type)
            {
                case "Cloth":
                    return new(STR, DEX, INT);
                case "Leather":
                    STR = DEX = INT = 2 * level;
                    return new(STR, DEX, INT);
                case "Mail":
                    STR = DEX = 3 * level;
                    INT = 2;
                    return new(STR, DEX, INT);
                case "Plate":
                    STR = 7 * level;
                    DEX = 2;
                    INT = 1;
                    return new(STR, DEX, INT);
                default:
                    return new(STR, DEX, INT);
            }
        }
    }
}