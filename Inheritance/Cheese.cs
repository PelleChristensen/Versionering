using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Inheritance
{
    internal class Cheese : StoreableItem
    {
        private int _energy = 5;

        public int Energi { get { return _energy; } }
        public Cheese(int weight, string cheesename, Type type = Type.FOOD) 
        {
            Volume = weight; 
            Navn = cheesename;
            Itemtype = type;
        }
    }
}
