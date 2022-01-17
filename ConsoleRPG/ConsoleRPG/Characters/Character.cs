using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public abstract class Character : IAttribute
    {
        // Properties for Character Class
        public string ClassName { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public Dictionary<string, string> Equipment { get; set; }

        // Constructors
        public Character() 
        {
            this.ClassName = "CHARACTER";
            this.Strenght = 0;
            this.Dexterity = 0;
            this.Intelligence = 0;

            this.Equipment = new Dictionary<string, string>()
            {
                { "HEAD", "" },
                { "BODY", "" },
                { "LEGS", "" },
                { "WEAPON", "" },
            };
            Console.WriteLine("Character Creation");
        }

        public void ShowStats()
        {
            Console.WriteLine($"Class: {ClassName}" +
                $"\nStrength: {Strenght}\nDexterity: {Dexterity}\nIntelligence: {Intelligence}");
        }
    }
}
