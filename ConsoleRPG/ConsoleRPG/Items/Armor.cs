using System;
using System.Collections.Generic;

namespace ConsoleRPG.Items
{
    public class Armor : Item
    {

        // Properties
        public string[] Armors { get; set; }


        // Constructor
        public Armor(string name, string type, string slot, int level) : base(name, type, slot, level)
        {
            Armors = Enum.GetNames(typeof(ArmorTypes));
        }

        // Armor Types
        public enum ArmorTypes { Cloth, Leather, Mail, Plate}
    }
}