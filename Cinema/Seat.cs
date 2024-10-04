using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering.Cinema
{
    class Seat
    {
        public int row;
        public int column;
        public bool reserved;

        public Seat(int row, int column)
        {
            this.row = row;
            this.column = column;
            reserved = false;
        }

        public bool IsReserved()
        {
            return reserved;
        }
    }
}
