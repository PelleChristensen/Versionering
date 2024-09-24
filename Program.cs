using System.Linq.Expressions;
using Versionering.Inheritance;

namespace Versionering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string obj = Console.ReadLine();

            Backpack bp = new Backpack(10);
            Cheese c = new Cheese(2, "Manchego");
            Gem g = new Gem(4,1, "Jade");

            bp.AddItem(c);
            bp.AddItem(g);

            bp.ListItems();


        }
    }
}
