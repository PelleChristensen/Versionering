using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Inheritance
{
    class Backpack : Taske
    {
        private bool IsWearableOnBack = true;
        public Backpack(int volume, string navn = "Rygsæk")
        {
            Kapacitet = volume;
            Navn = navn;
        }

        public int TotalWeight()
        {
            int total = 0;
            foreach (var item in _indhold)
            {
                total = item.Volume;
            }

            return total;
        }

        public void ListItems()
        {
            foreach (StoreableItem item in _indhold)
            {
                Console.WriteLine(item.Navn);
                switch (item)
                {
                    case Versionering.Inheritance.Cheese:
                        Cheese cheese = (Cheese)item;
                        Console.WriteLine("Ah! A piece of " + cheese.Navn);
                        Console.WriteLine("It gets eaten by a mouse for " + cheese.Energi + " energy");
                    break;
                    case Versionering.Inheritance.Gem:
                        Gem g = (Gem)item;
                        Console.WriteLine("Ah! A gem with the value of " + g.GetValue());
                    break;
                }
            }
        }
        public override bool HasSpace()
        {
            return _indhold.Count < Kapacitet;
        }
    }
}
