using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versionering
{
    public class Dice
    {
        public enum DICETYPE { D2, D4, D6, D8, D10, D12, D20 };
        public static int RollDice(DICETYPE type)
        {
            Random rnd = new Random();
            switch(type)
            {
                case DICETYPE.D2:
                    return rnd.Next(1,2);
                break;

                case DICETYPE.D4: 
                    return rnd.Next(1,4);
                break;
                case DICETYPE.D6: 
                    return rnd.Next(1,6);
                break;
                case DICETYPE.D8: break;
                case DICETYPE.D10: break;
                case DICETYPE.D12: break;
                case DICETYPE.D20: break;
            }
            return 1;
        }
    }
}
