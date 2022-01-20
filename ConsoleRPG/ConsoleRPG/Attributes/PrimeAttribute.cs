using System;

namespace ConsoleRPG.Attributes
{
    public class PrimeAttribute
    {
        // Properties 
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        // Constructors
        public PrimeAttribute() { }
        public PrimeAttribute(int STR, int DEX, int INT) 
        {
            Strenght = STR;
            Dexterity = DEX;
            Intelligence = INT;
        }

        /// <summary>
        /// Adds primary attributes to each character attributes (STR, DEX, INT)
        /// </summary>
        /// <param name="ATTR"></param>
        public void AddAttributes(PrimeAttribute ATTR)
        {
            Strenght += ATTR.Strenght;
            Dexterity += ATTR.Dexterity;
            Intelligence += ATTR.Intelligence;
        }
    }
}
