using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Sieve.Classes
{
    internal static class Good
    {
        
        //These methods take in a number and return true based on whether a number is even, positive, or a multiple of ten. 

        public static bool EvenGood(int x)
        {
            if(x % 2 == 0)
                return true;
           

            return false;
        }

        public static bool PositiveGood(int x)
        {
            if(x >= 0)
            {
                return true;
            }

            return false;
        }

        public static bool TensGood(int x)
        {
            if (x % 10 == 0)
            {
                return true; 
            }

            return false;
        }
        
    }
}
