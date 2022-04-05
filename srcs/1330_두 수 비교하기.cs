using System;
using System.Linq;

namespace baekjoon.srcs
{
    class _1330
    {
        //static void Main(string[] argv) => new Solution();
        class Solution
        {
            public Solution()
            {

                int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(), s => int.Parse(s));

                int A = input[0];
                int B = input[1];

                if (A > B) Console.WriteLine(">");
                else if (A < B) Console.WriteLine("<");
                else Console.WriteLine("==");
            }
        }
    }
}
