using System;
using System.Collections.Generic;

namespace _0198._House_Robber__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 9, 3, 1 };
            Console.WriteLine(Rob(nums));
        }

        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            int[] max = new int[nums.Length];

            max[0] = nums[0];
            max[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                //最大金額 = Max(此間金額 + 前前一間所累計的最大金額, 前一棟間累計金額)
                max[i] = Math.Max(nums[i] + max[i - 2], max[i - 1]);
            }

            return max[nums.Length - 1];
        }
    }
}
