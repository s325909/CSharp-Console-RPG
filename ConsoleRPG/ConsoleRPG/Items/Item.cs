using System;

namespace ConsoleRPG.Items
{
    public abstract class Item
    {
        // Properties
        public string ItemTypeName { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string ItemSlot { get; set; }
        public int ItemLevel { get; set; }

        // Constructor
        public Item(string name, string type, string slot, int level)
        {
            ItemTypeName = GetType().Name;
            ItemName = name;
            ItemType = type;
            ItemSlot = slot;
            ItemLevel = level;
        }

        public override string ToString()
        {
            return $"Type: {ItemType} {ItemSlot} | LVL {ItemLevel} {ItemName} |";
        }
    }
}
