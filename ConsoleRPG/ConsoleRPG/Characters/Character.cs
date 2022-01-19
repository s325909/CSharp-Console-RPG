using System;
using ConsoleRPG.Attributes;
using ConsoleRPG.Exceptions;
using ConsoleRPG.Items;

namespace ConsoleRPG.Characters
{
    public abstract class Character : IAttribute, IEquip
    {
        // Properties for Character Class
        public string ClassName { get; set; }
        public int Level { get; set; } = 1;
        public int[] LevelGains { get; set; }

        public PrimeAttribute BaseAttributes { get; set; }
        public PrimeAttribute ArmorAttributes { get; set; }  
        public PrimeAttribute TotalAttributes { get; set; }

        public WeaponAttribute WeaponAttribute { get; set; }

        public Equipment Equipment { get; set; } 

        // Constructors
        public Character() 
        {
            InitCharacter();
            Console.WriteLine($"\nA {ClassName} is born!\n");
        }

        private void InitCharacter()
        {
            // Get name of character class
            ClassName = GetType().Name;

            // Init Attributes
            BaseAttributes = new();
            ArmorAttributes = new();
            WeaponAttribute = new();

            // TotalAttributes = new();

            // Init Equipment
            Equipment = new();
        }

        public void TotalDamge ()
        {
            switch (ClassName)
            {
                case "Warior":
                    // damage += BaseAttributes.Strenght * 1 %; 
                    break;
                default:
                    break;
            }
        }

        public void AddAttributes(int STR, int DEX, int INT)
        {
            BaseAttributes.Strenght += STR;
            BaseAttributes.Dexterity += DEX;
            BaseAttributes.Intelligence += INT;
        }

        public void GainAttributes()
        {
            int STR = LevelGains[0];
            int DEX = LevelGains[1];
            int INT = LevelGains[2];
            AddAttributes(STR, DEX, INT);

            Level++;
            ShowAttributes();
        }

        public void ShowAttributes()
        {
            // Console.WriteLine($"Class: {ClassName} | Level: {Level}" +
            //   $"\nStrength: {Strenght}\nDexterity: {Dexterity}\nIntelligence: {Intelligence}");

            Console.WriteLine($"Class: {ClassName} | Level: {Level}\n" +
                $"Strength: {BaseAttributes.Strenght}\n" +
                $"Dexterity: {BaseAttributes.Dexterity}\n" +
                $"Intelligence: {BaseAttributes.Intelligence}\n");
        }

        public void Equip()
        {
            Console.WriteLine("Equipment equipped!");
        }

        public void ShowEquiped()
        {
            Console.WriteLine(Equipment.ToString());
            
            /**
            // print the equipment dictionary to console
            string equipment = "";
            foreach (KeyValuePair<string, string> kvp in Equipment)
            {
                equipment += string.Format("| {0} Slot: {1}", kvp.Key, kvp.Value);
            }
            // Console.WriteLine(equipment + " |");
            **/
        }

        public string EquipableItem(Item item)
        {
            int level = item.ItemLevel;
            string slot = item.ItemSlot;

            // check if item is armor or weapon
            bool isArmor = CheckEquipableArmor(slot);
            bool isWeapon = CheckEquipableWeapon(slot);

            if (isArmor)
            {
                // Custom error thrown if armor ItemLevel is too high
                if (Level < level) throw new InvalidArmorException("Armor level requirment not met!");

                // Custom error thrown if armor ItemType is not equipable 
                // if ()

                return "New Weapon Equipped!";
            }

            if (isWeapon)
            {
                // Custom error thrown if weapon ItemLevel is too high
                if (Level < level) throw new InvalidArmorException("Armor level requirment not met!");

                // Custom error thrown if weapon ItemType is not equipable 
                // if ()

                return "New Armor Equipped!";
            }

            return "Item not Equipable";
        }

        private bool CheckEquipableArmor(string slot) 
        {
            if (!slot.Equals("Weapon")) return true;
            return false;
        }
        private bool CheckEquipableWeapon(string slot)
        {
            if (slot.Equals("Weapon")) return true;
            return false;
        }
    }
}
