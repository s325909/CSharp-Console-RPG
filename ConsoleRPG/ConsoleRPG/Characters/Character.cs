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

        public int[] LevelAttributeGains { get; set; }
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
            Console.WriteLine($"\nA {ClassName} is born!");
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

        /// <summary>
        /// Calaculates total primary attributes character base attributes + equipped armor attributes
        /// </summary>
        /// <returns>Total Attributes</returns>
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

        /// <summary>
        /// Levels up chracter while adding character attribute gains to base primary attributes 
        /// </summary>
        public void GainLevelAndAttributes()
        {
            int STR = LevelAttributeGains[0];
            int DEX = LevelAttributeGains[1];
            int INT = LevelAttributeGains[2];
            AddAttributes(STR, DEX, INT);

            Level++;
            ShowAttributes();
        }

        /// <summary>
        /// Allows each character to add attribute gains to base primary attributes
        /// </summary>
        /// <param name="STR"></param>
        /// <param name="DEX"></param>
        /// <param name="INT"></param>
        public void AddAttributes(int STR, int DEX, int INT)
        {
            BaseAttributes.Strenght += STR;
            BaseAttributes.Dexterity += DEX;
            BaseAttributes.Intelligence += INT;
        }

        /// <summary>
        /// Uses StringBuilder to display character stats to console
        /// </summary>
        public void ShowAttributes()
        {
            StringBuilder stats = new StringBuilder();
            stats.AppendLine($"\nName: {CharacterName} [Level {Level} {ClassName}]");
            stats.AppendLine($"Strength: {CalculateTotalAttributes().Strenght}");
            stats.AppendLine($"Dexterity: {CalculateTotalAttributes().Dexterity}");
            stats.AppendLine($"Intelligence: {CalculateTotalAttributes().Intelligence}");
            stats.AppendLine($"Damage: {CalculateTotalDamage()}");
            Console.WriteLine(stats.ToString());
        }

        /// <summary>
        /// Checks to see if charater is worthy to equip an item to a given equipment slot
        /// Throws custom exceptions if character is too low level or is not able to equip the type
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string EquipableItemCheck(Item item)
        {
            // check if item is of armor or weapon type 
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
                ShowEquiped();

                return $"New armor equipped!";
            }

            if (isWeapon)
            {
                // Custom error thrown if weapon ItemLevel is too high
                if (Level < item.ItemLevel) 
                    throw new InvalidWeaponException("Weapon level requirment not met!");

                // Custom error thrown if weapon ItemType is not equipable 
                if (!Array.Exists(EquipableWeaponTypes, type => type == item.ItemType))
                    throw new InvalidWeaponException("Weapon type is not equipable for the character class!");

                // Equip item to Equipment (Dictionary) 
                Equipment.EquipmentSlots[item.ItemSlot] = item;

                Console.WriteLine($"\n{item.ItemName} Equipped!\n");
                ShowEquiped();

                return $"New weapon equipped!";
            }

            return "Item not Equipable...";
        }

        public void ShowEquiped()
        {
            Console.WriteLine(Equipment.ToString());
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
