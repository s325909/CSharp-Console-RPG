using System;
using System.Collections.Generic;

namespace ConsoleRPG.Items
{
    public class Weapon : Item
    {
        // Properties
        public string[] Weapons { get; set; }

        // Constructor
        public Weapon(string name, string type, string slot, int level) : base(name, type, slot, level)
        {

        }
    }
}
