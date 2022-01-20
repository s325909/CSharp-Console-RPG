using System;
using System.Text;
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
        public string[] EquipmentSlots { get; set; }
        public string[] EquipableArmorTypes { get; set; }
        public string[] EquipableWeaponTypes { get; set; }

        public Equipment Equipment { get; set; }
        public PrimeAttribute TotalAttributes { get; set; }
        public PrimeAttribute BaseAttributes { get; set; }
        public PrimeAttribute ArmorAttributes { get; set; }  
        public WeaponAttribute WeaponAttributes { get; set; }

        // Constructors
        public Character(string name) 
        {
            InitCharacter(name);
        }

        private void InitCharacter(string name)
        {
            // Init Name of Character and Class
            CharacterName = name;
            ClassName = GetType().Name; 

            // Init Character Attributes
            BaseAttributes = new();
            ArmorAttributes = new();
            WeaponAttributes = new();
            TotalAttributes = new();

            // Init Character Equipment and Slots
            Equipment = new();
            EquipmentSlots = Enum.GetNames(typeof(Equipment.EquipSlots));
        }

        public abstract double CalculateTotalDamage();

        public PrimeAttribute CalculateTotalAttributes()
        {
            // adds base primary attributes of character to total attributes
            TotalAttributes = new();
            TotalAttributes.AddAttributes(BaseAttributes);

            foreach (string slot in EquipmentSlots)
            {
                // assign equipment as each Item in EqupmentSlots
                var equipment = Equipment.EquipmentSlots[slot];

                // if equipment type of Item is of Armor class   
                if (equipment != null && equipment.GetType().Name.Equals("Armor"))
                {
                    // adds primary attributes from each equipped armor to total attributes 
                    Armor armor = (Armor) equipment;
                    TotalAttributes.AddAttributes(armor.Attributes);
                }
            }
            return TotalAttributes;
        }

        public string PrintTotalAttributes()
        {
            CalculateTotalAttributes();
            return $"STR: {TotalAttributes.Strenght} | DEX: {TotalAttributes.Dexterity} | INT: {TotalAttributes.Intelligence}";
        }
        public void GainLevelAndAttributes()
        {
            int STR = LevelGains[0];
            int DEX = LevelGains[1];
            int INT = LevelGains[2];
            AddAttributes(STR, DEX, INT);

            Level++;
            ShowAttributes();
        }

        public void AddAttributes(int STR, int DEX, int INT)
        {
            BaseAttributes.Strenght += STR;
            BaseAttributes.Dexterity += DEX;
            BaseAttributes.Intelligence += INT;
        }

        public void ShowAttributes()
        {
            StringBuilder stats = new StringBuilder();
            stats.AppendLine($"Character: {CharacterName} | Level {Level} | {ClassName} ");
            stats.AppendLine($"Strength: {CalculateTotalAttributes().Strenght}");
            stats.AppendLine($"Dexterity: {CalculateTotalAttributes().Dexterity}");
            stats.AppendLine($"Intelligence: {CalculateTotalAttributes().Intelligence}");
            stats.AppendLine($"Damage: {CalculateTotalDamage()}");
            Console.WriteLine(stats.ToString());
        }

        public string EquipableItemCheck(Item item)
        {
            // int level = item.ItemLevel;
            // string slot = item.ItemSlot;

            // check if item is armor or weapon
            bool isArmor = CheckEquipableArmor(item.ItemSlot);
            bool isWeapon = CheckEquipableWeapon(item.ItemSlot);

            if (isArmor)
            {
                // Custom error thrown if armor ItemLevel is too high
                if (Level < item.ItemLevel) 
                    throw new InvalidArmorException("Armor level requirment not met!");

                // Custom error thrown if armor ItemType is not equipable 
                if (!Array.Exists(EquipableArmorTypes, type => type == item.ItemType))
                    throw new InvalidArmorException("Armor type is not equipable for the character class!");

                // Equip item to Equipment (Dictionary) 
                Equipment.EquipmentSlots[item.ItemSlot] = item;

                Console.WriteLine($"\n{item.ItemName} Equipped!\n"); 

                return $"New Armor: {item.ItemName} Equipped!";
            }

            if (isWeapon)
            {
                // Custom error thrown if weapon ItemLevel is too high
                if (Level < item.ItemLevel) 
                    throw new InvalidArmorException("Armor level requirment not met!");

                // Custom error thrown if weapon ItemType is not equipable 
                if (!Array.Exists(EquipableWeaponTypes, type => type == item.ItemType))
                    throw new InvalidArmorException("Weapon type is not equipable for the character class!");

                // Equip item to Equipment (Dictionary) 
                Equipment.EquipmentSlots[item.ItemSlot] = item;

                Console.WriteLine($"\n{item.ItemName} Equipped!\n");

                return $"New Weapon: {item.ItemName} Equipped!";
            }

            return "Item not Equipable...";
        }

        public void ShowEquiped()
        {
            Console.WriteLine(Equipment.ToString());
        }
        public void Equip()
        {
            Console.WriteLine("Equipment equipped!");
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
