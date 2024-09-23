using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class ReverseNumber
    {
        public static void solution(int N)
        {
            Console.WriteLine("Reversing Numbers with input: " + N);

            // Variable to track if we should start printing digits
            int enablePrint = 0; // Change from N % 10 to 0

            // Process each digit from right to left
            while (N > 0)
            {
                if (enablePrint == 0 && N % 10 != 0)
                {
                    enablePrint = 1;
                }
                if (enablePrint == 1)
                {
                    Console.Write(N % 10); // Print the digit
                }
                N = N / 10; // Remove the rightmost digit
            }
            // Print new line after number
            Console.WriteLine();
        }
    }
}
