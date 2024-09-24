using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Inheritance
{
    
    internal class Vehicle
    {
        private string _brand;
        private string _name;
        public string Brand { get => _brand; set => _brand = value; }
    }
}
