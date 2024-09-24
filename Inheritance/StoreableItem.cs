using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Inheritance
{
    public class StoreableItem
    {
        private int _volume;
        private string _name;
        public enum Type { NONE, FOOD, VALUABLE, WEAPON }

        protected Type _itemtype; 

        public Type Itemtype { get { return _itemtype; } protected set { _itemtype = value; } }
        public int Volume { get { return _volume; } protected set { _volume = value; }}
        public string Navn { get { return _name; } protected set { _name = value; }}
    }
}
