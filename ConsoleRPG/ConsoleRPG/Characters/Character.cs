using System;
using System.Collections.Generic;

namespace ConsoleRPG.Characters
{
    public abstract class Character : IAttribute
    {
        // Properties for Character Class
        public string ClassName { get; set; }
        public int Level { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        // public string[] Slots { get; set; } 

        public Dictionary<string, string> Equipment { get; set; }

        private void InitCharacter()
        {
            ClassName = "CHARACTER";
            Level = 0;
            Strenght = 0;
            Dexterity = 0;
            Intelligence = 0;

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
            Console.WriteLine("Character Creation");
        }

        public void ShowAttributes()
        {
            Console.WriteLine($"Class: {ClassName} | Level: {Level}" +
                $"\nStrength: {Strenght}\nDexterity: {Dexterity}\nIntelligence: {Intelligence}");

            // print the equipment dictionary to console
            string equipment = "";
            foreach (KeyValuePair<string, string> kvp in Equipment)
            {
                equipment += string.Format("| {0} Slot: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine(equipment + " |");
        }
    }
}
