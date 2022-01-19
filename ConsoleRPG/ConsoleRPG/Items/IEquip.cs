using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    public interface IEquip
    {
        public void Equip();

        public abstract void ShowEquiped();
    }
}
