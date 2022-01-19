using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public class Mage : Character
    {
        // Constructor
        public Mage()
        {
            // Character Attributes and Gains (STR, DEX, INT)
            AddAttributes(1, 1, 8);
            LevelGains = new[] { 1, 1, 5 };
        }
    }
}
