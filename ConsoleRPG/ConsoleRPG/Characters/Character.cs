using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public abstract class Character
    {
        // Properties for Character Class
        public int ClassName { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public Dictionary<string, string> Equipment { get; set; }


        // public Character() {}

    }
}
