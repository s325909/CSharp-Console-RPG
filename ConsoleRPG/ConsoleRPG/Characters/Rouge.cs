using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public class Rouge : Character
    {
        // Constructor
        public Rouge()
        {
            // Character base attributes and gains (STR, DEX, INT)
            AddAttributes(2, 6, 1);
            LevelGains = new[] { 1, 4, 1 };
        }
    }
}
