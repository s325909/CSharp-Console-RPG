using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Attributes
{
    public class WeaponAttribute
    {
        // Properties 
        public int BaseDamage { get; set; }
        public double AttackSpeed { get; set; }

        // Constructor
        public WeaponAttribute(int damage, double speed)
        {
            BaseDamage = damage;
            AttackSpeed = speed;
        }

        public WeaponAttribute() { }
    }
}
