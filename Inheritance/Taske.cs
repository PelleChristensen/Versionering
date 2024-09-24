using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Inheritance
{
    public class Taske
    {
        protected int _kapacitet = 0;
        protected string _navn = "Beholder";
        protected List<StoreableItem> _indhold = new List<StoreableItem>();
        public int Kapacitet { get { return _kapacitet; } set { _kapacitet = value; }}
        public string Navn { get { return _navn; } set { _navn = value; } }

        public void AddItem(StoreableItem newitem)
        {
            _indhold.Add(newitem);
            Console.WriteLine("Item Added to backpack: " + newitem.Navn);
        }

        public int CountItems(StoreableItem.Type targetitem)
        {
            int count = 0;
            foreach (StoreableItem item in _indhold)
            {
                if (item.Itemtype == targetitem)
                {
                    count++;
                }
            }
            return count;
        }
        public virtual bool HasSpace()
        {
            return _indhold.Count < Kapacitet;
        }
    }
}
