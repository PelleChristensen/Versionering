using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Cinema
{
    class CinemaHall
    {
        private List<Seat> seats;

        public CinemaHall(int rows, int coloumns)
        {
            seats = new List<Seat>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloumns; j++)
                {
                    Seat seat = new Seat(i, j);
                    seats.Add(seat);
                }
            }
        }

        public bool IsSeatTaken(int row, int coloumn)
        {
            foreach (Seat seat in seats)
            {
                if (row == seat.row && coloumn == seat.column)
                {
                    return seat.IsReserved();
                }
            }
            return true;
        }
    }
}
