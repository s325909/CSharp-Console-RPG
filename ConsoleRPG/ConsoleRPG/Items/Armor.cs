using System;

namespace ConsoleRPG.Items
{
    public class Armor : Item
    {
        // Properties
        public string[] Armors { get; set; }

        // Constructor
        public Armor(string name, string slot, int level) : base(name, slot, level)
        {
            Armors = Enum.GetNames(typeof(ArmorTypes));
            foreach (string armor in Armors)
            {
                Console.WriteLine("Armor Type: " + armor);
            }
        }

        // Armor Types
        public enum ArmorTypes { Cloth, Leather, Mail, Plate}
    }
}