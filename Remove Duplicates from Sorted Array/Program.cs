using System;

namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};

            var result = removeDuplicates(arr);

        }

        public static int removeDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
