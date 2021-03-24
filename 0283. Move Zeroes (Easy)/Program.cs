using System;

namespace _0283._Move_Zeroes__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };

            Console.WriteLine(MoveZeroes(nums));
        }

        public static int[] MoveZeroes(int[] nums)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            while (index < nums.Length)
            {
                nums[index] = 0;
                index++;
            }

            return nums;
        }
    }
}
