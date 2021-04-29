using System;

namespace _0213.House_Robber_II__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 3, 2, 5, 6, 9, 4, 3, 9 };
            Console.WriteLine(Rob(num));
        }

        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            int l = nums.Length;
            int res, prev, curr;

            // rob house 0 -> can't rob house l-1 -> result = dp[l-2]
            prev = nums[0];
            curr = nums[0];
            for (int i = 2; i < l - 1; ++i)
            {
                int tmp = prev;
                prev = curr;
                curr = Math.Max(prev, tmp + nums[i]);
            }
            res = curr;

            // don't rob house 0 -> result = dp[l-1]
            prev = 0;
            curr = nums[1];
            for (int i = 2; i < l; ++i)
            {
                int tmp = prev;
                prev = curr;
                curr = Math.Max(prev, tmp + nums[i]);
            }
            res = Math.Max(res, curr);

            return res;
        }
    }
}
