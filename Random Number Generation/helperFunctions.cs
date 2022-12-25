using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generation
{
    public class helperFunctions
    {
       public static bool isPrime(int m)
        {
            int counter = 0;
            if (m<2)
                return false;
            for (int i = 1; i < m; i++)
            {
                if(m % i == 0)
                {
                    counter++;
                }
                if(counter>1)
                    return false;
            }    
            return counter == 1;
        }

       public static bool PowerOfTwo(int m)
        {
            return (m & (m - 1)) == 0;
        }
    }
}
