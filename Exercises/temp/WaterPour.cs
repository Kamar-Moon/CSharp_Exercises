using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class WaterPour
    {
        public static int solution(int N, int K)
        {
            // is it possible? does K go over the capacity of all glasses togther?
            if (K > (N * (N + 1)) / 2)
            {
                return -1;
            }


            int glassesUsed = 0;
            int remaningWater = K;
            // Greedy approach - use the largest glass first start at N work way down with i--
            for (int i = N; i > 0; i--)
            {
                if (remaningWater >= i) // use the glass if remain is greanter than or = to remaining water
                {
                    glassesUsed++;
                    remaningWater -= i;
                }
                if (remaningWater == 0)
                {
                    return glassesUsed;
                }
            }
            return -1; // if no solution found
        }
    }
}
