using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering
{
    public class Dice
    {
        public static int RollDice()
        {
            return Random.Shared.Next(1, 6);
        }
    }


}
