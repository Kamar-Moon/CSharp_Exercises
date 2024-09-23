using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class ASCII
    {
        public static void solution(int N)
        {
            for (int i = 1; i <= N; i++) // without the <= the loop doesn't execute right number of times
            {
                if (i < N)
                {
                    Console.WriteLine("L");
                }
                else
                {
                    Console.WriteLine(new string('L', N));
                    // string constuctor pass in L to represent and N for number of times to repeat on the last line
                }
            }
        }
    }
}
