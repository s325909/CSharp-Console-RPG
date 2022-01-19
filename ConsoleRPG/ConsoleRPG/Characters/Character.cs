using System;
using ConsoleRPG.Attributes;
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


        private void InitCharacter()
        {
            // Get name of character class
            ClassName = GetType().Name;

            //TotalAttributes = new Attributes.Attribute(0, 0, 0);
            BaseAttributes = new();
            ArmorAttributes = new();
            WeaponAttribute = new();
            TotalAttributes = new();

            Console.WriteLine("INIT EQUIPMENT");
            Equipment = new();

            // Equipment.EquipmentSlots = new();

            // Equipment.EquipmentSlots.GetEnumerator()
            

            // String[] slots = Enum.GetNames(typeof(Eq EquipSlots));


            // Console.WriteLine(Equipment.ToString());
            // Equipment.EquipmentSlots();
        }

        // Constructors
        public Character() 
        {
            InitCharacter();
            Console.WriteLine($"A {ClassName} is born!");
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
            throw new NotImplementedException();
        }

        public void ShowEquiped()
        {
            // Console.WriteLine(Equipment.EquipmentSlots.ToString());
            // Console.WriteLine(Equipment.EquipmentSlots);

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
    }
}
