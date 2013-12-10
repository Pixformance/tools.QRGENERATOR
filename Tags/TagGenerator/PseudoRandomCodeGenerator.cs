using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGenerator
{
    // Algorithm taken from https://github.com/bobbaluba/rlcg
    // In preliminary tests, there were few repetitions, so it should be good enough for our purposes
    class PseudoRandomCodeGenerator
    {
        UInt64 M = 1ul<<63;                                // Modulus
        UInt64 A = 6364136223846793005ul;                  // Multiplicand
        UInt64 C = 1442695040888963407;                    // Increment
        int    D = 32;                                     // Least significant bits to discard
        HashSet<UInt32> generated = new HashSet<UInt32>(); // The numbers that we have already generated

        UInt64 x;                          // Last generated value/seed

        // We discard the test for power of 2, as 
        public PseudoRandomCodeGenerator() {
            x = 42;
        }

        public UInt32 next(int steps = 1)
        {
            UInt32 result = 0;
            for (int i = 1; i <= steps; ++i)
            {
                do
                {
                    x = (A * x + C) & (M - 1);
                    result = (UInt32) (x >> D);
                }  while (generated.Contains(result));

            }
            return result;
        }
    }
}
