using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public class Ranger : Character
    {
        // Constructor
        public Ranger()
        {
            // Character Attributes and Gains (STR, DEX, INT)
            AddAttributes(1, 7, 1);
            LevelGains = new[] { 1, 5, 1 }; 
        }
    }
}
