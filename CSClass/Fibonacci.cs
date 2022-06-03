using System;
using System.Collections.Generic;

namespace CSClass
{
    internal class Fibonacci
    {
        //메모이제이션
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public static long Get(int v)
        {
            Console.Write("Get( " + v + " ) 호출 -> ");
            if (v < 0) { return 0; }
            if(v == 1) { return 1; }
            if (memo.ContainsKey(v)) { return memo[v]; }
            else
            {
                memo[v] = Get(v - 2) + Get(v - 1);
            }
            Console.WriteLine();
            return Get(v - 2) + Get(v - 1);
        }
    }
}