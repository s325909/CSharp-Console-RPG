using System;
using System.Collections.Generic;
using ConsoleRPG.Attributes;


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
            string rarity = "[Common]";

            foreach (string armor in armors)
            {
                if (level > 1) rarity = "[Rare]";
                if (level > 5) rarity = "[Legendary]";

                Helmets.Add(new Armor(rarity + " Helmet", armor, slots[0], level));
                BodyPlates.Add(new Armor(rarity + " Chest Plate", armor, slots[1], level));
                Leggings.Add(new Armor(rarity + " Leggings", armor, slots[2], level));

                level += 2;   
            }


            foreach (string weapon in weapons)
            {
                level = 1;

                Weapons.Add(new Weapon("[Common] " + weapon, weapon, slots[3], level, new WeaponAttribute(5, 1.1)));
                Weapons.Add(new Weapon("[Rare] " + weapon, weapon, slots[3], level += 4, new WeaponAttribute(50, 5.5)));
                Weapons.Add(new Weapon("[Legendary] " + weapon, weapon, slots[3], level += 5, new WeaponAttribute(125, 10.0)));

                // level += 2;
            }
        }

        public void PrintEquipments()
        {
            Console.WriteLine("\n");

            foreach (Armor armor in Helmets)
            {
                Console.WriteLine("Helmet " + armor.ToString() + " | STATS: STR: " + armor.Attributes.Strenght + " DEX: " + armor.Attributes.Dexterity + " INT: " + armor.Attributes.Intelligence + " |\n");
            }

            foreach (Armor armor in BodyPlates) 
            {
                Console.WriteLine("Helmet " + armor.ToString() + " | STATS: STR: " + armor.Attributes.Strenght + " DEX: " + armor.Attributes.Dexterity + " INT: " + armor.Attributes.Intelligence + " |\n");
            }

            foreach (Armor armor in Leggings) 
            {
                Console.WriteLine("Helmet " + armor.ToString() + " | STATS: STR: " + armor.Attributes.Strenght + " DEX: " + armor.Attributes.Dexterity + " INT: " + armor.Attributes.Intelligence + " |\n");
            }

            Console.WriteLine("\n");

            foreach (Weapon weapon in Weapons) { Console.WriteLine( "Weapon: " + weapon.ToString() + " | DPS: " + weapon.DamagePerSecond); }
        }
    }
}
