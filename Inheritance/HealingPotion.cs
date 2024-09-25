using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Inheritance
{
    internal class HealingPotion
    {
        int bonus = 10; 

        public int Bonus { get { return bonus; } private set { bonus = value; } }

        public HealingPotion() { }
    }
}
