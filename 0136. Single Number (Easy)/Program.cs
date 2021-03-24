using System;

namespace _0136._Single_Number__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 1, 2, 1, 2, 4, 8 };
            SingleNumber(nums);
        }

        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
