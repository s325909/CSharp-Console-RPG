using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Items
{
    public abstract class Item
    {
        // Properties
        public int ItemLevel { get; set; }
        public string ItemName { get; set; }
        public string ItemSlot { get; set; }
        public string ItemType { get; set; }

        // Constructor
        public Item(int level, string name, string slot, string type)
        {
            ItemLevel = level;
            ItemName = name;
            ItemSlot = slot;
            ItemType = type;
        }
    }
}
