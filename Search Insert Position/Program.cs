using System;

namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            var result = SearchInsert(nums, 0);
            Console.WriteLine(result);
        }

        public static int SearchInsert(int[] nums, int target)
        {

            if (nums.Length == 0 || nums == null)
            {
                return 0;
            }

            int mid = 0;
            int lo = 0;
            int up = nums.Length - 1;

            while (lo <= up)
            {

                mid = (lo + up) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target > nums[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    up = mid - 1;
                }
            }

            return lo;
        }
    }
}
