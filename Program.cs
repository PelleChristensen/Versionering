using System.Linq.Expressions;
using Versionering.Cinema;
using Versionering.Inheritance;

namespace Versionering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CinemaHall hall;

            hall = new CinemaHall(12, 12);

            hall.IsSeatTaken(10, 10);
        }
    }
}
