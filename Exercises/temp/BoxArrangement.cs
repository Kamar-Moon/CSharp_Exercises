using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class BoxArrangment
    {
        public static int solution(int[] A)
        {
            // Implement your solution here

            int[] result = new int[A.Length];

            Array.Copy(A, result, A.Length);

            int i = 0;
            int moves = 0;

            while (i < result.Length)
            {
                // if value exceeds 10 at index i
                if (result[i] > 10)
                {
                    int remainder = result[i] - 10; //calculate remainder
                    result[i] = 10;
                    moves++;

                    // add remainder to next elemnt if possible
                    if (i + 1 < result.Length)
                    {
                        result[i + 1] += remainder;
                    }
                }
                // move to the next elemnt in array
                i++;
            }
            return moves; // return solved array
        }
    }
}
