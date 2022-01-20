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

            string[] rarity = { "[Common]", "[Rare]", "[Epic]", "[Legendary]"};

            int type = 0; 
            int level = 1;
            foreach (string armor in armors)
            {
                if (type == 0)
                {
                    AddHelmets(rarity, armor, slots[0], level);
                    AddBodyPlates(rarity, armor, slots[1], level);
                    AddLeggings(rarity, armor, slots[2], level);
                }

                if (type == 1)
                {
                    AddHelmets(rarity, armor, slots[0], level);
                    AddBodyPlates(rarity, armor, slots[1], level);
                    AddLeggings(rarity, armor, slots[2], level);
                }

                if (type == 2)
                {
                    AddHelmets(rarity, armor, slots[0], level);
                    AddBodyPlates(rarity, armor, slots[1], level);
                    AddLeggings(rarity, armor, slots[2], level);
                }

                if (type == 3)
                {
                    AddHelmets(rarity, armor, slots[0], level);
                    AddBodyPlates(rarity, armor, slots[1], level);
                    AddLeggings(rarity, armor, slots[2], level);
                }

                level = 1;
                type++;
            }

            foreach (string weapon in weapons)
            {
                //int level = 1;
                level = 1;

                Weapons.Add(new Weapon("[Common] " + weapon, weapon, slots[3], level, new WeaponAttribute(5, 1.1)));
                Weapons.Add(new Weapon("[Rare] " + weapon, weapon, slots[3], level += 4, new WeaponAttribute(50, 5.5)));
                Weapons.Add(new Weapon("[Legendary] " + weapon, weapon, slots[3], level += 5, new WeaponAttribute(125, 10.0)));

                // level += 2;
            }
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
                Console.WriteLine($"({count}): " + armor.ToString() + PrintArmorStats(armor));
                count++;
            }   
        }
        public void PrintBodyPlates()
        {
            int count = 0;
            foreach (Armor armor in BodyPlates)
            {
                Console.WriteLine($"({count}): " + armor.ToString() + PrintArmorStats(armor));
                count++;
            }
        }
        public void PrintLeggings()
        {
            int count = 0;
            foreach (Armor armor in Leggings)
            {
                Console.WriteLine($"({count}): " + armor.ToString() + PrintArmorStats(armor));
                count++;
            }
        }

        private string PrintArmorStats(Armor armor)
        {
            return " Stats: [ STR: " + armor.Attributes.Strenght + " DEX: " + armor.Attributes.Dexterity + " INT: " + armor.Attributes.Intelligence + " ]\n";
        }

        public void PrintWeapons()
        {
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine("Weapon: " + weapon.ToString() + " | DPS: " + weapon.DamagePerSecond);
            }
        }

        public override string ToString()
        {
            string str = "Equipped: ";

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
    }
}
