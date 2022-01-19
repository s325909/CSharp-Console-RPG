using System;
using System.Collections.Generic;

namespace ConsoleRPG.Characters
{
    public abstract class Character : IAttribute
    {
        // Properties for Character Class
        public string ClassName { get; set; }
        public int Level { get; set; } = 1;
        public int[] LevelGains { get; set; }  

        public Attributes.PrimeAttribute BaseAttributes;
        public Attributes.PrimeAttribute TotalAttributes; 

        public Dictionary<string, string> Equipment { get; set; }

        private void InitCharacter()
        {
            // Get name of character class
            ClassName = GetType().Name;

            //TotalAttributes = new Attributes.Attribute(0, 0, 0);
            BaseAttributes = new();

            Equipment = new Dictionary<string, string>()
            {
                { "HEAD", "" },
                { "BODY", "" },
                { "LEGS", "" },
                { "WEAPON", "" },
            };
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

            // print the equipment dictionary to console
            string equipment = "";
            foreach (KeyValuePair<string, string> kvp in Equipment)
            {
                equipment += string.Format("| {0} Slot: {1}", kvp.Key, kvp.Value);
            }
           // Console.WriteLine(equipment + " |");
        }
    }
}
