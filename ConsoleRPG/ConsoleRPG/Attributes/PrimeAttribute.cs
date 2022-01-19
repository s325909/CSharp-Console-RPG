using System;

namespace ConsoleRPG.Attributes
{
    public class PrimeAttribute
    {
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        //Constructors
        public PrimeAttribute()
        {

        }
        public PrimeAttribute(int STR, int DEX, int INT) 
        {
            Strenght = STR;
            Dexterity = DEX;
            Intelligence = INT;
        }

        public void AddAttributes(PrimeAttribute ATTR)
        {
            Strenght += ATTR.Strenght;
            Dexterity += ATTR.Dexterity;
            Intelligence += ATTR.Intelligence;
        }
    }
}
