using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Attributes
{
    public class Attribute
    {
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        //Constructors
        public Attribute()
        {

        }
        public Attribute(int STR, int DEX, int INT) 
        {
            Strenght = STR;
            Dexterity = DEX;
            Intelligence = INT;
        }

        public void AddAttributes(Attribute ATTR)
        {
            Strenght += ATTR.Strenght;
            Dexterity += ATTR.Dexterity;
            Intelligence += ATTR.Intelligence;
        }
    }
}
