using System;

namespace Maximum_Subarray__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = maxSubArray(nums);
            Console.WriteLine(result);
        }

        public static int maxSubArray(int[] nums)
        {
            int result = nums[0];
            int current = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                current += nums[i];
           
                if (current < 0 || current < nums[i])
                    current = nums[i];

                if (current > result)
                    result = current;
            }

            return result;
        }

    }
}
