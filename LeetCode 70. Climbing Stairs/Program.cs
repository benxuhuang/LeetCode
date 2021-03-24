using System;

namespace LeetCode_70._Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(4));
        }

        public static int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            int[] arr = new int[n];

            arr[0] = 1; arr[1] = 2;

            for (int i = 3; i <= n; i++)
            {
                arr[i - 1] = arr[i - 2] + arr[i - 3];
            }

            return arr[n - 1];
        }

    }
}
