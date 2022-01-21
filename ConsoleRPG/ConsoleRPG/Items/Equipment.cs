using System;
using System.Collections.Generic;
using ConsoleRPG.Attributes;


namespace ConsoleRPG.Items
{
    public class Equipment
    {
        // Properties
        public string[] Slots { get; set; }
        public Dictionary<string, Item> EquipmentSlots { get; set; }
        public List<Armor> Helmets { get; set; }
        public List<Armor> BodyPlates { get; set; }
        public List<Armor> Leggings { get; set; }
        public List<Weapon> Weapons { get; set; }

        // Constructor
        public Equipment()
        {
            InitBaseEquipments();
        }

        // Equipment Slots and Types
        public enum EquipSlots { Head, Body, Legs, Weapon }
        public enum ArmorTypes { Cloth, Leather, Mail, Plate }
        public enum WeaponTypes { Axe, Bow, Dagger, Hammer, Staff, Sword, Wand }


        /// <summary>
        /// Method to add and generate basic sets of equipment for each slot
        /// </summary>
        private void InitBaseEquipments()
        {
            // Init lists of items to store equipments 
            EquipmentSlots = new();
            Helmets = new();
            BodyPlates = new();
            Leggings = new();
            Weapons = new();

            // Assign equipment slots to slots array
            Slots = Enum.GetNames(typeof(EquipSlots));

            // Init Slots in Equipment Slots Dictionary as null value
            foreach (string slot in Slots) { EquipmentSlots.Add(slot, null); }

            // rarity and types of equipment
            string[] rarity = { "[Common]", "[Rare]", "[Epic]", "[Legendary]" };
            string[] armors = Enum.GetNames(typeof(ArmorTypes));
            string[] weapons = Enum.GetNames(typeof(WeaponTypes));

            // Generate basic sets of armor equipment of rarity for each armor slot and type
            foreach (string armor in armors) { GenerateBasicArmorSets(rarity, armor); }

            // Generate basic weapons of rarity for each weapon slot and type
            foreach (string weapon in weapons)
            {
                int level = 1;

                Weapons.Add(new Weapon("[Common] " + weapon, weapon, Slots[3], level, new WeaponAttribute(5, 1.1)));
                Weapons.Add(new Weapon("[Rare] " + weapon, weapon, Slots[3], level += 4, new WeaponAttribute(50, 5.5)));
                Weapons.Add(new Weapon("[Legendary] " + weapon, weapon, Slots[3], level += 5, new WeaponAttribute(125, 10.0)));
                // level += 2;
            }
        }

        private void GenerateBasicArmorSets(string[] rarity, string armor)
        {
            // Console.WriteLine($"ADDING 3 {armor} ARMOR");
            AddHelmets(rarity, armor, Slots[0], 1);
            AddBodyPlates(rarity, armor, Slots[1], 1);
            AddLeggings(rarity, armor, Slots[2], 1);
        }

        private void AddHelmets(string[] rarity, string armor, string slot, int level)
        {
            AddArmor(Helmets, rarity[0] + " Helmet", armor, slot, level);
            AddArmor(Helmets, rarity[1] + " Helmet", armor, slot, level += 2);
            AddArmor(Helmets, rarity[2] + " Helmet", armor, slot, level += 2);
            // AddArmor(Helmets, rarity[3] + " Helmet", armor, slot, level += 5);
        }
        private void AddBodyPlates(string[] rarity, string armor, string slot, int level)
        {
            AddArmor(BodyPlates, rarity[0] + " Chest Plate", armor, slot, level);
            AddArmor(BodyPlates, rarity[1] + " Chest Plate", armor, slot, level += 2);
            AddArmor(BodyPlates, rarity[2] + " Chest Plate", armor, slot, level += 2);
            // AddArmor(Helmets, rarity[3] + " Helmet", armor, slot, level += 5);
        }
        private void AddLeggings(string[] rarity, string armor, string slot, int level)
        {
            AddArmor(Leggings, rarity[0] + " Leggings", armor, slot, level);
            AddArmor(Leggings, rarity[1] + " Leggings", armor, slot, level += 2);
            AddArmor(Leggings, rarity[2] + " Leggings", armor, slot, level += 2);
            // AddArmor(Helmets, rarity[3] + " Helmet", armor, slot, level += 5);
        }

        private void AddArmor(List<Armor> armors, string name, string type, string slot, int level)
        {
            armors.Add(new Armor(name, type, slot, level));
        }

        public void PrintEquipments()
        {
            Console.WriteLine("\n");

            PrintHelmets();

            PrintBodyPlates();

            PrintLeggings();

            Console.WriteLine("\n");

            PrintWeapons();
        }
        public void PrintHelmets()
        {
            int count = 0;
            foreach (Armor armor in Helmets) 
            {
                Console.WriteLine($"\n({count}): " + armor.ToString() + PrintArmorStats(armor));
                count++;
            }   
        }
        public void PrintBodyPlates()
        {
            int count = 0;
            foreach (Armor armor in BodyPlates)
            {
                Console.WriteLine($"\n({count}): " + armor.ToString() + PrintArmorStats(armor));
                count++;
            }
        }
        public void PrintLeggings()
        {
            int count = 0;
            foreach (Armor armor in Leggings)
            {
                Console.WriteLine($"\n({count}): " + armor.ToString() + PrintArmorStats(armor));
                count++;
            }
        }

        public void PrintWeapons()
        {
            int count = 0;
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine($"\n({count}): " + weapon.ToString() + " | DPS: " + weapon.DamagePerSecond);
                count++;
            }
        }

        public override string ToString()
        {
            string str = "Items Equipped: ";

            String[] slots = Enum.GetNames(typeof(EquipSlots));
            foreach (string slot in slots) 
            {
                var equipment = EquipmentSlots[slot];
                if (equipment != null)
                    str += "\n" + equipment.ToString();
                else str += $"\n{slot}: NONE";
            }
            return str;
        }

        private string PrintArmorStats(Armor armor)
        {
            return " Stats: [ STR: " + armor.Attributes.Strenght + " DEX: " + armor.Attributes.Dexterity + " INT: " + armor.Attributes.Intelligence + " ]\n";
        }
    }
}
