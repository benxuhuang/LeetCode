using System;

namespace _0189._Rotate_Array__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(rotate(nums, 7));
        }

        public static int[] rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2) return nums;

            int len = nums.Length;

            k = k % len;

            reverse(nums, 0, nums.Length - k - 1);
            reverse(nums, nums.Length - k, nums.Length - 1);
            reverse(nums, 0, nums.Length - 1);

            return nums;
        }

        private static void reverse(int[] nums, int i, int j)
        {
            int tmp = 0;
            while (i < j)
            {
                tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                i++;
                j--;
            }
        }
    }
}
