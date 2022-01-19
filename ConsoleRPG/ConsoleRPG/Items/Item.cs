using System;

namespace ConsoleRPG.Items
{
    public abstract class Item
    {
        // Properties
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public string ItemSlot { get; set; }
        public int ItemLevel { get; set; }

        // Constructor
        public Item(string name, string slot, int level)
        {
            ItemType = GetType().Name;
            ItemName = name;
            ItemSlot = slot;
            ItemLevel = level;
        }

        public override string ToString()
        {
            return $"Type: {ItemType} | Name: {ItemName} | Slot: {ItemSlot} | LVL: {ItemLevel}";
        }
    }
}
