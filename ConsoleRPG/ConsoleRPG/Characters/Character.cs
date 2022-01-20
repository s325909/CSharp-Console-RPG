using System;
using ConsoleRPG.Attributes;
using ConsoleRPG.Exceptions;
using ConsoleRPG.Items;

namespace ConsoleRPG.Characters
{
    public abstract class Character : IAttribute, IEquip
    {
        // Properties for Character Class
        public string CharacterName { get; set; } 
        public string ClassName { get; set; }
        public int Level { get; set; } = 1;

        public int[] LevelGains { get; set; }
        public string[] EquipableArmorTypes { get; set; }
        public string[] EquipableWeaponTypes { get; set; }

        public Equipment Equipment { get; set; }

        public PrimeAttribute BaseAttributes { get; set; }
        public PrimeAttribute ArmorAttributes { get; set; }  
        public PrimeAttribute TotalAttributes { get; set; }

        public WeaponAttribute WeaponAttribute { get; set; }


        // Constructors
        public Character(string name) 
        {
            InitCharacter(name);
            Console.WriteLine($"\nA {ClassName} is born!\n");
        }

        private void InitCharacter(string name)
        {
            // Name of character and class
            CharacterName = name;
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
            Console.WriteLine($"" +
                $"\n[ {CharacterName} | Level {Level} | {ClassName} ]" +
                $"\n[ Strength: {BaseAttributes.Strenght} ]" +
                $"\n[ Dexterity: {BaseAttributes.Dexterity} ]" +
                $"\n[ Intelligence: {BaseAttributes.Intelligence} ]");
        }

        public string EquipableItemCheck(Item item)
        {
            int level = item.ItemLevel;
            string slot = item.ItemSlot;

            // check if item is armor or weapon
            bool isArmor = CheckEquipableArmor(slot);
            bool isWeapon = CheckEquipableWeapon(slot);
            // bool isArmor, isWeapon = CheckEquipmentType(slot).Item1;

            if (isArmor)
            {
                // Custom error thrown if armor ItemLevel is too high
                if (Level < level) 
                    throw new InvalidArmorException("Armor level requirment not met!");

                // Custom error thrown if armor ItemType is not equipable 
                if (!Array.Exists(EquipableArmorTypes, type => type == item.ItemType))
                    throw new InvalidArmorException("Armor type is not equipable for the character class!");

                // Equip item to Equipment (Dictionary) 
                Equipment.EquipmentSlots[slot] = item;

                Console.WriteLine($"\n{item.ItemName} Equipped!\n"); 

                return $"New Armor: {item.ItemName} Equipped!";
            }

            if (isWeapon)
            {
                // Custom error thrown if weapon ItemLevel is too high
                if (Level < level) throw new InvalidArmorException("Armor level requirment not met!");

                // Custom error thrown if weapon ItemType is not equipable 
                if (!Array.Exists(EquipableWeaponTypes, type => type == slot))
                    throw new InvalidArmorException("Weapon type is not equipable for the character class!");

                // Equip item to Equipment (Dictionary) 
                Equipment.EquipmentSlots[slot] = item;

                return $"New Weapon: {item.ItemName} Equipped!";
            }

            return "Item not Equipable...";
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
        private Tuple<bool, bool> CheckEquipmentType(string slot)
        {
            bool isArmor, isWeapon;
            isArmor = isWeapon = false;

            if (!slot.Equals("Weapon")) isArmor = true;
            if (slot.Equals("Weapon")) isWeapon = true;

            return Tuple.Create(isArmor, isWeapon);
        }
    }
}
