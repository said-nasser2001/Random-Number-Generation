using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generation
{
    public class LCG
    {
        public int multiplier { get; set; }
        public int seed { get; set; }
        public int increment { get; set; }
        public int modulus { get; set; }
        public int sequence_len { get; set; }

        public List<int> sequence { get; set; }
        public int cycleLen { get; set; }

        public LCG(int multiplier, int seed, int increment, int modulus, int sequence_len)
        {
            this.multiplier = multiplier;
            this.seed = seed;
            this.increment = increment;
            this.modulus = modulus;
            this.sequence_len = sequence_len;
            cycleLen = 1;

        }

        public void GenerateSequence()
        {
            sequence = new List<int>();
            for (int i = 0; i < sequence_len; i++)
            {

                seed = (multiplier * seed + increment) % modulus;
                sequence.Add(seed);

            }
            CalcCycleLen();
        }
        
        private void CalcCycleLen()
        {
            List<int> tmp = new List<int>();

            int k = modulus - 1;
            if (helperFunctions.PowerOfTwo(modulus) && increment != 0 && increment == ( 4 * k )+1)
            {

            }
           else if (helperFunctions.PowerOfTwo(modulus) && increment == 0 && seed % 2 == 1 && ((multiplier == 5 + (8 * k)) || (multiplier == 3 + (8 * k))))
            {
                cycleLen = modulus / 4;


            }
            else if (helperFunctions.isPrime(modulus) && increment == 0 && Math.Pow(multiplier,k)-1 % modulus ==0)
            {
                cycleLen = modulus - 1;
            }
            else
            {
                for (int i = 0; i < sequence_len; i++)
                {
                    if (!tmp.Contains(sequence[i]))
                    {
                        tmp.Add(sequence[i]);

                    }
                    else
                    {

                        if (tmp.Count > cycleLen)
                            cycleLen = tmp.Count;

                        tmp.Clear();
                    }
                }
            }
            Console.WriteLine(tmp.Count);

        }

    }
}
