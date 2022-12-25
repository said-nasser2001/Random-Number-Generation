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
            if (m<2)
                return false;
            for (int i = 2; i < m; i++)
            {
                if(m % i == 0)
                {
                    return false;
                }
            }    
            return true;
        }

       public static bool PowerOfTwo(int m)
        {
            while (m>2)
            {
                if (m%2 == 0)
                    m = m/2;
                else return false;
            }
            return true;
        }

        public static int GCD(int modulus, int increment)
        {
            int Remainder;

            while (increment != 0)
            {
                Remainder = modulus % increment;
                modulus = increment;
                increment = Remainder;
            }

            return modulus;
        }
    }
    }
