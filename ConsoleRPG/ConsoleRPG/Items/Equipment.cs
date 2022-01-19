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
            


            /** 
            // Dictionary<String, Item>
            EquipmentSlots = new();


            EquipmentSlots.Add(EquipSlots.Body, null);
            EquipmentSlots.Add(EquipSlots.Legs, null);

            foreach (var value in EquipmentSlots.Values)
            {
                Console.WriteLine("Value of the Dictionary Item is: {0}", value);
            }

            Console.WriteLine("CLASS EQUIP");

            foreach (EquipSlots slot in Enum.GetValues(typeof(EquipSlots)))
            {
                Console.WriteLine(slot.ToString());
                Console.WriteLine(slot);
            }



            EquipmentSlots.Add(EquipSlots.Head.ToString(), null);

            Console.WriteLine("eQUIPMENT CLASS");
            Console.WriteLine(EquipSlots.Body);
            // Console.WriteLine(EquipmentSlots[0]);

            
            /**
            EquipmentSlots.Add(EquipSlots.Head, "HELMET");
            EquipmentSlots.Add(EquipSlots.Body, " ");
            EquipmentSlots.Add(EquipSlots.Legs, " ");
            EquipmentSlots.Add(EquipSlots.Weapon, " sWORD");
            **/
        }

        // Slots
        public enum EquipSlots 
        {
            Head, Body, Legs, Weapon
        }
    }
}
