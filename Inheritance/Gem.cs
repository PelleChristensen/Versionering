using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Inheritance
{
    internal class Gem : StoreableItem
    {
        private int _value; 
        public Gem(int value, int volume, string name) 
        { 
            _value = value;
            Navn = name; 
        }

        public int GetValue()
        {
            return _value; 
        }    

    }
}
