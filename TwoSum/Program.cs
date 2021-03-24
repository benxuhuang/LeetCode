using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSumWithDic(new int[] { 11, 7, 15, 2 }, 9);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return nums;
        }

        public static int[] TwoSumWithDic(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (dic.ContainsKey(diff))
                {
                    return new int[] { dic[diff], i };
                }
                else
                {
                    if (!dic.ContainsKey(nums[i]))
                    {
                        dic.Add(nums[i], i);
                    }
                }
            }

            return nums;
        }
    }
}
