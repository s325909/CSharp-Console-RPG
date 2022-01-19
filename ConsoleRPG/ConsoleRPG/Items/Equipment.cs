using System;
using System.Collections.Generic;


namespace ConsoleRPG.Items
{
    public class Equipment
    {
        // Properties
        public EquipSlots Slots { get; set; }
        public Dictionary<string, Item> EquipmentSlots { get; set; }

        // Equipment Slots 
        public enum EquipSlots { Head, Body, Legs, Weapon }

        // Constructor
        public Equipment()
        {
            Console.WriteLine("FROM Equip CLASS");

            EquipmentSlots = new();
            String[] slots = Enum.GetNames(typeof(EquipSlots));

            foreach(string slot in slots)
            {
                EquipmentSlots.Add(slot, null);
                // EquipmentSlots.Add(slot, new Item(3, "BASIC SWORD", "HEAD", "SWORD"));
                Console.WriteLine(slot);
            }
            
            /**
            if (EquipmentSlots.ContainsKey("Head")) // && obj != null
            {
                Item item = EquipmentSlots["Head"];
                if (item != null) Console.WriteLine("HEAD ITEM: " + item.ToString());
                else Console.WriteLine("NO HEAD ITEM");

                // Console.WriteLine("HEAD: " + con.ToString());
            }
            **/
        }
    }
}
