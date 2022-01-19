using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine(slot);
            }
        }
    }
}
