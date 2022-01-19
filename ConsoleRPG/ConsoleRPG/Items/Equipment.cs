using System;
using System.Collections.Generic;


namespace ConsoleRPG.Items
{
    public class Equipment
    {
        // Properties
        public EquipSlots Slots { get; set; }
        public Dictionary<string, Item> EquipmentSlots { get; set; }

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

            EquipmentSlots[EquipSlots.Head.ToString()] = new Armor("Iron Helmet", "Head",  5);

            EquipmentSlots[EquipSlots.Weapon.ToString()] = new Weapon("Iron Sword", "Weapon", 5);

            //EquipmentSlots.
            
            
            if (EquipmentSlots.ContainsKey("Head")) // && obj != null
            {
                Item item = EquipmentSlots["Head"];
                if (item != null) Console.WriteLine("HEAD ITEM: " + item.ToString());
                else Console.WriteLine("NO HEAD ITEM");

                // Console.WriteLine("HEAD: " + con.ToString());
            }

            if (EquipmentSlots.ContainsKey("Body")) // && obj != null
            {
                Item item = EquipmentSlots["Body"];
                if (item != null) Console.WriteLine("Body ITEM: " + item.ToString());
                else Console.WriteLine("NO Body ITEM");

                // Console.WriteLine("HEAD: " + con.ToString());
            }

            if (EquipmentSlots.ContainsKey("Weapon")) // && obj != null
            {
                Item item = EquipmentSlots["Weapon"];
                if (item != null) Console.WriteLine("Weapon ITEM: " + item.ToString());
                else Console.WriteLine("NO Weapon ITEM");

                // Console.WriteLine("HEAD: " + con.ToString());
            }

        }

        // Equipment Slots 
        public enum EquipSlots { Head, Body, Legs, Weapon }
    }
}
