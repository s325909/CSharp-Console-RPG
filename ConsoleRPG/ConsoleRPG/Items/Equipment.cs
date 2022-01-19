using System;
using System.Collections.Generic;


namespace ConsoleRPG.Items
{
    public class Equipment
    {
        // Properties
        public EquipSlots Slots { get; set; }
        public Dictionary<string, Item> EquipmentSlots { get; set; }

        public List<Armor> Helmets { get; set; } 
        public List<Armor> BodyPlates { get; set; }
        public List<Armor> Leggings { get; set; }

        public List<Weapon> Weapons { get; set; }

        // Constructor
        public Equipment()
        {
            InitBaseEquipments();

            EquipmentSlots = new();

            String[] slots = Enum.GetNames(typeof(EquipSlots));

            foreach(string slot in slots) { EquipmentSlots.Add(slot, null); }
        }

        // Equipment Slots and Types
        public enum EquipSlots { Head, Body, Legs, Weapon }
        public enum ArmorTypes { Cloth, Leather, Mail, Plate }
        public enum WeaponTypes { Axe, Bow, Dagger, Hammer, Staff, Sword, Wand }


        /// <summary>
        /// Method to add basic sets of equipment for each slot
        /// </summary>
        private void InitBaseEquipments()
        {
            Helmets = new();
            BodyPlates = new();
            Leggings = new();
            Weapons = new();

            String[] slots = Enum.GetNames(typeof(EquipSlots));
            String[] armors = Enum.GetNames(typeof(ArmorTypes));
            String[] weapons = Enum.GetNames(typeof(WeaponTypes));

            int level = 1;
            foreach (string armor in armors)
            {
                Helmets.Add(new Armor("[Common] Helmet", armor, slots[0], level));
                BodyPlates.Add(new Armor("[Common] Chest Plate", armor, slots[1], level));
                Leggings.Add(new Armor("[Common] Leggings", armor, slots[2], level));

                level += 2;   
            }


            foreach (string weapon in weapons)
            {
                level = 1;

                Weapons.Add(new Weapon("[Common] " + weapon, weapon, slots[3], level));
                Weapons.Add(new Weapon("[Rare] " + weapon, weapon, slots[3], level += 4));
                Weapons.Add(new Weapon("[Legendary] " + weapon, weapon, slots[3], level += 5));

                // level += 2;
            }
        }

        public void PrintEquipments()
        {
            Console.WriteLine("\n");

            foreach (Armor armor in Helmets) { Console.WriteLine("Helmet " + armor.ToString()); }
                 
            Console.WriteLine("\n");

            foreach (Armor armor in BodyPlates) { Console.WriteLine("Body: " + armor.ToString()); }

            Console.WriteLine("\n");

            foreach (Armor armor in Leggings) { Console.WriteLine("Legging " + armor.ToString()); }

            Console.WriteLine("\n");

            foreach (Weapon weapon in Weapons) { Console.WriteLine("Weapon: " + weapon.ToString()); }
        }
    }
}
