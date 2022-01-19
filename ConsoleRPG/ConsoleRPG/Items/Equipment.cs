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
            Console.WriteLine("FROM Equip CLASS");

            EquipmentSlots = new();
            String[] slots = Enum.GetNames(typeof(EquipSlots));

            foreach(string slot in slots)
            {
                EquipmentSlots.Add(slot, null);
                // EquipmentSlots.Add(slot, new Item(3, "BASIC SWORD", "HEAD", "SWORD"));
                Console.WriteLine(slot);
            }

            InitBaseEquipments();

            // PrintArmors();
        }

        // Equipment Slots and Types
        public enum EquipSlots { Head, Body, Legs, Weapon }
        public enum ArmorTypes { Cloth, Leather, Mail, Plate }
        public enum WeaponTypes { Axe, Bow, Dagger, Hammer, Staff, Sword, Wand }


        /// <summary>
        /// Method do add basic sets of armors for each slot
        /// </summary>
        private void InitBaseEquipments()
        {
            Helmets = new();
            BodyPlates = new();
            Leggings = new();

            String[] slots = Enum.GetNames(typeof(EquipSlots));
            String[] armors = Enum.GetNames(typeof(ArmorTypes));



            foreach (string slot in slots)
            {
                if (slot.Equals("Weapon")) break;

                int level = 1;
                foreach (string armor in armors)
                {
                    Helmets.Add(new Armor("Helmet", armor, slot, level));
                    BodyPlates.Add(new Armor("Chest Plate", armor, slot, level));
                    Leggings.Add(new Armor("Leggings", armor, slot, level));

                    level += 2;
                }
            }
        }

        public void PrintArmors()
        {
            foreach (Armor armor in Helmets)
            {
                Console.WriteLine("Helmet " + armor.ToString());
            }

            foreach (Armor armor in BodyPlates)
            {
                Console.WriteLine("Body: " + armor.ToString());
            }

            foreach (Armor armor in Leggings)
            {
                Console.WriteLine("Legging " + armor.ToString());
            }
        }
    }
}
