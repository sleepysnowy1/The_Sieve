using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Sieve.Classes
{
    internal class Sieve
    {
        Func<int, bool> predicate;

        //constructors 
        public Sieve(Func<int, bool> x) //passes in a method from the Good class. 
        {
            predicate = x;
        }

        public Sieve()
        {
            predicate = Good.PositiveGood;
        }


        //methods
        public bool IsGood(int number)
        {
            bool isGood = false;

            isGood = predicate(number);

            if(isGood)
            {
                Console.WriteLine("The number is good!"); 

            }
            else { Console.WriteLine("The number is bad :("); }

            return isGood;  
        }
    }
}
