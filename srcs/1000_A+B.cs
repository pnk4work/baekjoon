using System;
using System.Linq;

namespace baekjoon.srcs
{
    class _1000
    {
        //static void Main(string[] argv) => new Solution();
        class Solution
        {
            public Solution()
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(), s => int.Parse(s));
                int[] vals = (from num in input select num).ToArray();

                Console.WriteLine(vals[0] + vals[1]);
            }
        }
    }
}
