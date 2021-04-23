using System;

namespace _0096.Unique_Binary_Search_Trees__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumTrees(5));
        }


        public static int NumTrees(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            return dp[n];
        }
    }
}
